using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wlasny_Music_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSearchForFiles_Click(object sender, EventArgs e)
        {
            if (openFileDialogMusic.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] files, paths;
                files = openFileDialogMusic.SafeFileNames;
                paths = openFileDialogMusic.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    FileData.fileStorage.Add(new FileData(files[i], paths[i]));
                    listBoxMusic.Items.Add(files[i]);
                }
            }
        }
        
        private void listBoxMusic_DoubleClick(object sender, EventArgs e)
        {
            //zagraj dana muzyke
        }

        private void listBoxMusic_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.listBoxMusic.SelectedItems == null) return;
            this.listBoxMusic.DoDragDrop(this.listBoxMusic.SelectedItem, DragDropEffects.Move);
        }

        private void listBoxMusic_DragDrop(object sender, DragEventArgs e)
        {
            Point point = listBoxMusic.PointToClient(new Point(e.X, e.Y));
            int index = this.listBoxMusic.IndexFromPoint(point);
            if (index < 0) index = this.listBoxMusic.Items.Count - 1;
            object data = e.Data.GetData(typeof(string));
            this.listBoxMusic.Items.Remove(data);
            this.listBoxMusic.Items.Insert(index, data);
        }

        private void listBoxMusic_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}
