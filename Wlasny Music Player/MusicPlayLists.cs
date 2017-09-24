using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace Wlasny_Music_Player
{
    public class MusicPlayLists
    {
        string[] file = new string[100];
        string[] path;
        public static string pathToFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Playlisty WMP";
        public MusicPlayLists()
        {
        }
        public MusicPlayLists(List<FileData> dataList)
        {
            int length = dataList.Count;
            this.file = new string[length];
            this.path = new string[length];
            for (int i = 0; i < length; i++)
            {
                file[i] = dataList[i].GetFile();
                path[i] = dataList[i].GetPath();
                Console.WriteLine(file[i]);
                Console.WriteLine(path[i]);
            }

        }
        public static void SavePlayListToXML(string name)
        {
            int size = FileData.fileStorage.Count;
            string[] pathsToSave = new string[size];
            string[] fileName = new string[size];
            for (int i = 0; i < size; i++)
            {
                pathsToSave[i] = FileData.fileStorage[i].GetPath();
                pathsToSave[i] += '\n';
                fileName[i] = FileData.fileStorage[i].GetFile();
                fileName[i] += '\n';
            }
            XDocument xDoc = new XDocument(
                new XElement("File",
                new XElement("path", pathsToSave),
                new XElement("fileName",fileName)
                )
                );
            
            string path = pathToFolder + "//" + name + ".xml";
            if (!Directory.Exists(pathToFolder))
            {
                Directory.CreateDirectory(pathToFolder);
            }
            xDoc.Save(path);
        }
    }
}
