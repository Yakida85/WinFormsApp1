using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class WordList
    {

        private List<Word> WList;
        public string Name { get; }
        public string[] Languages { get; }
        private static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/Gloser";


        public WordList(string name, params string[] languages)
        {

            Name = name;
            Languages = languages;
            WList = new List<Word>();

            CreateDirectory();
        }
        public static string[] GetLists()
        {
            string[] files = Directory.GetFiles(folderPath, "*.dat");
            string[] lists = new string[files.Length];

            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].EndsWith(".dat"))
                {
                    lists[i] = Path.GetFileName(files[i].Substring(0, files[i].Length - 4));
                }
            }
            return lists;
        }
        public static WordList LoadList(string name)
        {
            WordList wordList = new WordList(name);

            string[] lines = File.ReadAllLines(folderPath + "/" + name + ".dat");
            for (int line = 0; line < lines.Length; line++)
            {
                string[] translations = lines[line].Split(';');

                if (line == 0)
                {
                    wordList = new WordList(name, translations);
                }
                else wordList.Add(translations);
            }


            return wordList;
        }
        public void Save()
        {

            if (!File.Exists(folderPath + "/" + Name + ".dat"))
            {
                using (StreamWriter writer = File.CreateText(folderPath + "/" + Name + ".dat")) ;
                Word wordlan = new Word(Languages);
                WList.Add(wordlan);
            }
            StreamWriter sw = new StreamWriter(folderPath + "/" + Name + ".dat");
            sw.WriteLine(string.Join(";", Languages));
            foreach (Word word in WList)
            {

                string line = string.Join(';', word.Translations);
                sw.WriteLine(line);
            }
            sw.Close();

        }
        public void Add(params string[] translations)
        {
            if (translations.Length != Languages.Length)
            {
                throw new ArgumentException("The number of enterd words do not match the number of  languages.");
            }

            Word word = new Word(translations);
            WList.Add(word);
        }


        public bool Remove(int translation, string word)
        {
            int index = 0;
            foreach (Word i in WList)
            {

                if (i.Translations[translation] == word)
                {

                    WList.RemoveAt(index);

                    Save();
                    return true;
                }
                index++;


            }

            return false;
        }
        public int Count()
        {
            return WList.Count;

        }


        private void CreateDirectory()
        {
            if (!Directory.Exists(folderPath))
            {
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(folderPath);
            }
        }
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            List<Word> WList2 = WList;
            showTranslations(WList2[0].Translations);
            WList2.RemoveAt(0);
            WList2 = WList2.OrderBy(sortL => sortL.Translations[sortByTranslation]).ToList();

            foreach (Word word in WList2)
            {
                showTranslations(word.Translations);
            }
        }

        public Word GetWordToPractice()
        {

            Random rd = new Random();
            int rand_num = rd.Next(0,Languages.Count());
            int rand_num2 = 0;
            while (true)
            {
                rand_num2 = rd.Next(0, Languages.Count());
                if (rand_num != rand_num2)
                {
                    break;
                }

            }
            int rand_word = rd.Next(0, WList.Count());

            Word word = WList[rand_word];
            return new Word(rand_num, rand_num2, word.Translations);


        }
        public String Getlanguge(int index)
        {
            return Languages[index];
        }


        public int GetlangugeIndex(String index)
        {
            int lang = Array.IndexOf(Languages, index);

            return lang;

        }
    }
}
