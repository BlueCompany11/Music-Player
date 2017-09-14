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
        int indexOfItemListLastClicked = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdatePlayList()
        {
            //paths2 zawiera wszystkie sciezki z listy, na jej podstawie robie playliste
            string[] allPaths = FileData.AllPaths();
            Console.WriteLine("Sciezki");
            foreach (var item in allPaths)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Koniec sciezki");
            var myPlayList = axWindowsMediaPlayer1.playlistCollection.newPlaylist("MyPlayList");
            foreach (string path in allPaths)
            {
                var mediaItem = axWindowsMediaPlayer1.newMedia(path);
                myPlayList.appendItem(mediaItem);
            }
            axWindowsMediaPlayer1.currentPlaylist = myPlayList;
            int x = axWindowsMediaPlayer1.currentPlaylist.count;
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
            UpdatePlayList();
        }

        /// <summary>
        /// Left click raises dragdrop event, right click deletes the clicked position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxMusic_MouseDown(object sender, MouseEventArgs e)
        {
            indexOfItemListLastClicked = listBoxMusic.SelectedIndex;
            Console.WriteLine(indexOfItemListLastClicked);
            //tutaj trzeba zapisywac ostatni nacisniety przycisk by miec miejsce na liscie ktore zostanie przesuniete
            //na index z dragdrop
            if (e.Button == MouseButtons.Left && e.Clicks == 1 && listBoxMusic.SelectedItem != null)
            {
                //jak sie wysypie dac try catch
                if (this.listBoxMusic.SelectedItems == null) return;
                this.listBoxMusic.DoDragDrop(this.listBoxMusic.SelectedItem, DragDropEffects.Move);
            }
            //przetestowane
            else if (e.Button == MouseButtons.Right)
            {
                FileData.fileStorage.RemoveAt(listBoxMusic.SelectedIndex);
                listBoxMusic.Items.Remove(listBoxMusic.SelectedItem);
                UpdatePlayList();
            }
        }

        private void listBoxMusic_DragDrop(object sender, DragEventArgs e)
        {
            Point point = listBoxMusic.PointToClient(new Point(e.X, e.Y));
            //index itemu upuszczonego? tak, sprawdzone
            int index = this.listBoxMusic.IndexFromPoint(point);
            //co ta linijka robi? kiedy index moze byc mniejszy od 0?
            if (index < 0) index = this.listBoxMusic.Items.Count - 1;
            //tworzenie kopii itemu przeciaganego
            object data = e.Data.GetData(typeof(string));
            //usuniecie go
            this.listBoxMusic.Items.Remove(data);
            //wstawienie w nowe miejsce
            this.listBoxMusic.Items.Insert(index, data);

            //kod na poprawna modyfikacje listy
            FileData.ChangeItemPosition(FileData.fileStorage, index, indexOfItemListLastClicked);
            UpdatePlayList();
            //Console.WriteLine(FileData.fileStorage[index].GetFile());
            //Console.WriteLine(FileData.fileStorage[indexOfItemListLastClicked].GetFile());
        }

        private void listBoxMusic_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBoxMusic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FileData.fileStorage.Count > 0)
                axWindowsMediaPlayer1.URL = FileData.fileStorage[listBoxMusic.SelectedIndex].GetPath();
        }

        private void listBoxMusic_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("a");
        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {

        }
    }
}
