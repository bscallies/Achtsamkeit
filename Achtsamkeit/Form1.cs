using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Achtsamkeit
{
    public partial class GUI : Form
    {
        private string selectedCategory;
        public static int ElapsedTimeInSeconds { get; set; }
        public GUI()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            FormFunctions.SetTodayDate(this, labelTodayDate);
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
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //
        //Begin button
        //
        private void button2_Click(object sender, EventArgs e)
        {

            TreeNode selectedNode = treeViewCategories.SelectedNode;

            if (selectedNode != null)
            {
                selectedCategory = selectedNode.Text;
                labelTimerCategory.Text = "Timer for: " + selectedCategory;
                ElapsedTimeInSeconds = 0;
                labelTimerDisplay.Text = "00h 00m 00s";

                timer1.Start();
            }
            else
            {
                MessageBox.Show("Please select a category before clicking Begin.", "Category Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //FormFunctions.Timer_Tick(sender, e, labelTimerDisplay);
            FormFunctions.Timer_Tick(sender, e, labelTimerDisplay);
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
    }
}
