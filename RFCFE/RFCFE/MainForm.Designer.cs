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
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StartButton = new System.Windows.Forms.Button();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excludedFilesAndDirectoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveScriptExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robocopyHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcludedTab = new System.Windows.Forms.TabPage();
            this.ExclDirsGB = new System.Windows.Forms.GroupBox();
            this.ExclDirsTxtBox = new System.Windows.Forms.TextBox();
            this.ExclDirsLabel = new System.Windows.Forms.Label();
            this.ExclDirsClrButton = new System.Windows.Forms.Button();
            this.DirsLabel = new System.Windows.Forms.Label();
            this.ExclDirsBrwsButton = new System.Windows.Forms.Button();
            this.ExclFilesGB = new System.Windows.Forms.GroupBox();
            this.ExclFilesTxtBox = new System.Windows.Forms.TextBox();
            this.ExclFilesClrButton = new System.Windows.Forms.Button();
            this.ExclFilesLabel = new System.Windows.Forms.Label();
            this.ExclFilesBrwsButton = new System.Windows.Forms.Button();
            this.FilesLabel = new System.Windows.Forms.Label();
            this.GeneralTab = new System.Windows.Forms.TabPage();
            this.LogsGB = new System.Windows.Forms.GroupBox();
            this.LogAppendRB = new System.Windows.Forms.RadioButton();
            this.LogOverwriteRB = new System.Windows.Forms.RadioButton();
            this.LogTeeCB = new System.Windows.Forms.CheckBox();
            this.LogEnCB = new System.Windows.Forms.CheckBox();
            this.LogLabel = new System.Windows.Forms.Label();
            this.LogSaveLocBtn = new System.Windows.Forms.Button();
            this.LogTxtBox = new System.Windows.Forms.TextBox();
            this.SwitchesGB = new System.Windows.Forms.GroupBox();
            this.SwitchesLabel = new System.Windows.Forms.Label();
            this.SwitchesTxtBox = new System.Windows.Forms.TextBox();
            this.TargetGB = new System.Windows.Forms.GroupBox();
            this.DestLabel = new System.Windows.Forms.Label();
            this.DestBrwsButton = new System.Windows.Forms.Button();
            this.DestTxtBox = new System.Windows.Forms.TextBox();
            this.SourceGB = new System.Windows.Forms.GroupBox();
            this.SrcLabel = new System.Windows.Forms.Label();
            this.SrcBrwsButton = new System.Windows.Forms.Button();
            this.SrcTxtBox = new System.Windows.Forms.TextBox();
            this.MainFormTabs = new System.Windows.Forms.TabControl();
            this.SaveClsBtn = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.ExcludedTab.SuspendLayout();
            this.ExclDirsGB.SuspendLayout();
            this.ExclFilesGB.SuspendLayout();
            this.GeneralTab.SuspendLayout();
            this.LogsGB.SuspendLayout();
            this.SwitchesGB.SuspendLayout();
            this.TargetGB.SuspendLayout();
            this.SourceGB.SuspendLayout();
            this.MainFormTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(508, 391);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(114, 36);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Start Backup";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(634, 24);
            this.MainMenu.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.saveScriptExitToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.excludedFilesAndDirectoriesToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "&Options";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // excludedFilesAndDirectoriesToolStripMenuItem
            // 
            this.excludedFilesAndDirectoriesToolStripMenuItem.Name = "excludedFilesAndDirectoriesToolStripMenuItem";
            this.excludedFilesAndDirectoriesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.excludedFilesAndDirectoriesToolStripMenuItem.Text = "Excluded files and directories";
            this.excludedFilesAndDirectoriesToolStripMenuItem.Click += new System.EventHandler(this.excludedFilesAndDirectoriesToolStripMenuItem_Click);
            // 
            // saveScriptExitToolStripMenuItem
            // 
            this.saveScriptExitToolStripMenuItem.Name = "saveScriptExitToolStripMenuItem";
            this.saveScriptExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveScriptExitToolStripMenuItem.Text = "&Save Script";
            this.saveScriptExitToolStripMenuItem.Click += new System.EventHandler(this.SaveScriptClose);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.robocopyHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // robocopyHelpToolStripMenuItem
            // 
            this.robocopyHelpToolStripMenuItem.Name = "robocopyHelpToolStripMenuItem";
            this.robocopyHelpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.robocopyHelpToolStripMenuItem.Text = "&Robocopy Help";
            this.robocopyHelpToolStripMenuItem.Click += new System.EventHandler(this.robocopyHelpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ExcludedTab
            // 
            this.ExcludedTab.Controls.Add(this.ExclDirsGB);
            this.ExcludedTab.Controls.Add(this.ExclFilesGB);
            this.ExcludedTab.Location = new System.Drawing.Point(4, 22);
            this.ExcludedTab.Name = "ExcludedTab";
            this.ExcludedTab.Padding = new System.Windows.Forms.Padding(3);
            this.ExcludedTab.Size = new System.Drawing.Size(628, 332);
            this.ExcludedTab.TabIndex = 1;
            this.ExcludedTab.Text = "Excluded files and directories";
            this.ExcludedTab.UseVisualStyleBackColor = true;
            // 
            // ExclDirsGB
            // 
            this.ExclDirsGB.Controls.Add(this.ExclDirsTxtBox);
            this.ExclDirsGB.Controls.Add(this.ExclDirsLabel);
            this.ExclDirsGB.Controls.Add(this.ExclDirsClrButton);
            this.ExclDirsGB.Controls.Add(this.DirsLabel);
            this.ExclDirsGB.Controls.Add(this.ExclDirsBrwsButton);
            this.ExclDirsGB.Location = new System.Drawing.Point(6, 6);
            this.ExclDirsGB.Name = "ExclDirsGB";
            this.ExclDirsGB.Size = new System.Drawing.Size(612, 157);
            this.ExclDirsGB.TabIndex = 11;
            this.ExclDirsGB.TabStop = false;
            this.ExclDirsGB.Text = "Directories";
            // 
            // ExclDirsTxtBox
            // 
            this.ExclDirsTxtBox.Location = new System.Drawing.Point(6, 45);
            this.ExclDirsTxtBox.MaxLength = 2147483647;
            this.ExclDirsTxtBox.Multiline = true;
            this.ExclDirsTxtBox.Name = "ExclDirsTxtBox";
            this.ExclDirsTxtBox.Size = new System.Drawing.Size(521, 106);
            this.ExclDirsTxtBox.TabIndex = 10;
            this.ExclDirsTxtBox.TextChanged += new System.EventHandler(this.ExclDirsTxtBox_TextChanged);
            // 
            // ExclDirsLabel
            // 
            this.ExclDirsLabel.AutoSize = true;
            this.ExclDirsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExclDirsLabel.Location = new System.Drawing.Point(6, 16);
            this.ExclDirsLabel.Name = "ExclDirsLabel";
            this.ExclDirsLabel.Size = new System.Drawing.Size(122, 13);
            this.ExclDirsLabel.TabIndex = 1;
            this.ExclDirsLabel.Text = "Excluded directories";
            // 
            // ExclDirsClrButton
            // 
            this.ExclDirsClrButton.Location = new System.Drawing.Point(533, 74);
            this.ExclDirsClrButton.Name = "ExclDirsClrButton";
            this.ExclDirsClrButton.Size = new System.Drawing.Size(75, 23);
            this.ExclDirsClrButton.TabIndex = 9;
            this.ExclDirsClrButton.Text = "Clear";
            this.ExclDirsClrButton.UseVisualStyleBackColor = true;
            this.ExclDirsClrButton.Click += new System.EventHandler(this.ExclDirsClrButton_Click);
            // 
            // DirsLabel
            // 
            this.DirsLabel.AutoSize = true;
            this.DirsLabel.Location = new System.Drawing.Point(6, 29);
            this.DirsLabel.Name = "DirsLabel";
            this.DirsLabel.Size = new System.Drawing.Size(383, 13);
            this.DirsLabel.TabIndex = 2;
            this.DirsLabel.Text = "Put all directories in one line, delimited by spaces and inside the quotation mar" +
                "ks";
            // 
            // ExclDirsBrwsButton
            // 
            this.ExclDirsBrwsButton.Location = new System.Drawing.Point(533, 45);
            this.ExclDirsBrwsButton.Name = "ExclDirsBrwsButton";
            this.ExclDirsBrwsButton.Size = new System.Drawing.Size(75, 23);
            this.ExclDirsBrwsButton.TabIndex = 6;
            this.ExclDirsBrwsButton.Text = "Browse";
            this.ExclDirsBrwsButton.UseVisualStyleBackColor = true;
            this.ExclDirsBrwsButton.Click += new System.EventHandler(this.ExclDirsBrwsButton_Click);
            // 
            // ExclFilesGB
            // 
            this.ExclFilesGB.Controls.Add(this.ExclFilesTxtBox);
            this.ExclFilesGB.Controls.Add(this.ExclFilesClrButton);
            this.ExclFilesGB.Controls.Add(this.ExclFilesLabel);
            this.ExclFilesGB.Controls.Add(this.ExclFilesBrwsButton);
            this.ExclFilesGB.Controls.Add(this.FilesLabel);
            this.ExclFilesGB.Location = new System.Drawing.Point(6, 169);
            this.ExclFilesGB.Name = "ExclFilesGB";
            this.ExclFilesGB.Size = new System.Drawing.Size(612, 157);
            this.ExclFilesGB.TabIndex = 12;
            this.ExclFilesGB.TabStop = false;
            this.ExclFilesGB.Text = "Files";
            // 
            // ExclFilesTxtBox
            // 
            this.ExclFilesTxtBox.Location = new System.Drawing.Point(6, 45);
            this.ExclFilesTxtBox.MaxLength = 2147483647;
            this.ExclFilesTxtBox.Multiline = true;
            this.ExclFilesTxtBox.Name = "ExclFilesTxtBox";
            this.ExclFilesTxtBox.Size = new System.Drawing.Size(521, 106);
            this.ExclFilesTxtBox.TabIndex = 11;
            this.ExclFilesTxtBox.TextChanged += new System.EventHandler(this.ExclFilesTxtBox_TextChanged);
            // 
            // ExclFilesClrButton
            // 
            this.ExclFilesClrButton.Location = new System.Drawing.Point(533, 74);
            this.ExclFilesClrButton.Name = "ExclFilesClrButton";
            this.ExclFilesClrButton.Size = new System.Drawing.Size(75, 23);
            this.ExclFilesClrButton.TabIndex = 10;
            this.ExclFilesClrButton.Text = "Clear";
            this.ExclFilesClrButton.UseVisualStyleBackColor = true;
            this.ExclFilesClrButton.Click += new System.EventHandler(this.ExclFilesClrButton_Click);
            // 
            // ExclFilesLabel
            // 
            this.ExclFilesLabel.AutoSize = true;
            this.ExclFilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExclFilesLabel.Location = new System.Drawing.Point(6, 16);
            this.ExclFilesLabel.Name = "ExclFilesLabel";
            this.ExclFilesLabel.Size = new System.Drawing.Size(86, 13);
            this.ExclFilesLabel.TabIndex = 4;
            this.ExclFilesLabel.Text = "Excluded files";
            // 
            // ExclFilesBrwsButton
            // 
            this.ExclFilesBrwsButton.Location = new System.Drawing.Point(533, 45);
            this.ExclFilesBrwsButton.Name = "ExclFilesBrwsButton";
            this.ExclFilesBrwsButton.Size = new System.Drawing.Size(75, 23);
            this.ExclFilesBrwsButton.TabIndex = 8;
            this.ExclFilesBrwsButton.Text = "Browse";
            this.ExclFilesBrwsButton.UseVisualStyleBackColor = true;
            this.ExclFilesBrwsButton.Click += new System.EventHandler(this.ExclFilesBrwsButton_Click);
            // 
            // FilesLabel
            // 
            this.FilesLabel.AutoSize = true;
            this.FilesLabel.Location = new System.Drawing.Point(6, 29);
            this.FilesLabel.Name = "FilesLabel";
            this.FilesLabel.Size = new System.Drawing.Size(353, 13);
            this.FilesLabel.TabIndex = 5;
            this.FilesLabel.Text = "Put all files in one line, delimited by spaces and inside the quotation marks";
            // 
            // GeneralTab
            // 
            this.GeneralTab.Controls.Add(this.LogsGB);
            this.GeneralTab.Controls.Add(this.SwitchesGB);
            this.GeneralTab.Controls.Add(this.TargetGB);
            this.GeneralTab.Controls.Add(this.SourceGB);
            this.GeneralTab.Location = new System.Drawing.Point(4, 22);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralTab.Size = new System.Drawing.Size(628, 332);
            this.GeneralTab.TabIndex = 0;
            this.GeneralTab.Text = "General";
            this.GeneralTab.UseVisualStyleBackColor = true;
            // 
            // LogsGB
            // 
            this.LogsGB.Controls.Add(this.LogAppendRB);
            this.LogsGB.Controls.Add(this.LogOverwriteRB);
            this.LogsGB.Controls.Add(this.LogTeeCB);
            this.LogsGB.Controls.Add(this.LogEnCB);
            this.LogsGB.Controls.Add(this.LogLabel);
            this.LogsGB.Controls.Add(this.LogSaveLocBtn);
            this.LogsGB.Controls.Add(this.LogTxtBox);
            this.LogsGB.Location = new System.Drawing.Point(6, 207);
            this.LogsGB.Name = "LogsGB";
            this.LogsGB.Size = new System.Drawing.Size(612, 119);
            this.LogsGB.TabIndex = 11;
            this.LogsGB.TabStop = false;
            this.LogsGB.Text = "Logging";
            // 
            // LogAppendRB
            // 
            this.LogAppendRB.AutoSize = true;
            this.LogAppendRB.Enabled = false;
            this.LogAppendRB.Location = new System.Drawing.Point(384, 95);
            this.LogAppendRB.Name = "LogAppendRB";
            this.LogAppendRB.Size = new System.Drawing.Size(145, 17);
            this.LogAppendRB.TabIndex = 11;
            this.LogAppendRB.Text = "Append to existing log file";
            this.LogAppendRB.UseVisualStyleBackColor = true;
            this.LogAppendRB.CheckedChanged += new System.EventHandler(this.LogAppendRB_CheckedChanged);
            // 
            // LogOverwriteRB
            // 
            this.LogOverwriteRB.AutoSize = true;
            this.LogOverwriteRB.Checked = true;
            this.LogOverwriteRB.Enabled = false;
            this.LogOverwriteRB.Location = new System.Drawing.Point(237, 95);
            this.LogOverwriteRB.Name = "LogOverwriteRB";
            this.LogOverwriteRB.Size = new System.Drawing.Size(141, 17);
            this.LogOverwriteRB.TabIndex = 10;
            this.LogOverwriteRB.TabStop = true;
            this.LogOverwriteRB.Text = "Overwrite existing log file";
            this.LogOverwriteRB.UseVisualStyleBackColor = true;
            this.LogOverwriteRB.CheckedChanged += new System.EventHandler(this.LogOverwriteRB_CheckedChanged);
            // 
            // LogTeeCB
            // 
            this.LogTeeCB.AutoSize = true;
            this.LogTeeCB.Checked = true;
            this.LogTeeCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LogTeeCB.Enabled = false;
            this.LogTeeCB.Location = new System.Drawing.Point(9, 96);
            this.LogTeeCB.Name = "LogTeeCB";
            this.LogTeeCB.Size = new System.Drawing.Size(222, 17);
            this.LogTeeCB.TabIndex = 9;
            this.LogTeeCB.Text = "Output to log file as well as to the console";
            this.LogTeeCB.UseVisualStyleBackColor = true;
            this.LogTeeCB.CheckedChanged += new System.EventHandler(this.LogTeeCB_CheckedChanged);
            // 
            // LogEnCB
            // 
            this.LogEnCB.AutoSize = true;
            this.LogEnCB.Location = new System.Drawing.Point(9, 19);
            this.LogEnCB.Name = "LogEnCB";
            this.LogEnCB.Size = new System.Drawing.Size(100, 17);
            this.LogEnCB.TabIndex = 8;
            this.LogEnCB.Text = "Enable Logging";
            this.LogEnCB.UseVisualStyleBackColor = true;
            this.LogEnCB.CheckedChanged += new System.EventHandler(this.LogEnCB_CheckedChanged);
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogLabel.Location = new System.Drawing.Point(6, 39);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(98, 13);
            this.LogLabel.TabIndex = 7;
            this.LogLabel.Text = "Log file location";
            // 
            // LogSaveLocBtn
            // 
            this.LogSaveLocBtn.Enabled = false;
            this.LogSaveLocBtn.Location = new System.Drawing.Point(531, 52);
            this.LogSaveLocBtn.Name = "LogSaveLocBtn";
            this.LogSaveLocBtn.Size = new System.Drawing.Size(75, 23);
            this.LogSaveLocBtn.TabIndex = 6;
            this.LogSaveLocBtn.Text = "Browse";
            this.LogSaveLocBtn.UseVisualStyleBackColor = true;
            this.LogSaveLocBtn.Click += new System.EventHandler(this.LogSaveLocBtn_Click);
            // 
            // LogTxtBox
            // 
            this.LogTxtBox.Enabled = false;
            this.LogTxtBox.Location = new System.Drawing.Point(9, 55);
            this.LogTxtBox.Name = "LogTxtBox";
            this.LogTxtBox.Size = new System.Drawing.Size(516, 20);
            this.LogTxtBox.TabIndex = 5;
            this.LogTxtBox.TextChanged += new System.EventHandler(this.LogTxtBox_TextChanged);
            // 
            // SwitchesGB
            // 
            this.SwitchesGB.Controls.Add(this.SwitchesLabel);
            this.SwitchesGB.Controls.Add(this.SwitchesTxtBox);
            this.SwitchesGB.Location = new System.Drawing.Point(6, 140);
            this.SwitchesGB.Name = "SwitchesGB";
            this.SwitchesGB.Size = new System.Drawing.Size(612, 61);
            this.SwitchesGB.TabIndex = 10;
            this.SwitchesGB.TabStop = false;
            this.SwitchesGB.Text = "Command Arguments";
            // 
            // SwitchesLabel
            // 
            this.SwitchesLabel.AutoSize = true;
            this.SwitchesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SwitchesLabel.Location = new System.Drawing.Point(6, 16);
            this.SwitchesLabel.Name = "SwitchesLabel";
            this.SwitchesLabel.Size = new System.Drawing.Size(249, 13);
            this.SwitchesLabel.TabIndex = 7;
            this.SwitchesLabel.Text = "RoboCopy Arguments (Command Switches)";
            // 
            // SwitchesTxtBox
            // 
            this.SwitchesTxtBox.Location = new System.Drawing.Point(9, 32);
            this.SwitchesTxtBox.Name = "SwitchesTxtBox";
            this.SwitchesTxtBox.Size = new System.Drawing.Size(600, 20);
            this.SwitchesTxtBox.TabIndex = 6;
            this.SwitchesTxtBox.TextChanged += new System.EventHandler(this.SwitchesTxtBox_TextChanged);
            // 
            // TargetGB
            // 
            this.TargetGB.Controls.Add(this.DestLabel);
            this.TargetGB.Controls.Add(this.DestBrwsButton);
            this.TargetGB.Controls.Add(this.DestTxtBox);
            this.TargetGB.Location = new System.Drawing.Point(6, 73);
            this.TargetGB.Name = "TargetGB";
            this.TargetGB.Size = new System.Drawing.Size(612, 61);
            this.TargetGB.TabIndex = 9;
            this.TargetGB.TabStop = false;
            this.TargetGB.Text = "Destination";
            // 
            // DestLabel
            // 
            this.DestLabel.AutoSize = true;
            this.DestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DestLabel.Location = new System.Drawing.Point(6, 16);
            this.DestLabel.Name = "DestLabel";
            this.DestLabel.Size = new System.Drawing.Size(160, 13);
            this.DestLabel.TabIndex = 4;
            this.DestLabel.Text = "Path to the target directory";
            // 
            // DestBrwsButton
            // 
            this.DestBrwsButton.Location = new System.Drawing.Point(531, 29);
            this.DestBrwsButton.Name = "DestBrwsButton";
            this.DestBrwsButton.Size = new System.Drawing.Size(75, 23);
            this.DestBrwsButton.TabIndex = 3;
            this.DestBrwsButton.Text = "Browse";
            this.DestBrwsButton.UseVisualStyleBackColor = true;
            this.DestBrwsButton.Click += new System.EventHandler(this.DestBrwsButton_Click);
            // 
            // DestTxtBox
            // 
            this.DestTxtBox.Location = new System.Drawing.Point(10, 32);
            this.DestTxtBox.Name = "DestTxtBox";
            this.DestTxtBox.Size = new System.Drawing.Size(516, 20);
            this.DestTxtBox.TabIndex = 2;
            this.DestTxtBox.TextChanged += new System.EventHandler(this.DestTxtBox_TextChanged);
            // 
            // SourceGB
            // 
            this.SourceGB.Controls.Add(this.SrcLabel);
            this.SourceGB.Controls.Add(this.SrcBrwsButton);
            this.SourceGB.Controls.Add(this.SrcTxtBox);
            this.SourceGB.Location = new System.Drawing.Point(6, 6);
            this.SourceGB.Name = "SourceGB";
            this.SourceGB.Size = new System.Drawing.Size(612, 61);
            this.SourceGB.TabIndex = 8;
            this.SourceGB.TabStop = false;
            this.SourceGB.Text = "Source";
            // 
            // SrcLabel
            // 
            this.SrcLabel.AutoSize = true;
            this.SrcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SrcLabel.Location = new System.Drawing.Point(6, 16);
            this.SrcLabel.Name = "SrcLabel";
            this.SrcLabel.Size = new System.Drawing.Size(165, 13);
            this.SrcLabel.TabIndex = 5;
            this.SrcLabel.Text = "Path to the source directory";
            // 
            // SrcBrwsButton
            // 
            this.SrcBrwsButton.Location = new System.Drawing.Point(531, 29);
            this.SrcBrwsButton.Name = "SrcBrwsButton";
            this.SrcBrwsButton.Size = new System.Drawing.Size(75, 23);
            this.SrcBrwsButton.TabIndex = 1;
            this.SrcBrwsButton.Text = "Browse";
            this.SrcBrwsButton.UseVisualStyleBackColor = true;
            this.SrcBrwsButton.Click += new System.EventHandler(this.SrcBrwsButton_Click);
            // 
            // SrcTxtBox
            // 
            this.SrcTxtBox.Location = new System.Drawing.Point(9, 32);
            this.SrcTxtBox.Name = "SrcTxtBox";
            this.SrcTxtBox.Size = new System.Drawing.Size(516, 20);
            this.SrcTxtBox.TabIndex = 0;
            this.SrcTxtBox.TextChanged += new System.EventHandler(this.SrcTxtBox_TextChanged);
            // 
            // MainFormTabs
            // 
            this.MainFormTabs.Controls.Add(this.GeneralTab);
            this.MainFormTabs.Controls.Add(this.ExcludedTab);
            this.MainFormTabs.Location = new System.Drawing.Point(0, 27);
            this.MainFormTabs.Name = "MainFormTabs";
            this.MainFormTabs.SelectedIndex = 0;
            this.MainFormTabs.Size = new System.Drawing.Size(636, 358);
            this.MainFormTabs.TabIndex = 0;
            // 
            // SaveClsBtn
            // 
            this.SaveClsBtn.Location = new System.Drawing.Point(376, 391);
            this.SaveClsBtn.Name = "SaveClsBtn";
            this.SaveClsBtn.Size = new System.Drawing.Size(126, 36);
            this.SaveClsBtn.TabIndex = 9;
            this.SaveClsBtn.Text = "Save Script";
            this.SaveClsBtn.UseVisualStyleBackColor = true;
            this.SaveClsBtn.Click += new System.EventHandler(this.SaveScriptClose);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(634, 433);
            this.Controls.Add(this.SaveClsBtn);
            this.Controls.Add(this.MainFormTabs);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robust File Copy Front End";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ExcludedTab.ResumeLayout(false);
            this.ExclDirsGB.ResumeLayout(false);
            this.ExclDirsGB.PerformLayout();
            this.ExclFilesGB.ResumeLayout(false);
            this.ExclFilesGB.PerformLayout();
            this.GeneralTab.ResumeLayout(false);
            this.LogsGB.ResumeLayout(false);
            this.LogsGB.PerformLayout();
            this.SwitchesGB.ResumeLayout(false);
            this.SwitchesGB.PerformLayout();
            this.TargetGB.ResumeLayout(false);
            this.TargetGB.PerformLayout();
            this.SourceGB.ResumeLayout(false);
            this.SourceGB.PerformLayout();
            this.MainFormTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage ExcludedTab;
        private System.Windows.Forms.Button ExclFilesClrButton;
        private System.Windows.Forms.Button ExclDirsClrButton;
        private System.Windows.Forms.Button ExclFilesBrwsButton;
        private System.Windows.Forms.Button ExclDirsBrwsButton;
        private System.Windows.Forms.Label FilesLabel;
        private System.Windows.Forms.Label ExclFilesLabel;
        private System.Windows.Forms.Label DirsLabel;
        private System.Windows.Forms.Label ExclDirsLabel;
        private System.Windows.Forms.TabPage GeneralTab;
        private System.Windows.Forms.TextBox SwitchesTxtBox;
        private System.Windows.Forms.TextBox DestTxtBox;
        private System.Windows.Forms.TextBox SrcTxtBox;
        private System.Windows.Forms.Label SwitchesLabel;
        private System.Windows.Forms.Label SrcLabel;
        private System.Windows.Forms.Label DestLabel;
        private System.Windows.Forms.Button DestBrwsButton;
        private System.Windows.Forms.Button SrcBrwsButton;
        private System.Windows.Forms.TabControl MainFormTabs;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excludedFilesAndDirectoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robocopyHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox SourceGB;
        private System.Windows.Forms.GroupBox SwitchesGB;
        private System.Windows.Forms.GroupBox TargetGB;
        private System.Windows.Forms.GroupBox LogsGB;
        private System.Windows.Forms.CheckBox LogEnCB;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.Button LogSaveLocBtn;
        private System.Windows.Forms.TextBox LogTxtBox;
        private System.Windows.Forms.CheckBox LogTeeCB;
        private System.Windows.Forms.RadioButton LogAppendRB;
        private System.Windows.Forms.RadioButton LogOverwriteRB;
        private System.Windows.Forms.GroupBox ExclDirsGB;
        private System.Windows.Forms.GroupBox ExclFilesGB;
        private System.Windows.Forms.TextBox ExclDirsTxtBox;
        private System.Windows.Forms.TextBox ExclFilesTxtBox;
        private System.Windows.Forms.Button SaveClsBtn;
        private System.Windows.Forms.ToolStripMenuItem saveScriptExitToolStripMenuItem;
    }
}

