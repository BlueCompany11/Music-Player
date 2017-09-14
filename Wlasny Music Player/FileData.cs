using System;
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

        public static string[] AllPaths()
        {
            int size = fileStorage.Count;
            string[] paths = new string[size];
            for (int i = 0; i < size; i++)
            {
                paths[i] = fileStorage[i].path;
            }
            return paths;
        }
        /// <summary>
        /// Those indexes are correct for list before changes.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="indexToInsert"></param>
        /// <param name="indexToRemove"></param>
        public static void ChangeItemPosition(List<FileData> list,int indexToInsert, int indexToRemove)//przetestowana
        {
            var temp = list[indexToRemove];
            list.RemoveAt(indexToRemove);
            list.Insert(indexToInsert, temp);
            foreach (var item in list)
            {
                Console.WriteLine(item.file);
            }
        }
    }
}
