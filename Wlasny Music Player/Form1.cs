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
            //funkcja do tworzenia playlisty
            //trzeba ja uaktualniac w odpowienidch miejscach
            string[] paths2 = FileData.AllPaths();
            var myPlayList = axWindowsMediaPlayer1.playlistCollection.newPlaylist("MyPlayList");
            foreach (string path in paths2)
            {
                var mediaItem = axWindowsMediaPlayer1.newMedia(path);
                myPlayList.appendItem(mediaItem);
            }
            axWindowsMediaPlayer1.currentPlaylist = myPlayList;
        }
        /// <summary>
        /// Left click raises dragdrop event, right click deletes the clicked position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxMusic_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1 && listBoxMusic.SelectedItem != null)
            {
                //jak sie wysypie dac try catch
                if (this.listBoxMusic.SelectedItems == null) return;
                this.listBoxMusic.DoDragDrop(this.listBoxMusic.SelectedItem, DragDropEffects.Move);
            }
            else if (e.Button == MouseButtons.Right)
            {
                listBoxMusic.Items.Remove(listBoxMusic.SelectedItem);
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
            //insert i remove at
            //tutaj jest modyfikacja listy z ktorej bedzie czytana scieza do odtworzenia muzyki
            //string oldpath=
            //FileData.fileStorage.Insert( index, new FileData((string)data, ""));
        }

        private void listBoxMusic_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        //do usuniecia
        //to zdarzzenie odpowiada za poprawne wlaczenie muzyki przy double clicku
        //domyslnie jest ustawiany na -1, trzeba mu przypisac inna wartosc
        //private int lastindex = -10;
        //private void listBoxMusic_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (lastindex != listBoxMusic.SelectedIndex)
        //    {
        //        //axWindowsMediaPlayer1.URL = FileData.fileStorage[listBoxMusic.SelectedIndex].GetPath();
        //        axWindowsMediaPlayer1.URL = FileData.fileStorage[0].GetPath();
        //        lastindex = listBoxMusic.SelectedIndex;
        //    }
        //    MessageBox.Show(listBoxMusic.SelectedIndex.ToString());
        //}

        private void buttonClearList_Click(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.CreateControl();
            //var mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            //var myPlayList = mediaPlayer.playlistCollection.newPlaylist("myPlayList");
            //WMPLib.IWMPMedia media;
            //string[] paths2 = FileData.AllPaths();
            //foreach (var fileName in paths2)
            //{
            //    media = mediaPlayer.newMedia(fileName);
            //    myPlayList.appendItem(media);
            //}
            //mediaPlayer.currentPlaylist = myPlayList;
            //mediaPlayer.Ctlcontrols.play();
            //string[] paths2 = FileData.AllPaths();
            //var myPlayList = axWindowsMediaPlayer1.playlistCollection.newPlaylist("MyPlayList");
            //foreach (string path in paths2)
            //{
            //    var mediaItem = axWindowsMediaPlayer1.newMedia(path);
            //    myPlayList.appendItem(mediaItem);
            //}
            //axWindowsMediaPlayer1.currentPlaylist = myPlayList;
        }

        private void listBoxMusic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FileData.fileStorage.Count > 0)
                axWindowsMediaPlayer1.URL = FileData.fileStorage[listBoxMusic.SelectedIndex].GetPath();
        }
    }
}
