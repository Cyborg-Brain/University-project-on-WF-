namespace Testing.Views.Forms.PopUpWindows
{
    partial class EdAddGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxCurator = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Name";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Tomato;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Britannic Bold", 8.25F);
            this.btnExit.Location = new System.Drawing.Point(249, 88);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 20);
            this.btnExit.TabIndex = 55;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label7.Location = new System.Drawing.Point(3, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "Curator";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(60, 74);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(145, 31);
            this.btnSubmit.TabIndex = 56;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxName.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.txtBoxName.Location = new System.Drawing.Point(60, 12);
            this.txtBoxName.MaxLength = 32;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(191, 25);
            this.txtBoxName.TabIndex = 51;
            this.txtBoxName.Tag = "Name";
            // 
            // txtBoxCurator
            // 
            this.txtBoxCurator.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBoxCurator.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBoxCurator.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxCurator.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.txtBoxCurator.Location = new System.Drawing.Point(60, 43);
            this.txtBoxCurator.MaxLength = 32;
            this.txtBoxCurator.Name = "txtBoxCurator";
            this.txtBoxCurator.Size = new System.Drawing.Size(191, 25);
            this.txtBoxCurator.TabIndex = 51;
            this.txtBoxCurator.Tag = "NameLecturer";
            // 
            // EdAddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 108);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxCurator);
            this.Controls.Add(this.txtBoxName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EdAddGroup";
            this.Text = "EdAddGroup";
            this.Load += new System.EventHandler(this.EdAddGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxCurator;
    }
}