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
            this.btnBegin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTodayDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTimerDisplay = new System.Windows.Forms.Label();
            this.labelTimerCategory = new System.Windows.Forms.Label();
            this.btnHalt = new System.Windows.Forms.Button();
            this.textBoxTodayUsage = new System.Windows.Forms.TextBox();
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add a subcategory: ";
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
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(38, 384);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(200, 64);
            this.btnBegin.TabIndex = 7;
            this.btnBegin.Text = "Begin Session!";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
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
            this.labelTodayDate.Location = new System.Drawing.Point(373, 18);
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
            this.labelTimerDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimerDisplay.Location = new System.Drawing.Point(236, 469);
            this.labelTimerDisplay.Name = "labelTimerDisplay";
            this.labelTimerDisplay.Size = new System.Drawing.Size(116, 24);
            this.labelTimerDisplay.TabIndex = 10;
            this.labelTimerDisplay.Text = "00h 00m 00s";
            // 
            // labelTimerCategory
            // 
            this.labelTimerCategory.AutoSize = true;
            this.labelTimerCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimerCategory.Location = new System.Drawing.Point(53, 469);
            this.labelTimerCategory.Name = "labelTimerCategory";
            this.labelTimerCategory.Size = new System.Drawing.Size(119, 24);
            this.labelTimerCategory.TabIndex = 11;
            this.labelTimerCategory.Text = "Sesson timer";
            // 
            // btnHalt
            // 
            this.btnHalt.Location = new System.Drawing.Point(244, 384);
            this.btnHalt.Name = "btnHalt";
            this.btnHalt.Size = new System.Drawing.Size(76, 64);
            this.btnHalt.TabIndex = 12;
            this.btnHalt.Text = "Halt\r\n(Stop)";
            this.btnHalt.UseVisualStyleBackColor = true;
            this.btnHalt.Click += new System.EventHandler(this.btnHalt_Click);
            // 
            // textBoxTodayUsage
            // 
            this.textBoxTodayUsage.Location = new System.Drawing.Point(376, 73);
            this.textBoxTodayUsage.Multiline = true;
            this.textBoxTodayUsage.Name = "textBoxTodayUsage";
            this.textBoxTodayUsage.Size = new System.Drawing.Size(181, 457);
            this.textBoxTodayUsage.TabIndex = 13;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 554);
            this.Controls.Add(this.textBoxTodayUsage);
            this.Controls.Add(this.btnHalt);
            this.Controls.Add(this.labelTimerCategory);
            this.Controls.Add(this.labelTimerDisplay);
            this.Controls.Add(this.labelTodayDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBegin);
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
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTodayDate;
        private Timer timer1;
        private Label labelTimerDisplay;
        private Label labelTimerCategory;
        private Button btnHalt;
        private TextBox textBoxTodayUsage;
    }
}