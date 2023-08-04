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

        private void GUI_Load(object sender, EventArgs e)
        {
            treeViewCategories.Nodes.Add("Work");
            treeViewCategories.Nodes.Add("Recreation");
            treeViewCategories.Nodes.Add("Goal Focus");
            /*List<Session> sessions = sessionHandler.LoadSessions();

            foreach (var session in sessions)
            {
                TreeNode[] foundNodes = treeViewCategories.Nodes.Find(session.Category, false);

                if (foundNodes.Length == 0)
                {
                    TreeNode categoryNode = treeViewCategories.Nodes.Add(session.Category);
                    if (!string.IsNullOrEmpty(session.SubCategory))
                    {
                        categoryNode.Nodes.Add(session.SubCategory);
                    }
                }
                else
                {
                    TreeNode categoryNode = foundNodes[0];
                    if (!string.IsNullOrEmpty(session.SubCategory) && !categoryNode.Nodes.ContainsKey(session.SubCategory))
                    {
                        categoryNode.Nodes.Add(session.SubCategory);
                    }
                }
            }*/
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
                // Extract Category and Subcategory from the selected node
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

                // Update UI
                labelTimerCategory.Text = $"Timer for: {category} - {subcategory}";
                ElapsedTimeInSeconds = 0;
                labelTimerDisplay.Text = "00h 00m 00s";

                // Start the session
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
            /* //FormFunctions.Timer_Tick(sender, e, labelTimerDisplay);
             FormFunctions.Timer_Tick(sender, e, labelTimerDisplay);
             if (currentSession != null)
             {
                 // Increase session duration by 1 minute
                 currentSession.Duration = currentSession.Duration.Add(TimeSpan.FromMinutes(1));

                 // Save updated session
                 // Assuming sessionHandler is your ISessionHandler instance
                 sessionHandler.SaveSession(currentSession);
             }

             //Application.DoEvents();
             //MessageBox.Show("(test code)Timer activated successfully!");
            */
        }



        private void label2_Click(object sender, EventArgs e)        {


        }

        private void treeViewCategories_AfterSelect(object sender, TreeViewEventArgs e)       {
        }

        private void label6_Click(object sender, EventArgs e)        {
        }

        private void label6_Click_1(object sender, EventArgs e)        {
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
