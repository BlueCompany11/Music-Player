using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wlasny_Music_Player
{
    public class SaveForm:Form
    {
        private TextBox saveNameTxtBox;
        private ListBox savedPlaylistsListBox;
        private Button saveButton;
        private Button deleteButton;
        private Label label1;

        public SaveForm()
        {
            InitializeComponent();
            GetNamesFromFiles();
        }

        private void InitializeComponent()
        {
            this.saveNameTxtBox = new System.Windows.Forms.TextBox();
            this.savedPlaylistsListBox = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveNameTxtBox
            // 
            this.saveNameTxtBox.Location = new System.Drawing.Point(55, 25);
            this.saveNameTxtBox.Name = "saveNameTxtBox";
            this.saveNameTxtBox.Size = new System.Drawing.Size(217, 20);
            this.saveNameTxtBox.TabIndex = 0;
            // 
            // savedPlaylistsListBox
            // 
            this.savedPlaylistsListBox.FormattingEnabled = true;
            this.savedPlaylistsListBox.Location = new System.Drawing.Point(12, 75);
            this.savedPlaylistsListBox.Name = "savedPlaylistsListBox";
            this.savedPlaylistsListBox.Size = new System.Drawing.Size(260, 212);
            this.savedPlaylistsListBox.TabIndex = 1;
            this.savedPlaylistsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.savedPlaylistsListBox_MouseDoubleClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(278, 25);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(278, 264);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Usuń";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazwa";
            // 
            // SaveForm
            // 
            this.ClientSize = new System.Drawing.Size(365, 306);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.savedPlaylistsListBox);
            this.Controls.Add(this.saveNameTxtBox);
            this.Name = "SaveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = saveNameTxtBox.Text;
                MusicPlayLists.SavePlayListToXML(name);
                MessageBox.Show("Zapisano");
                GetNamesFromFiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nOperacja sie nie powiodła");
            }
        }

        private void GetNamesFromFiles()
        {
            savedPlaylistsListBox.Items.Clear();
            DirectoryInfo directory = new DirectoryInfo(MusicPlayLists.pathToFolder);
            FileInfo[] Files = directory.GetFiles("*.xml");
            for (int i = 0; i < Files.Length; i++)
            {
                savedPlaylistsListBox.Items.Add(Files[i]);
            }
        }
        /// <summary>
        /// Load the playlist from the xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void savedPlaylistsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int index = savedPlaylistsListBox.SelectedIndex;
                string fileName = savedPlaylistsListBox.SelectedItem.ToString();
                string path = MusicPlayLists.pathToFolder;
                string[] xmlList = Directory.GetFiles(path, "*.xml");

                //pobieranie odpowiedniej sciezki majac do dyspozycji tylko nazwe pliku
                foreach (var item in xmlList)
                {
                    if (item.Contains(fileName))
                    {
                        fileName = item;
                        break;
                    }
                }
                File.Delete(fileName);
                GetNamesFromFiles();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //aktualizacja listy w finally
        }
    }
}
