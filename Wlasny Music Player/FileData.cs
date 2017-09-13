﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wlasny_Music_Player
{
    public class FileData
    {
        public static List<FileData> fileStorage=new List<FileData>();
        string file, path;
        //jesli bede dodawal do xmla to dodac bezparametrowy konstruktor
        public FileData(string file, string path)
        {
            this.file = file;
            this.path = path;
        }
        public string GetPath()
        {
            return this.path;
        }
        public string GetFile()
        {
            return this.file;
        }
    }
}