﻿namespace GitUI
{
    partial class FormRunScriptSpecify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRunScriptSpecify));
            this.specifyLabel = new System.Windows.Forms.Label();
            this.branchesListView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // specifyLabel
            // 
            this.specifyLabel.AutoSize = true;
            this.specifyLabel.Location = new System.Drawing.Point(35, 13);
            this.specifyLabel.Name = "specifyLabel";
            this.specifyLabel.Size = new System.Drawing.Size(35, 13);
            this.specifyLabel.TabIndex = 0;
            this.specifyLabel.Text = "label1";
            // 
            // branchesListView
            // 
            this.branchesListView.FullRowSelect = true;
            this.branchesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.branchesListView.Location = new System.Drawing.Point(12, 40);
            this.branchesListView.Name = "branchesListView";
            this.branchesListView.Size = new System.Drawing.Size(290, 52);
            this.branchesListView.TabIndex = 1;
            this.branchesListView.UseCompatibleStateImageBehavior = false;
            this.branchesListView.View = System.Windows.Forms.View.List;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRunScriptSpecify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 124);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.branchesListView);
            this.Controls.Add(this.specifyLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRunScriptSpecify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Specify branch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label specifyLabel;
        private System.Windows.Forms.ListView branchesListView;
        private System.Windows.Forms.Button button1;
    }
}