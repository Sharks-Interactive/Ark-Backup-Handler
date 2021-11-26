using ABH.Files.Backup;
using ABH.Files.MoD;
using System;
using ABH.Logging;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ABH.UI
{
    /// <summary>
    /// Contains defenitions for all button hooks
    /// </summary>
    public partial class UIProcess
    {
        private void g_changeBackupLocationButton_MouseClick(object sender, MouseEventArgs e) => g_backupLocationDialog.ShowDialog();

        private void g_changeArkSaveLocationButton_MouseClick(object sender, MouseEventArgs e) => g_arkSaveLocationDialog.ShowDialog();

        private void g_transferDataSaveIntervalChooser_ValueChanged(object sender, EventArgs e)
        {
            g_transferDataSaveTimer.Stop();
            g_transferDataSaveTimer.Interval = (int)(g_transferDataSaveIntervalChooser.Value * 60000);
            g_transferDataSaveTimer.Start();

            _transferDataSaveInterval = g_transferDataSaveIntervalChooser.Value;
            Properties.Settings.Default.transferDataSaveInterval = _transferDataSaveInterval;
        }

        private void g_saveIntervalChooser_ValueChanged(object sender, EventArgs e)
        {
            g_saveTimer.Stop();
            g_saveTimer.Interval = (int)(_autoSaveInterval * 60000);
            g_saveTimer.Start();

            _autoSaveInterval = g_saveIntervalChooser.Value;
            Properties.Settings.Default.autoSaveInterval = _autoSaveInterval; 
        }

        private void g_updateMoDButton_MouseClick(object sender, MouseEventArgs e)
        {
            Logger.Log("Beginning MoD update.", Logger.ErrorLevel.Info);
            ModManager.UpdateMessegeOfTheDay();
        }

        private void g_errorDisplay_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.StringFormat, g_errorDisplay.Text);
            Logger.Log("No errors to display.", Logger.ErrorLevel.Info);
        }

        private void g_manualBackupLocationButton_MouseClick(object sender, MouseEventArgs e) => g_manualSaveBox.Visible = !g_manualSaveBox.Visible;

        private void g_MinimizeButton_MouseClick(object sender, MouseEventArgs e) => MinimizeToTray();

        private void g_TrayIcon_MouseClick(object Sender, MouseEventArgs Event) => OpenFromTray();

        private void g_submitButton_MouseClick(object sender, MouseEventArgs e)
        {
            BackupManager.BackupMapAndConfigFiles(false, g_milestoneCheckbox.Checked, g_backupName.Text);
            
            g_manualSaveBox.Visible = false;
            g_milestoneCheckbox.Checked = false;
            g_backupName.ResetText();
        }

        private void g_MaxMapSaves_ValueChanged(object Sender, EventArgs Event)
        {
            _maxMapSaves = (int)g_MaxMapSaves.Value;
            Properties.Settings.Default.maxSaves = _maxMapSaves;
            Properties.Settings.Default.Save();
        }

        private void g_reportProblemButton_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("explorer", "https://github.com/Sharks-Interactive/Ark-Backup-Handler/issues");

        private void g_backupsButton_Click(object sender, EventArgs e) => g_tabs.SelectTab(g_backup);

        private void g_revertButton_Click(object sender, EventArgs e)
        {
            g_tabs.SelectTab(g_revert);
            GetTreeNode("ManualNode", g_backupsList.Nodes).Nodes.Clear();
            GetTreeNode("AutomaticNode", g_backupsList.Nodes).Nodes.Clear();
            GetTreeNode("MilestoneNode", g_backupsList.Nodes).Nodes.Clear();

            _revert.InitPage();
            List<TreeNode> manualBackups = _revert.GetManualBackups();
            List<TreeNode> automaticBackups = _revert.GetAutomaticBackups();
            List<TreeNode> milestoneBackups = _revert.GetMilestoneBackups();

            foreach (TreeNode node in manualBackups)
                GetTreeNode("ManualNode", g_backupsList.Nodes).Nodes.Add(node);

            foreach (TreeNode node in automaticBackups)
                GetTreeNode("AutomaticNode", g_backupsList.Nodes).Nodes.Add(node);

            foreach (TreeNode node in milestoneBackups)
                GetTreeNode("MilestoneNode", g_backupsList.Nodes).Nodes.Add(node);
        }

        private TreeNode GetTreeNode(string name, TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
                if (node.Name == name) return node;

            return new TreeNode("Null");
        }
    }
}
