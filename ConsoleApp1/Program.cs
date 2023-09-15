using ClassLibrary1;
 namespace ConsoleApp1
{
    internal class Program
    {
        public static void lists()
        {
            string[] listNames = WordList.GetLists();
            Console.WriteLine("Available WordList:");
            foreach (string name in listNames)
            {
                Console.WriteLine(name);
            }
        }
        public static void newList()
        {
            Console.WriteLine("Enter list name:");
            String Listname = Console.ReadLine();
            Console.WriteLine(" Enter languages separated by a space.");
            String languages = Console.ReadLine();
            string[] words = languages.Split(' ');

            WordList wordList = new WordList(Listname, words);
            wordList.Save();
            addWord(wordList);
        }

        public static void addWord(WordList wordList)
        {
            Boolean stop = false;
            while (stop != true)
            {
                Console.WriteLine("Enter translation sparated by (;):");
                String input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    stop = true;
                }
                else
                {
                    //input = input.Replace(',', ';');
                    string[] inputSplit = input.Split(';');
                    wordList.Add(inputSplit);
                    wordList.Save();
                }
            }
        }
        public static void remove(String language, String Enword ,WordList wordList)
        {
            Console.WriteLine( wordList.Remove(wordList.GetlangugeIndex(language), Enword));
            wordList.Save();
        }
        
        public static void count()
        {
            Console.WriteLine("Enter list name:");
            String Listname = Console.ReadLine();
            WordList loadedList = WordList.LoadList(Listname);
            Console.WriteLine("The number of words are : " + loadedList.Count());
        }



        public static Boolean practice(WordList loadList)
        {
            Word wo = loadList.GetWordToPractice();
            Console.WriteLine("Translate the following word from [" + loadList.Getlanguge(wo.FromLanguage) + "] to [" + loadList.Getlanguge(wo.ToLanguage) + "] :");

            for (int i = 0; i < wo.Translations.Count(); i++)
            {
                if (i == wo.FromLanguage)
                {
                    Console.WriteLine(wo.Translations[i]);
                }
            }
            String languages = Console.ReadLine();

            for (int i = 0; i < wo.Translations.Count(); i++)
            {
                if (i == wo.ToLanguage)
                {
                    if (languages.ToLower() == wo.Translations[i].ToLower())
                    {

                        return true;
                    }

                }


            }
            return false;

        }
        static void Main(string[] args)
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("1- lists \r\n2- New <list name> <language 1> <language 2> .. <langauge n> \r\n3- add <list name> \r\n4- remove <list name> <language> <word 1> <word 2> .. <word n> \r\n5- words <listname> <sortByLanguage> \r\n6- count <listname> \r\n7- practice <listname> ");
                    Console.WriteLine("Enter a Number:");
                    int userNum = Convert.ToInt32(Console.ReadLine());
                    switch (userNum)
                    {
                        case 1:
                            lists();
                            break;
                        case 2:
                            newList();
                            break;
                        case 3:
                            Console.WriteLine("Enter List name:");
                            String Listname = Console.ReadLine();
                            WordList loadedList = WordList.LoadList(Listname);
                                addWord(loadedList);
                            //if (loadedList.Count() != 0)
                            //{
                            //}
                            break;
                        case 4:
                            Console.WriteLine("Enter List name:");
                            String Listname4 = Console.ReadLine();
                            WordList loadedList4 = WordList.LoadList(Listname4);
                            if (loadedList4.Count() != 0)
                            {
                                Console.WriteLine("Enter the language:");
                                String wordR = Console.ReadLine();
                                Console.WriteLine("Enter the word you want to remove:");
                                String langR = Console.ReadLine();

                                remove(wordR, langR, loadedList4);
                            }
                            break;
                        case 5:
                            Console.WriteLine("Enter List name:");
                            String Listname5 = Console.ReadLine();  
                            WordList loadedListSort = WordList.LoadList(Listname5);
                            Console.WriteLine("Sort by language: ");
                            String Sortby = Console.ReadLine();
                            if (Listname5 == "" || Sortby == "")
                            {
                                Console.WriteLine("Please Enter a List Name and the Sort Language! ");
                            }
                            else
                            {
                                Action<string[]> showTranslationsCallback = (translations) =>
                                {
                                    Console.WriteLine(string.Join(";", translations));
                                };

                                loadedListSort.List(loadedListSort.GetlangugeIndex(Sortby), showTranslationsCallback);
                            }

                            break;
                        case 6:
                            count();
                            break;
                        case 7:
                            Console.WriteLine("Enter List name:");
                            String Listname7 = Console.ReadLine();
                            WordList loadedList7 = WordList.LoadList(Listname7);
                            if (loadedList7.Count() != 0)
                            {
                                Console.WriteLine(practice(loadedList7));
                            }
                            break;
                        default:

                            break;
                    }
                }
                catch (Exception ioex)
                {
                    Console.WriteLine(ioex.Message);
                    Console.WriteLine("Please Enter correct input/information! ");
                }

            }



        }
    }
}