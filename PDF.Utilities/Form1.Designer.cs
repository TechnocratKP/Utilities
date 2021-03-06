﻿namespace PDFMergerProtector
{
    partial class Form1
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
            this.pdfInputFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.pdfInputFiles = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnMergeProtect = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pdfInputFilesDialog
            // 
            this.pdfInputFilesDialog.DefaultExt = "pdf";
            this.pdfInputFilesDialog.Multiselect = true;
            this.pdfInputFilesDialog.Title = "Select pdf files to merge.";
            // 
            // pdfInputFiles
            // 
            this.pdfInputFiles.Location = new System.Drawing.Point(28, 21);
            this.pdfInputFiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pdfInputFiles.Name = "pdfInputFiles";
            this.pdfInputFiles.Size = new System.Drawing.Size(163, 24);
            this.pdfInputFiles.TabIndex = 0;
            this.pdfInputFiles.Text = "Select Files to Merge";
            this.pdfInputFiles.UseVisualStyleBackColor = true;
            this.pdfInputFiles.Click += new System.EventHandler(this.pdfInputFiles_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(28, 73);
            this.btnMerge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(163, 24);
            this.btnMerge.TabIndex = 1;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnMergeProtect
            // 
            this.btnMergeProtect.Location = new System.Drawing.Point(27, 162);
            this.btnMergeProtect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMergeProtect.Name = "btnMergeProtect";
            this.btnMergeProtect.Size = new System.Drawing.Size(163, 24);
            this.btnMergeProtect.TabIndex = 2;
            this.btnMergeProtect.Text = "Merge && Protect";
            this.btnMergeProtect.UseVisualStyleBackColor = true;
            this.btnMergeProtect.Click += new System.EventHandler(this.btnMergeProtect_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(28, 123);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(161, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 208);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnMergeProtect);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.pdfInputFiles);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog pdfInputFilesDialog;
        private System.Windows.Forms.Button pdfInputFiles;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnMergeProtect;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

