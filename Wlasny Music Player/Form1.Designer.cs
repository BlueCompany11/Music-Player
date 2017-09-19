namespace Wlasny_Music_Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBoxMusic = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSaveList = new System.Windows.Forms.Button();
            this.buttonClearList = new System.Windows.Forms.Button();
            this.buttonSearchForFiles = new System.Windows.Forms.Button();
            this.openFileDialogMusic = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.axWindowsMediaPlayer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxMusic, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.74074F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.25926F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 329);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(601, 128);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // listBoxMusic
            // 
            this.listBoxMusic.AllowDrop = true;
            this.listBoxMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMusic.FormattingEnabled = true;
            this.listBoxMusic.Location = new System.Drawing.Point(3, 137);
            this.listBoxMusic.Name = "listBoxMusic";
            this.listBoxMusic.Size = new System.Drawing.Size(601, 189);
            this.listBoxMusic.TabIndex = 1;
            this.listBoxMusic.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxMusic_DragDrop);
            this.listBoxMusic.DragOver += new System.Windows.Forms.DragEventHandler(this.listBoxMusic_DragOver);
            this.listBoxMusic.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxMusic_MouseDoubleClick);
            this.listBoxMusic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxMusic_MouseDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.buttonSaveList, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonClearList, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSearchForFiles, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 332);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(601, 46);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonSaveList
            // 
            this.buttonSaveList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSaveList.Location = new System.Drawing.Point(403, 3);
            this.buttonSaveList.Name = "buttonSaveList";
            this.buttonSaveList.Size = new System.Drawing.Size(195, 40);
            this.buttonSaveList.TabIndex = 2;
            this.buttonSaveList.Text = "Zapisz listę";
            this.buttonSaveList.UseVisualStyleBackColor = true;
            this.buttonSaveList.Click += new System.EventHandler(this.buttonSaveList_Click);
            // 
            // buttonClearList
            // 
            this.buttonClearList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClearList.Location = new System.Drawing.Point(203, 3);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(194, 40);
            this.buttonClearList.TabIndex = 1;
            this.buttonClearList.Text = "Wyczyść listę";
            this.buttonClearList.UseVisualStyleBackColor = true;
            this.buttonClearList.Click += new System.EventHandler(this.buttonClearList_Click);
            // 
            // buttonSearchForFiles
            // 
            this.buttonSearchForFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearchForFiles.Location = new System.Drawing.Point(3, 3);
            this.buttonSearchForFiles.Name = "buttonSearchForFiles";
            this.buttonSearchForFiles.Size = new System.Drawing.Size(194, 40);
            this.buttonSearchForFiles.TabIndex = 0;
            this.buttonSearchForFiles.Text = "Wyszukaj pliki";
            this.buttonSearchForFiles.UseVisualStyleBackColor = true;
            this.buttonSearchForFiles.Click += new System.EventHandler(this.buttonSearchForFiles_Click);
            // 
            // openFileDialogMusic
            // 
            this.openFileDialogMusic.Filter = "MP3 Files|*.mp3|WAV Files|*.wav|WMV Files|*.wmv";
            this.openFileDialogMusic.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 381);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Music Player";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listBoxMusic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonSaveList;
        private System.Windows.Forms.Button buttonClearList;
        private System.Windows.Forms.Button buttonSearchForFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialogMusic;
    }
}

