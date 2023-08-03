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
        private string selectedCategory;
        public static int ElapsedTimeInSeconds { get; set; }
        private ISessionHandler sessionHandler;
        private Session currentSession;

        public GUI()
        {
            InitializeComponent();

            timer1.Tick += timer1_Tick;
            FormFunctions.SetTodayDate(this, labelTodayDate);
            sessionHandler = new SessionFileHandler("Backend/SessionData.txt");
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
            List<Session> sessions = sessionHandler.LoadSessions();

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
            }
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
            // Check if a category and subcategory are selected, if so begin a new session
            // selectedCategory and selectedSubCategory are assumed to be the currently selected category and subcategory
            sessionManager.BeginSession(selectedCategory, selectedSubCategory);
        }


        /*
        TreeNode selectedNode = treeViewCategories.SelectedNode;

        if (selectedNode != null)
        {
            string selectedCategory;
            string selectedSubCategory;
            if (selectedNode.Parent != null)
            {
                selectedCategory = selectedNode.Parent.Text;
                selectedSubCategory = selectedNode.Text;
            }
            else
            {
                selectedCategory = selectedNode.Text;
                selectedSubCategory = ""; // no subcategory selected
            }
            //selectedCategory = selectedNode.Text;
            labelTimerCategory.Text = "Session focus: " + selectedCategory;
            ElapsedTimeInSeconds = 0;
            labelTimerDisplay.Text = "00h 00m 00s";

            timer1.Start();

            string subCategory = selectedNode.FirstNode != null ? selectedNode.FirstNode.Text : "";
            Session session = new Session(DateTime.Now, new TimeSpan(0), selectedCategory, subCategory);
            currentSession = new Session
            {
                StartTime = DateTime.Now,
                Duration = new TimeSpan(0),
                Category = selectedCategory,
                SubCategory = selectedSubCategory,
                Date = DateTime.Today
            };

            btnBegin.Text = "Switch session focus";
            btnBegin.BackColor = Color.Yellow;
            btnHalt.BackColor = Color.Red;
        }
        else
        {
            MessageBox.Show("Please select a category before clicking Begin.", "Category Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        } */

        /*if (btnBegin.Text == "Begin")
        {
            // Start timer
            btnBegin.Text = "Switch session focus";
            btnBegin.BackColor = Color.Yellow; // Or any color you prefer
        }
        else
        {
            // Pause timer
            btnBegin.Text = "Begin";
            btnBegin.BackColor = Color.Green; // Or any color you prefer
        }*/
    //}
    private void timer1_Tick(object sender, EventArgs e)
        {
            //FormFunctions.Timer_Tick(sender, e, labelTimerDisplay);
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
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void treeViewCategories_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

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
