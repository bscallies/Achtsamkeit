using System;
using System.Windows.Forms;

namespace Achtsamkeit
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.label1 = new System.Windows.Forms.Label();
            this.treeViewCategories = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewSubcategory = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTodayDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTimerDisplay = new System.Windows.Forms.Label();
            this.labelTimerCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Achtsamkeit - Mindfulness";
            // 
            // treeViewCategories
            // 
            this.treeViewCategories.Location = new System.Drawing.Point(38, 141);
            this.treeViewCategories.Name = "treeViewCategories";
            this.treeViewCategories.Size = new System.Drawing.Size(266, 210);
            this.treeViewCategories.TabIndex = 1;
            this.treeViewCategories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCategories_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add a subcategory: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxNewSubcategory
            // 
            this.textBoxNewSubcategory.Location = new System.Drawing.Point(120, 357);
            this.textBoxNewSubcategory.Name = "textBoxNewSubcategory";
            this.textBoxNewSubcategory.Size = new System.Drawing.Size(155, 20);
            this.textBoxNewSubcategory.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 78);
            this.label4.TabIndex = 6;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 64);
            this.button2.TabIndex = 7;
            this.button2.Text = "Begin Session!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Session goal:";
            // 
            // labelTodayDate
            // 
            this.labelTodayDate.AutoSize = true;
            this.labelTodayDate.Location = new System.Drawing.Point(345, 9);
            this.labelTodayDate.Name = "labelTodayDate";
            this.labelTodayDate.Size = new System.Drawing.Size(35, 13);
            this.labelTodayDate.TabIndex = 9;
            this.labelTodayDate.Text = "label6";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // labelTimerDisplay
            // 
            this.labelTimerDisplay.AutoSize = true;
            this.labelTimerDisplay.Location = new System.Drawing.Point(236, 469);
            this.labelTimerDisplay.Name = "labelTimerDisplay";
            this.labelTimerDisplay.Size = new System.Drawing.Size(68, 13);
            this.labelTimerDisplay.TabIndex = 10;
            this.labelTimerDisplay.Text = "00h 00m 00s";
            this.labelTimerDisplay.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelTimerCategory
            // 
            this.labelTimerCategory.AutoSize = true;
            this.labelTimerCategory.Location = new System.Drawing.Point(53, 469);
            this.labelTimerCategory.Name = "labelTimerCategory";
            this.labelTimerCategory.Size = new System.Drawing.Size(67, 13);
            this.labelTimerCategory.TabIndex = 11;
            this.labelTimerCategory.Text = "Sesson timer";
            this.labelTimerCategory.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 554);
            this.Controls.Add(this.labelTimerCategory);
            this.Controls.Add(this.labelTimerDisplay);
            this.Controls.Add(this.labelTodayDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNewSubcategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeViewCategories);
            this.Controls.Add(this.label1);
            this.Name = "GUI";
            this.Text = "Achtsamkeit";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeViewCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewSubcategory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTodayDate;
        private Timer timer1;
        private Label labelTimerDisplay;
        private Label labelTimerCategory;
    }
}