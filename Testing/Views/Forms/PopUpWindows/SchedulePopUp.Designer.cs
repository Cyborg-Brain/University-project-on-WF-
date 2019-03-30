﻿namespace Testing.Views.Forms.PopUpWindows
{
    partial class SchedulePopUp
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radioBtnAscend = new System.Windows.Forms.RadioButton();
            this.radioBtnDescending = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(13, 37);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(933, 444);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Day";
            this.columnHeader1.Width = 137;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NumSubject";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Group";
            this.columnHeader3.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Subject";
            this.columnHeader4.Width = 279;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lecturer";
            this.columnHeader5.Width = 317;
            // 
            // radioBtnAscend
            // 
            this.radioBtnAscend.AutoSize = true;
            this.radioBtnAscend.Location = new System.Drawing.Point(13, 14);
            this.radioBtnAscend.Name = "radioBtnAscend";
            this.radioBtnAscend.Size = new System.Drawing.Size(75, 17);
            this.radioBtnAscend.TabIndex = 1;
            this.radioBtnAscend.TabStop = true;
            this.radioBtnAscend.Text = "Ascending";
            this.radioBtnAscend.UseVisualStyleBackColor = true;
            this.radioBtnAscend.CheckedChanged += new System.EventHandler(this.radioBtnAscend_CheckedChanged);
            // 
            // radioBtnDescending
            // 
            this.radioBtnDescending.AutoSize = true;
            this.radioBtnDescending.Location = new System.Drawing.Point(94, 14);
            this.radioBtnDescending.Name = "radioBtnDescending";
            this.radioBtnDescending.Size = new System.Drawing.Size(82, 17);
            this.radioBtnDescending.TabIndex = 1;
            this.radioBtnDescending.TabStop = true;
            this.radioBtnDescending.Text = "Descending";
            this.radioBtnDescending.UseVisualStyleBackColor = true;
            this.radioBtnDescending.CheckedChanged += new System.EventHandler(this.radioBtnDescending_CheckedChanged);
            // 
            // SchedulePopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 493);
            this.Controls.Add(this.radioBtnDescending);
            this.Controls.Add(this.radioBtnAscend);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SchedulePopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.SchedulePopUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.RadioButton radioBtnAscend;
        private System.Windows.Forms.RadioButton radioBtnDescending;
    }
}