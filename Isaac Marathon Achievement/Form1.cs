using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Isaac_Achievement_Unlocker
{   
    public partial class MainForm : Form
    {
        IsaacFileLocator ifl;
        IsaacSaveEditor ise;

        public MainForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "v1.0" + Environment.NewLine +
                             "Created by Halfwar" + Environment.NewLine +
                             "Isaac Checksum File Generation by bladecoding" + Environment.NewLine +
                             "Darkbum .ico File made by underpieces" + Environment.NewLine;

            MessageBox.Show(message, "About");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if( startBtn.Text.ToLower().Equals("start") )
            {
                startBtn.Enabled = false;
                startBtn.Text = "Save?";
                ifl = new IsaacFileLocator();
                userListBox.DataSource = ifl.SaveFileUsers;
            }
            else if( startBtn.Text.ToLower().Equals("save?") )
            {
                Dictionary<string, bool> achievementDict = new Dictionary<string, bool>();
                for (int i = 0; i < achCheckedListBox.Items.Count; i++)
                {
                    string key = (string)achCheckedListBox.Items[i];
                    bool value = achCheckedListBox.GetItemCheckState(i) == CheckState.Checked;
                    achievementDict.Add(key, value);
                }
                if( ise.updateAchivments(achievementDict) )
                {
                    MessageBox.Show("Savefile Updated and Backup Saved", "Save File Updated");
                }
                else
                {
                    MessageBox.Show("No Changes to Make, Save File was not changed", "Save File Not Updated");
                }
            }
        }

        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveSlotListBox.DataSource = ifl.getSaveSlots(userListBox.SelectedItem.ToString());
            startBtn.Enabled = false;
        }

        private void saveSlotListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            achCheckedListBox.Items.Clear();
            string saveLocation = ifl.getFilePath(saveSlotListBox.SelectedItem.ToString());
            Console.WriteLine(saveLocation);
            ise = new IsaacSaveEditor(saveLocation);
            ise.checkForAchievements();
            startBtn.Enabled = false;
            foreach (KeyValuePair<string, bool> kvp in ise.Achievements)
            {
                achCheckedListBox.Items.Add(kvp.Key, kvp.Value);
            }
        }

        private void achCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            startBtn.Enabled = true;
        }
    }
}
