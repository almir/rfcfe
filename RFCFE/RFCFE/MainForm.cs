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

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace RFCFE
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load user settings (if any) on startup
            SrcTxtBox.Text = Properties.Settings.Default.SourceDir;
            DestTxtBox.Text = Properties.Settings.Default.DestDir;
            SwitchesTxtBox.Text = Properties.Settings.Default.Switches;
            ExclDirsTxtBox.Text = Properties.Settings.Default.ExclDirs;
            ExclFilesTxtBox.Text = Properties.Settings.Default.ExclFiles;
            LogTxtBox.Text = Properties.Settings.Default.LogFileLocation;
            LogEnCB.Checked = Properties.Settings.Default.LogEnabled;
            LogTeeCB.Checked = Properties.Settings.Default.LogTee;
            LogOverwriteRB.Checked = Properties.Settings.Default.LogOverwrite;
            LogAppendRB.Checked = Properties.Settings.Default.LogAppend;
            startRobocopyAsAnIndependentProcessToolStripMenuItem.Checked = Properties.Settings.Default.IndProcessState;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Save user settings on exit
            Properties.Settings.Default.Save();
        }

        private string AddQuotations(string inString)
        {
            // Add the quotation marks to the directory path if there aren't any already
            string retval;

            if (inString.StartsWith("\""))
            {
                retval = inString;
            }
            else
            {
                retval = "\"" + inString;
            }

            if (!retval.EndsWith("\""))
            {
                retval = retval + "\"";
            }

            return retval;
        }

        private void SrcBrwsButton_Click(object sender, EventArgs e)
        {
            // Open the browse dialog and populate the text box containing the source directory
            DialogResult result = FolderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = FolderBrowserDialog.SelectedPath;
                SrcTxtBox.Text = path;
            }

        }

        private void DestBrwsButton_Click(object sender, EventArgs e)
        {
            // Open the browse dialog and populate the text box containing the target directory
            DialogResult result = FolderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = FolderBrowserDialog.SelectedPath;
                DestTxtBox.Text = path;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Disable the button when clicked
            StartButton.Enabled = false;

            // Set some strings for easier reference later
            string source = AddQuotations(SrcTxtBox.Text);
            string destination = AddQuotations(DestTxtBox.Text);
            string switches = SwitchesTxtBox.Text;
            string exclfiles = ExclFilesTxtBox.Text;
            string excldirs = ExclDirsTxtBox.Text;
            string logfile = AddQuotations(LogTxtBox.Text);

            // Start the robocopy process
            Process process = new Process();
            // Check all the possible variables and populate the process arguments accordingly
            if (LogEnCB.Checked == true && LogTeeCB.Checked == true && LogOverwriteRB.Checked == true
                    && ExclDirsTxtBox.TextLength > 0 && ExclFilesTxtBox.TextLength > 0)
            {
                process.StartInfo.Arguments = source + " " + destination + " /xf " + exclfiles + " /xd " +
                    excldirs + " /tee /log:" + logfile + " " + switches;
            }
            else if (LogEnCB.Checked == true && LogTeeCB.Checked == true && LogOverwriteRB.Checked == true
                && ExclDirsTxtBox.TextLength > 0 && ExclFilesTxtBox.TextLength == 0)
            {
                process.StartInfo.Arguments = source + " " + destination + " /xd " + excldirs +
                    " /tee /log:" + logfile + " " + switches;
            }
            else if (LogEnCB.Checked == true && LogTeeCB.Checked == true && LogOverwriteRB.Checked == true
                && ExclDirsTxtBox.TextLength == 0 && ExclFilesTxtBox.TextLength > 0)
            {
                process.StartInfo.Arguments = source + " " + destination + " /xf " + exclfiles +
                    " /tee /log:" + logfile + " " + switches;
            }
            else if (LogEnCB.Checked == true && LogTeeCB.Checked == true && LogOverwriteRB.Checked == true
                && ExclDirsTxtBox.TextLength == 0 && ExclFilesTxtBox.TextLength == 0)
            {
                process.StartInfo.Arguments = source + " " + destination + " /tee /log:" + logfile + " " + switches;
            }
            else if (LogEnCB.Checked == true && LogTeeCB.Checked == true && LogAppendRB.Checked == true
                && ExclDirsTxtBox.TextLength > 0 && ExclFilesTxtBox.TextLength > 0)
            {
                process.StartInfo.Arguments = source + " " + destination + " /xf " + exclfiles + " /xd " +
                    excldirs + " /tee /log+:" + logfile + " " + switches;
            }
            else if (LogEnCB.Checked == true && LogTeeCB.Checked == true && LogAppendRB.Checked == true
                && ExclDirsTxtBox.TextLength > 0 && ExclFilesTxtBox.TextLength == 0)
            {
                process.StartInfo.Arguments = source + " " + destination + " /xd " + excldirs +
                    " /tee /log+:" + logfile + " " + switches;
            }
            else if (LogEnCB.Checked == true && LogTeeCB.Checked == true && LogAppendRB.Checked == true
                && ExclDirsTxtBox.TextLength == 0 && ExclFilesTxtBox.TextLength > 0)
            {
                process.StartInfo.Arguments = source + " " + destination + " /xf " + exclfiles +
                    " /tee /log+:" + logfile + " " + switches;
            }
            else if (LogEnCB.Checked == true && LogTeeCB.Checked == true && LogAppendRB.Checked == true
                && ExclDirsTxtBox.TextLength == 0 && ExclFilesTxtBox.TextLength == 0)
            {
                process.StartInfo.Arguments = source + " " + destination + " /tee /log+:" + logfile + " " + switches;
            }
            else if (LogEnCB.Checked == true && LogTeeCB.Checked == false && LogOverwriteRB.Checked == true
                && ExclDirsTxtBox.TextLength > 0 && ExclFilesTxtBox.TextLength > 0)
            {
                process.StartInfo.Arguments = source + " " + destination + " /xf " + exclfiles + " /xd " +
                    excldirs + " /log:" + logfile + " " + switches;
            }
            else if (LogEnCB.Checked == true && LogTeeCB.Checked == false && LogOverwriteRB.Checked == true
                && ExclDirsTxtBox.TextLength > 0 && ExclFilesTxtBox.TextLength == 0)
            {
                process.StartInfo.Arguments = source + " " + destination + " /xd " + excldirs + " /log:" + logfile + " " + switches;
            }
            else if (LogEnCB.Checked == true && LogTeeCB.Checked == false && LogOverwriteRB.Checked == true
                && ExclDirsTxtBox.TextLength == 0 && ExclFilesTxtBox.TextLength > 0)
            {
                process.StartInfo.Arguments = source + " " + destination + " /xf " + exclfiles + " /log:" + logfile + " " + switches;
            }
            else if (LogEnCB.Checked == true && LogTeeCB.Checked == false && LogOverwriteRB.Checked == true
                && ExclDirsTxtBox.TextLength == 0 && ExclFilesTxtBox.TextLength == 0)
            {
                process.StartInfo.Arguments = source + " " + destination + " /log:" + logfile + " " + switches;
            }
            else if (LogEnCB.Checked == true && LogTeeCB.Checked == false && LogAppendRB.Checked == true
                && ExclDirsTxtBox.TextLength > 0 && ExclFilesTxtBox.TextLength > 0)
            {
                process.StartInfo.Arguments = source + " " + destination + " /xf " + exclfiles + " /xd " +
                    excldirs + " /log+:" + logfile + " " + switches;
            }
            else if (LogEnCB.Checked == true && LogTeeCB.Checked == false && LogAppendRB.Checked == true
                && ExclDirsTxtBox.TextLength > 0 && ExclFilesTxtBox.TextLength == 0)
            {
                process.StartInfo.Arguments = source + " " + destination + " /xd " + excldirs + " /log+:" + logfile + " " + switches;
            }
            else if (LogEnCB.Checked == true && LogTeeCB.Checked == false && LogAppendRB.Checked == true
                && ExclDirsTxtBox.TextLength == 0 && ExclFilesTxtBox.TextLength > 0)
            {
                process.StartInfo.Arguments = source + " " + destination + " /xf " + exclfiles + " /log+:" + logfile + " " + switches;
            }
            else if (LogEnCB.Checked == true && LogTeeCB.Checked == false && LogAppendRB.Checked == true
                && ExclDirsTxtBox.TextLength == 0 && ExclFilesTxtBox.TextLength == 0)
            {
                process.StartInfo.Arguments = source + " " + destination + " /log+:" + logfile + " " + switches;
            }
            else if (LogEnCB.Checked == false && ExclDirsTxtBox.TextLength > 0 && ExclFilesTxtBox.TextLength > 0)
            {
                process.StartInfo.Arguments = source + " " + destination + " /xf " + exclfiles + " /xd " +
                    excldirs + " " + switches;
            }
            else if (LogEnCB.Checked == false && ExclDirsTxtBox.TextLength > 0 && ExclFilesTxtBox.TextLength == 0)
            {
                process.StartInfo.Arguments = source + " " + destination + " /xd " + excldirs + " " + switches;
            }
            else if (LogEnCB.Checked == false && ExclDirsTxtBox.TextLength == 0 && ExclFilesTxtBox.TextLength > 0)
            {
                process.StartInfo.Arguments = source + " " + destination + " /xf " + exclfiles + " " + switches;
            }
            else
            {
                process.StartInfo.Arguments = source + " " + destination + " " + switches;
            }
            process.StartInfo.UseShellExecute = false;

            if (startRobocopyAsAnIndependentProcessToolStripMenuItem.Checked == true)
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/k robocopy.exe " + process.StartInfo.Arguments;
                process.Start();
            }
            else
            {
                process.StartInfo.FileName = "robocopy.exe";
                process.Start();
                process.WaitForExit();
                process.Close();
            }

            // Reenable the button once the process has finished
            StartButton.Enabled = true;
        }

        private void ExclDirsBrwsButton_Click(object sender, EventArgs e)
        {
            // Open the browse dialog and populate the text box containing the excluded directories
            DialogResult result = FolderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = FolderBrowserDialog.SelectedPath;
                ExclDirsTxtBox.AppendText(" \"" + path + "\"");
            }
        }

        private void ExclFilesBrwsButton_Click(object sender, EventArgs e)
        {
            // Open the browse dialog and populate the text box containing the excluded files
            DialogResult result = OpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = OpenFileDialog.FileName;
                ExclFilesTxtBox.AppendText(" \"" + file + "\"");
            }
        }

        private void ExclDirsClrButton_Click(object sender, EventArgs e)
        {
            // Clear the contents of the text box containing the excluded directories
            if (ExclDirsTxtBox.Text.Length > 0)
            {
                ExclDirsTxtBox.Text = ExclDirsTxtBox.Text.Remove(0);
            }
        }

        private void ExclFilesClrButton_Click(object sender, EventArgs e)
        {
            // Clear the contents of the text box containing the excluded files
            if (ExclFilesTxtBox.Text.Length > 0)
            {
                ExclFilesTxtBox.Text = ExclFilesTxtBox.Text.Remove(0);
            }
        }

        private void SrcTxtBox_TextChanged(object sender, EventArgs e)
        {
            // Populate the string with the source directory in user settings
            Properties.Settings.Default.SourceDir = SrcTxtBox.Text;
        }

        private void DestTxtBox_TextChanged(object sender, EventArgs e)
        {
            // Populate the string with the target directory in user settings
            Properties.Settings.Default.DestDir = DestTxtBox.Text;
        }

        private void SwitchesTxtBox_TextChanged(object sender, EventArgs e)
        {
            // Populate the string with the robocopy arguments in user settings
            Properties.Settings.Default.Switches = SwitchesTxtBox.Text;
        }

        private void ExclDirsTxtBox_TextChanged(object sender, EventArgs e)
        {
            // Populate the string with the excluded directories in user settings
            Properties.Settings.Default.ExclDirs = ExclDirsTxtBox.Text;
        }

        private void ExclFilesTxtBox_TextChanged(object sender, EventArgs e)
        {
            // Populate the string with the excluded files in user settings
            Properties.Settings.Default.ExclFiles = ExclFilesTxtBox.Text;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit application
            this.Close();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check for currently selected tab page and, if necessary, change it to the "General" tab
            if (MainFormTabs.SelectedTab != GeneralTab)
            {
                MainFormTabs.SelectTab(GeneralTab);
            }
        }

        private void excludedFilesAndDirectoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check for currently selected tab page and, if necessary, change it to the "Excluded files and directories" tab
            if (MainFormTabs.SelectedTab != ExcludedTab)
            {
                MainFormTabs.SelectTab(ExcludedTab);
            }
        }

        private void robocopyHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the robocopy help form
            HelpForm form = new HelpForm();
            form.Show();
        }

        private void LogEnCB_CheckedChanged(object sender, EventArgs e)
        {
            // Enable or disable check, radio and text boxes related to logging when the "Enable Logging" check box state is changed
            if (LogTxtBox.Enabled == false && LogSaveLocBtn.Enabled == false &&
                LogTeeCB.Enabled == false && LogOverwriteRB.Enabled == false &&
                LogAppendRB.Enabled == false)
            {
                LogTxtBox.Enabled = true;
                LogSaveLocBtn.Enabled = true;
                LogTeeCB.Enabled = true;
                LogOverwriteRB.Enabled = true;
                LogAppendRB.Enabled = true;
            }
            else
            {
                LogTxtBox.Enabled = false;
                LogSaveLocBtn.Enabled = false;
                LogTeeCB.Enabled = false;
                LogOverwriteRB.Enabled = false;
                LogAppendRB.Enabled = false;
            }

            // Populate the boolean value indicating whether the logging feature is enabled or not in user settings
            Properties.Settings.Default.LogEnabled = LogEnCB.Checked;
        }

        private void LogSaveLocBtn_Click(object sender, EventArgs e)
        {
            // Set a few options regarding the save file dialog first
            SaveFileDialog.DefaultExt = "*.log";
            SaveFileDialog.Filter = "Log files (*.log)|*.log|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            SaveFileDialog.Title = "Choose where you want your log file to be saved";

            // Open the save file dialog and populate the text box containing the location of the log file
            DialogResult result = SaveFileDialog.ShowDialog();
            if (result == DialogResult.OK &&
                SaveFileDialog.FileName.Length > 0)
            {
                string file = SaveFileDialog.FileName;
                LogTxtBox.Text = file;
            }
        }

        private void LogTxtBox_TextChanged(object sender, EventArgs e)
        {
            // Populate the string with the log file location in user settings
            Properties.Settings.Default.LogFileLocation = LogTxtBox.Text;
        }

        private void LogTeeCB_CheckedChanged(object sender, EventArgs e)
        {
            // Populate the boolean value indicating whether the sending output to both console window
            // and the log file is enabled or not in user settings
            Properties.Settings.Default.LogTee = LogTeeCB.Checked;
        }

        private void LogOverwriteRB_CheckedChanged(object sender, EventArgs e)
        {
            // Populate the boolean value indicating whether the option to overwrite the existing log
            // file is enabled or not in user settings
            Properties.Settings.Default.LogOverwrite = LogOverwriteRB.Checked;
        }

        private void LogAppendRB_CheckedChanged(object sender, EventArgs e)
        {
            // Populate the boolean value indicating whether the option to append to the existing log
            // file is enabled or not in user settings
            Properties.Settings.Default.LogAppend = LogAppendRB.Checked;
        }

        private void SaveScriptClose(object sender, EventArgs e)
        {
            // Set a few options regarding the save file dialog first
            SaveFileDialog.DefaultExt = "*.cmd";
            SaveFileDialog.Filter = "Windows Batch Scripts (*.cmd)|*.cmd|Windows Batch Scripts (*.bat)|*.bat|All files (*.*)|*.*";
            SaveFileDialog.Title = "Choose the location for your script";

            // Open the save file dialog and put some text into a newly created batch script, based upon
            // the settings prevoiusly chosen in the GUI
            DialogResult result = SaveFileDialog.ShowDialog();
            if (result == DialogResult.OK &&
                SaveFileDialog.FileName.Length > 0)
            {
                // First set some strings for easier reference later
                string file = SaveFileDialog.FileName;
                string source = AddQuotations(SrcTxtBox.Text);
                string destination = AddQuotations(DestTxtBox.Text);
                string switches = SwitchesTxtBox.Text;
                string exclfiles = ExclFilesTxtBox.Text;
                string excldirs = ExclDirsTxtBox.Text;
                string logfile = AddQuotations(LogTxtBox.Text);

                // Open the file for writing
                TextWriter script = new StreamWriter(file);
                // The standard first two lines
                script.WriteLine("@cls" + Environment.NewLine + "@echo off" + Environment.NewLine);
                // Check all the possible variables and write the line containing the command
                // and its arguments accordingly
                if (LogEnCB.Checked == true && LogTeeCB.Checked == true && LogOverwriteRB.Checked == true
                    && ExclDirsTxtBox.TextLength > 0 && ExclFilesTxtBox.TextLength > 0)
                {
                    script.WriteLine("robocopy.exe " + source + " " + destination + " /xf " + exclfiles + " /xd " +
                        excldirs + " /tee /log:" + logfile + " " + switches);
                }
                else if (LogEnCB.Checked == true && LogTeeCB.Checked == true && LogOverwriteRB.Checked == true
                    && ExclDirsTxtBox.TextLength > 0 && ExclFilesTxtBox.TextLength == 0)
                {
                    script.WriteLine("robocopy.exe " + source + " " + destination + " /xd " + excldirs +
                        " /tee /log:" + logfile + " " + switches);
                }
                else if (LogEnCB.Checked == true && LogTeeCB.Checked == true && LogOverwriteRB.Checked == true
                    && ExclDirsTxtBox.TextLength == 0 && ExclFilesTxtBox.TextLength > 0)
                {
                    script.WriteLine("robocopy.exe " + source + " " + destination + " /xf " + exclfiles + 
                        " /tee /log:" + logfile + " " + switches);
                }
                else if (LogEnCB.Checked == true && LogTeeCB.Checked == true && LogOverwriteRB.Checked == true
                    && ExclDirsTxtBox.TextLength == 0 && ExclFilesTxtBox.TextLength == 0)
                {
                    script.WriteLine("robocopy.exe " + source + " " + destination + " /tee /log:" + logfile + " " + switches);
                }
                else if (LogEnCB.Checked == true && LogTeeCB.Checked == true && LogAppendRB.Checked == true
                    && ExclDirsTxtBox.TextLength > 0 && ExclFilesTxtBox.TextLength > 0)
                {
                    script.WriteLine("robocopy.exe " + source + " " + destination + " /xf " + exclfiles + " /xd " +
                        excldirs + " /tee /log+:" + logfile + " " + switches);
                }
                else if (LogEnCB.Checked == true && LogTeeCB.Checked == true && LogAppendRB.Checked == true
                    && ExclDirsTxtBox.TextLength > 0 && ExclFilesTxtBox.TextLength == 0)
                {
                    script.WriteLine("robocopy.exe " + source + " " + destination + " /xd " + excldirs +
                        " /tee /log+:" + logfile + " " + switches);
                }
                else if (LogEnCB.Checked == true && LogTeeCB.Checked == true && LogAppendRB.Checked == true
                    && ExclDirsTxtBox.TextLength == 0 && ExclFilesTxtBox.TextLength > 0)
                {
                    script.WriteLine("robocopy.exe " + source + " " + destination + " /xf " + exclfiles +
                        " /tee /log+:" + logfile + " " + switches);
                }
                else if (LogEnCB.Checked == true && LogTeeCB.Checked == true && LogAppendRB.Checked == true
                    && ExclDirsTxtBox.TextLength == 0 && ExclFilesTxtBox.TextLength == 0)
                {
                    script.WriteLine("robocopy.exe " + source + " " + destination + " /tee /log+:" + logfile + " " + switches);
                }
                else if (LogEnCB.Checked == true && LogTeeCB.Checked == false && LogOverwriteRB.Checked == true
                    && ExclDirsTxtBox.TextLength > 0 && ExclFilesTxtBox.TextLength > 0)
                {
                    script.WriteLine("robocopy.exe " + source + " " + destination + " /xf " + exclfiles + " /xd " +
                        excldirs + " /log:" + logfile + " " + switches);
                }
                else if (LogEnCB.Checked == true && LogTeeCB.Checked == false && LogOverwriteRB.Checked == true
                    && ExclDirsTxtBox.TextLength > 0 && ExclFilesTxtBox.TextLength == 0)
                {
                    script.WriteLine("robocopy.exe " + source + " " + destination + " /xd " + excldirs + " /log:" + logfile + " " + switches);
                }
                else if (LogEnCB.Checked == true && LogTeeCB.Checked == false && LogOverwriteRB.Checked == true
                    && ExclDirsTxtBox.TextLength == 0 && ExclFilesTxtBox.TextLength > 0)
                {
                    script.WriteLine("robocopy.exe " + source + " " + destination + " /xf " + exclfiles + " /log:" + logfile + " " + switches);
                }
                else if (LogEnCB.Checked == true && LogTeeCB.Checked == false && LogOverwriteRB.Checked == true
                    && ExclDirsTxtBox.TextLength == 0 && ExclFilesTxtBox.TextLength == 0)
                {
                    script.WriteLine("robocopy.exe " + source + " " + destination + " /log:" + logfile + " " + switches);
                }
                else if (LogEnCB.Checked == true && LogTeeCB.Checked == false && LogAppendRB.Checked == true
                    && ExclDirsTxtBox.TextLength > 0 && ExclFilesTxtBox.TextLength > 0)
                {
                    script.WriteLine("robocopy.exe " + source + " " + destination + " /xf " + exclfiles + " /xd " +
                        excldirs + " /log+:" + logfile + " " + switches);
                }
                else if (LogEnCB.Checked == true && LogTeeCB.Checked == false && LogAppendRB.Checked == true
                    && ExclDirsTxtBox.TextLength > 0 && ExclFilesTxtBox.TextLength == 0)
                {
                    script.WriteLine("robocopy.exe " + source + " " + destination + " /xd " + excldirs + " /log+:" + logfile + " " + switches);
                }
                else if (LogEnCB.Checked == true && LogTeeCB.Checked == false && LogAppendRB.Checked == true
                    && ExclDirsTxtBox.TextLength == 0 && ExclFilesTxtBox.TextLength > 0)
                {
                    script.WriteLine("robocopy.exe " + source + " " + destination + " /xf " + exclfiles + " /log+:" + logfile + " " + switches);
                }
                else if (LogEnCB.Checked == true && LogTeeCB.Checked == false && LogAppendRB.Checked == true
                    && ExclDirsTxtBox.TextLength == 0 && ExclFilesTxtBox.TextLength == 0)
                {
                    script.WriteLine("robocopy.exe " + source + " " + destination + " /log+:" + logfile + " " + switches);
                }
                else if (LogEnCB.Checked == false && ExclDirsTxtBox.TextLength > 0 && ExclFilesTxtBox.TextLength > 0)
                {
                    script.WriteLine("robocopy.exe " + source + " " + destination + " /xf " + exclfiles + " /xd " +
                        excldirs + " " + switches);
                }
                else if (LogEnCB.Checked == false && ExclDirsTxtBox.TextLength > 0 && ExclFilesTxtBox.TextLength == 0)
                {
                    script.WriteLine("robocopy.exe " + source + " " + destination + " /xd " + excldirs + " " + switches);
                }
                else if (LogEnCB.Checked == false && ExclDirsTxtBox.TextLength == 0 && ExclFilesTxtBox.TextLength > 0)
                {
                    script.WriteLine("robocopy.exe " + source + " " + destination + " /xf " + exclfiles + " " + switches);
                }
                else
                {
                    script.WriteLine("robocopy.exe " + source + " " + destination + " " + switches);
                }
                // The standard exit line at the end
                script.WriteLine(Environment.NewLine + "exit");
                // Finish writing and close the file
                script.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the About box
            AboutBox form = new AboutBox();
            form.Show();
        }

        private void startRobocopyAsAnIndependentProcessToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            // Populate the boolean value indicating whether the option to start robocopy
            // as an independent process is enabled or not in user settings
            Properties.Settings.Default.IndProcessState = startRobocopyAsAnIndependentProcessToolStripMenuItem.Checked;
        }
    }
}
