/*
 * Robust File Copy Front End
 * Copyright (C) 2010-2011 Almir Dzinovic <almir@dzinovic.net>
 * 
 * This program is free software; you can redistribute it and/or modify it under the
 * terms of the GNU General Public License as published by the Free Software
 * Foundation; either version 3 of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful, but WITHOUT ANY
 * WARRANTY; without even the implied warranty of MERCHANTABILITY or
 * FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace RFCFE
{
    partial class CreditsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditsDialog));
            this.CrdDlgClsBtn = new System.Windows.Forms.Button();
            this.textBoxCredits = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CrdDlgClsBtn
            // 
            this.CrdDlgClsBtn.Location = new System.Drawing.Point(112, 184);
            this.CrdDlgClsBtn.Name = "CrdDlgClsBtn";
            this.CrdDlgClsBtn.Size = new System.Drawing.Size(160, 32);
            this.CrdDlgClsBtn.TabIndex = 1;
            this.CrdDlgClsBtn.Text = "&Close";
            this.CrdDlgClsBtn.UseVisualStyleBackColor = true;
            this.CrdDlgClsBtn.Click += new System.EventHandler(this.CrdDlgClsBtn_Click);
            // 
            // textBoxCredits
            // 
            this.textBoxCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCredits.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxCredits.Location = new System.Drawing.Point(0, 0);
            this.textBoxCredits.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBoxCredits.Multiline = true;
            this.textBoxCredits.Name = "textBoxCredits";
            this.textBoxCredits.ReadOnly = true;
            this.textBoxCredits.Size = new System.Drawing.Size(378, 178);
            this.textBoxCredits.TabIndex = 24;
            this.textBoxCredits.TabStop = false;
            this.textBoxCredits.Text = resources.GetString("textBoxCredits.Text");
            // 
            // CreditsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 221);
            this.Controls.Add(this.textBoxCredits);
            this.Controls.Add(this.CrdDlgClsBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreditsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CrdDlgClsBtn;
        private System.Windows.Forms.TextBox textBoxCredits;
    }
}