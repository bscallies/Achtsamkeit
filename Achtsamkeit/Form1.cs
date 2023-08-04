using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Achtsamkeit.Backend;

namespace Achtsamkeit
{
    public partial class GUI : Form
    {
        //private string selectedCategory;
        public static int ElapsedTimeInSeconds { get; set; }
        private ISessionHandler sessionHandler;
        private Session currentSession;

        public GUI()
        {
            InitializeComponent();

            timer1.Tick += timer1_Tick;
            FormFunctions.SetTodayDate(this, labelTodayDate);

            string dataPath = "SessionData.txt"; //Changed path
            sessionHandler = new SessionFileHandler(dataPath);
            //sessionHandler = new SessionFileHandler("../../../../SessionData.txt");
        }
        private void GUI_Load(object sender, EventArgs e)
        {
            treeViewCategories.Nodes.Add("Work");
            treeViewCategories.Nodes.Add("Recreation");
            treeViewCategories.Nodes.Add("Goal Focus");
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
            var usageToday = sessionHandler.GetTodayUsageByCategory();
            textBoxTodayUsage.Text = string.Join(Environment.NewLine,
                usageToday.Select(kvp => $"{kvp.Key}: {FormFunctions.FormatTimespanIntoDigitalClock(kvp.Value)}"));
        }
        //
        //Begin button
        //
        private SessionManager sessionManager = new SessionManager(new SessionFileHandler("SessionData.txt"));

        private void btnBegin_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewCategories.SelectedNode;

            if (selectedNode != null)
            {
                string category, subcategory;
                if (selectedNode.Parent == null)
                {
                    // This is a root node, meaning it's a category
                    category = selectedNode.Text;
                    subcategory = "General"; // Default subcategory
                }
                else
                {
                    // This is a child node, meaning it's a subcategory
                    category = selectedNode.Parent.Text;
                    subcategory = selectedNode.Text;
                }
                labelTimerCategory.Text = $"Timer for: {category} - {subcategory}";
                ElapsedTimeInSeconds = 0;
                labelTimerDisplay.Text = "00h 00m 00s";

                timer1.Start();
                currentSession = new Session(DateTime.Now, new TimeSpan(0), category, subcategory);

                btnBegin.Text = "Switch Focus";
                btnBegin.BackColor = Color.Yellow;
                btnHalt.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Please select a category before clicking Begin.", "Category Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentSession != null)
            {
                ElapsedTimeInSeconds++;
                currentSession.Duration = TimeSpan.FromSeconds(ElapsedTimeInSeconds);
                labelTimerDisplay.Text = currentSession.Duration.ToString(@"hh\:mm\:ss");
                Console.WriteLine("Timer ticked. Saving session."); // Debugging
                sessionHandler.SaveSession(currentSession);
            }
            UpdateTodayUsage();
        }
        private void btnHalt_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnBegin.Text = "Begin";
            btnBegin.BackColor = Color.Green;
            btnHalt.BackColor = Color.Gray;
        }
    }
}
