using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Achtsamkeit.Backend;


namespace Achtsamkeit
{
    public partial class GUI : Form
    {
        //private string selectedCategory;
        public static int ElapsedTimeInSeconds { get; set; }
        private ISessionHandler sessionHandler;
        private Session currentSession;
        private CategoryManager categoryManager = new CategoryManager();

        public GUI()
        {
            InitializeComponent();

            timer1.Tick += timer1_Tick;
            FormFunctions.SetTodayDate(this, labelTodayDate);

            string dataPath = "SessionData.txt"; //Changed path
            Console.WriteLine(Path.GetFullPath("SessionData.txt"));
            sessionHandler = new SessionFileHandler(dataPath);

            if (File.Exists("categories.json"))
            {
                var categories = JsonConvert.DeserializeObject<List<Category>>(File.ReadAllText("categories.json"));
                foreach (var category in categories)
                {
                    var categoryNode = treeViewCategories.Nodes.Add(category.Name);
                    foreach (var subcategory in category.Subcategories)
                    {
                        categoryNode.Nodes.Add(subcategory);
                    }
                }
                Console.WriteLine(Path.GetFullPath("categories.json"));
            }
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            AddCategoryIfNotExists("Work");
            AddCategoryIfNotExists("Recreation");
            AddCategoryIfNotExists("Goal Focus");

            CleanUpDuplicateCategories();
            UpdateStatistics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode selectedCategory = treeViewCategories.SelectedNode;
            if (selectedCategory != null)
            {
                selectedCategory.Nodes.Add(textBoxNewSubcategory.Text);
                textBoxNewSubcategory.Clear();
            }
        }
      
        private void UpdateTodayUsage()
        {
            if (sessionHandler is SessionFileHandler sessionFileHandler)
            {
                var usageToday = sessionFileHandler.GetTodayUsageByCategoryAndSubcategory();
                //var usageTodayText = usageToday.Select(kvp => $"{kvp.Key}: {FormFunctions.FormatTimespanIntoDigitalClock(kvp.Value)}");
                var usageTodayText = usageToday.Select(kvp => $"{kvp.Key.Item1} - {kvp.Key.Item2}: {FormFunctions.FormatTimespanIntoDigitalClock(kvp.Value)}");


                // Calculate total usage
                TimeSpan totalUsage = TimeSpan.Zero;
                foreach (var time in usageToday.Values)
                {
                    totalUsage += time;
                }

                // Add total usage to the end
                textBoxTodayUsage.Text = string.Join(Environment.NewLine, usageTodayText) +
                                         Environment.NewLine + $"Total: {FormFunctions.FormatTimespanIntoDigitalClock(totalUsage)}";
            }
        }

        private void UpdateStatistics()
        {
            if (sessionHandler is SessionFileHandler sessionFileHandler)
            {
                // Get the stats
                DateTime today = DateTime.Today;
                TimeSpan avgDurationToday = sessionFileHandler.GetAverageDurationForDay(today);
                TimeSpan totalDurationLast7Days = sessionFileHandler.GetTotalDurationForLast7Days();
                TimeSpan avgDurationLast7Days = sessionFileHandler.GetAverageDurationForLast7Days();

                // Format the stats
                string avgDurationTodayText = FormFunctions.FormatTimespanIntoDigitalClock(avgDurationToday);
                string totalDurationLast7DaysText = FormFunctions.FormatTimespanIntoDigitalClock(totalDurationLast7Days);
                string avgDurationLast7DaysText = FormFunctions.FormatTimespanIntoDigitalClock(avgDurationLast7Days);

                // Display the stats
                textBoxStatistics.Text = $"Average Duration Today: {avgDurationTodayText}" + Environment.NewLine +
                                         $"Total Duration Last 7 Days: {totalDurationLast7DaysText}" + Environment.NewLine +
                                         $"Average Duration Last 7 Days: {avgDurationLast7DaysText}";
            }
        }


        //Begin button
        private SessionManager sessionManager = new SessionManager(new SessionFileHandler("SessionData.txt"));

        private void btnBegin_Click(object sender, EventArgs e)
        {
            TreeNode selectedCategoryNode = treeViewCategories.SelectedNode;
            if (selectedCategoryNode != null)
            {
                string category;
                string subcategory;
                HandleNewSession(selectedCategoryNode, out category, out subcategory);

                // Save categories and subcategories to a file.
                List<Category> categories = treeViewCategories.Nodes
                    .Cast<TreeNode>()
                    .Select(n => new Category
                    {
                        Name = n.Text,
                        Subcategories = n.Nodes.Cast<TreeNode>().Select(s => s.Text).ToList()
                    }).ToList();
                File.WriteAllText("categories.json", JsonConvert.SerializeObject(categories));

                labelTimerCategory.Text = $"Timer for: {category} - {subcategory}";
                ElapsedTimeInSeconds = 0;
                labelTimerDisplay.Text = "00h 00m 00s";

                timer1.Start();
                currentSession = new Session(DateTime.Now, new TimeSpan(0), category, subcategory);

                btnBegin.Text = "Switch Focus";
                btnBegin.BackColor = Color.Yellow;
                btnHalt.BackColor = Color.Red;
            }
        }
        private void HandleNewSession(TreeNode selectedCategoryNode, out string category, out string subcategory)
        {
            categoryManager.GetCategoryAndSubcategory(selectedCategoryNode, textBoxNewSubcategory.Text, out category, out subcategory);
            List<Category> categories = categoryManager.GetCategoriesFromTreeView(treeViewCategories.Nodes);
            // Call the method in SessionManager with the extracted category and subcategory
            sessionManager.HandleNewSession(category, subcategory);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentSession != null)
            {
                ElapsedTimeInSeconds++;
                currentSession.Duration = TimeSpan.FromSeconds(ElapsedTimeInSeconds);
                labelTimerDisplay.Text = currentSession.Duration.ToString(@"hh\:mm\:ss");

                // Update total usage.
                if (sessionHandler is SessionFileHandler sessionFileHandler)
                {
                    sessionFileHandler.AddTimeToCategory(currentSession.Category, TimeSpan.FromSeconds(1));
                    UpdateTodayUsage();
                }
            }
        }
        private void EndAndSaveSession()
        {
            if (currentSession != null)
            {
                timer1.Stop();
                sessionHandler.SaveSession(currentSession);
                currentSession = null;
            }
        }
        private void btnHalt_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnBegin.Text = "Begin";
            btnBegin.BackColor = Color.Green;
            btnHalt.BackColor = Color.Gray;
        }

        private void textBoxNewSubcategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCategoryIfNotExists(string categoryName)
        {
            if (!treeViewCategories.Nodes.ContainsKey(categoryName))
            {
                treeViewCategories.Nodes.Add(categoryName);
            }
        }

        private void CleanUpDuplicateCategories()
        {
            var categoryNodes = treeViewCategories.Nodes.Cast<TreeNode>().ToList();
            var uniqueCategories = new HashSet<string>();

            foreach (var node in categoryNodes)
            {
                if (uniqueCategories.Contains(node.Text))
                {
                    // If the category already exists, remove the node from the tree view
                    treeViewCategories.Nodes.Remove(node);
                }
                else
                {
                    // If the category doesn't exist yet, add it to the unique categories set
                    uniqueCategories.Add(node.Text);
                }
            }
        }

        private void labelTimerDisplay_Click(object sender, EventArgs e)
        {

        }

        private void labelTimerCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
