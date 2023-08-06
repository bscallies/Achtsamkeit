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
            this.label1 = new System.Windows.Forms.Label();
            this.treeViewCategories = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewSubcategory = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.labelTodayDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTimerDisplay = new System.Windows.Forms.Label();
            this.labelTimerCategory = new System.Windows.Forms.Label();
            this.btnHalt = new System.Windows.Forms.Button();
            this.textBoxTodayUsage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStatistics = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Achtsamkeit";
            // 
            // treeViewCategories
            // 
            this.treeViewCategories.BackColor = System.Drawing.SystemColors.InfoText;
            this.treeViewCategories.ForeColor = System.Drawing.SystemColors.Info;
            this.treeViewCategories.Location = new System.Drawing.Point(20, 118);
            this.treeViewCategories.Name = "treeViewCategories";
            this.treeViewCategories.Size = new System.Drawing.Size(232, 210);
            this.treeViewCategories.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(17, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add a subcategory: ";
            // 
            // textBoxNewSubcategory
            // 
            this.textBoxNewSubcategory.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxNewSubcategory.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxNewSubcategory.Location = new System.Drawing.Point(18, 434);
            this.textBoxNewSubcategory.Name = "textBoxNewSubcategory";
            this.textBoxNewSubcategory.Size = new System.Drawing.Size(189, 20);
            this.textBoxNewSubcategory.TabIndex = 3;
            this.textBoxNewSubcategory.TextChanged += new System.EventHandler(this.textBoxNewSubcategory_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 431);
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
            this.label3.Location = new System.Drawing.Point(46, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Location = new System.Drawing.Point(20, 334);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(171, 64);
            this.btnBegin.TabIndex = 7;
            this.btnBegin.Text = "Begin Session!";
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // labelTodayDate
            // 
            this.labelTodayDate.AutoSize = true;
            this.labelTodayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTodayDate.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelTodayDate.Location = new System.Drawing.Point(249, 32);
            this.labelTodayDate.Name = "labelTodayDate";
            this.labelTodayDate.Size = new System.Drawing.Size(117, 24);
            this.labelTodayDate.TabIndex = 9;
            this.labelTodayDate.Text = "Today\'s date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // labelTimerDisplay
            // 
            this.labelTimerDisplay.AutoSize = true;
            this.labelTimerDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimerDisplay.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelTimerDisplay.Location = new System.Drawing.Point(43, 518);
            this.labelTimerDisplay.Name = "labelTimerDisplay";
            this.labelTimerDisplay.Size = new System.Drawing.Size(183, 33);
            this.labelTimerDisplay.TabIndex = 10;
            this.labelTimerDisplay.Text = "00h 00m 00s";
            // 
            // labelTimerCategory
            // 
            this.labelTimerCategory.AutoSize = true;
            this.labelTimerCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimerCategory.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTimerCategory.Location = new System.Drawing.Point(14, 480);
            this.labelTimerCategory.Name = "labelTimerCategory";
            this.labelTimerCategory.Size = new System.Drawing.Size(119, 24);
            this.labelTimerCategory.TabIndex = 11;
            this.labelTimerCategory.Text = "Sesson timer";
            // 
            // btnHalt
            // 
            this.btnHalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHalt.Location = new System.Drawing.Point(197, 334);
            this.btnHalt.Name = "btnHalt";
            this.btnHalt.Size = new System.Drawing.Size(55, 64);
            this.btnHalt.TabIndex = 12;
            this.btnHalt.Text = "Halt\r";
            this.btnHalt.UseVisualStyleBackColor = true;
            this.btnHalt.Click += new System.EventHandler(this.btnHalt_Click);
            // 
            // textBoxTodayUsage
            // 
            this.textBoxTodayUsage.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBoxTodayUsage.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxTodayUsage.Location = new System.Drawing.Point(280, 94);
            this.textBoxTodayUsage.Multiline = true;
            this.textBoxTodayUsage.Name = "textBoxTodayUsage";
            this.textBoxTodayUsage.Size = new System.Drawing.Size(213, 170);
            this.textBoxTodayUsage.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(32, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Session Focus:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(277, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Today\'s Usage:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bradley Hand ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(44, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mindfulness";
            // 
            // textBoxStatistics
            // 
            this.textBoxStatistics.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxStatistics.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxStatistics.Location = new System.Drawing.Point(280, 317);
            this.textBoxStatistics.Multiline = true;
            this.textBoxStatistics.Name = "textBoxStatistics";
            this.textBoxStatistics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxStatistics.Size = new System.Drawing.Size(212, 204);
            this.textBoxStatistics.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(276, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Statistics";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(527, 577);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxStatistics);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTodayUsage);
            this.Controls.Add(this.btnHalt);
            this.Controls.Add(this.labelTimerCategory);
            this.Controls.Add(this.labelTimerDisplay);
            this.Controls.Add(this.labelTodayDate);
            this.Controls.Add(this.btnBegin);
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
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label labelTodayDate;
        private Timer timer1;
        private Label labelTimerDisplay;
        private Label labelTimerCategory;
        private Button btnHalt;
        private TextBox textBoxTodayUsage;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBoxStatistics;
        private Label label4;
    }
}