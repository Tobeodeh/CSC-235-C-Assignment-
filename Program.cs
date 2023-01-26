using System;

namespace Duplicatefilenamecheck
{
    class Folder
    {
        public string[] fileNames;
        public int[] fileIds;
        public int[] newIds;
        public string[] newNames;



        public void array(int size)
        {
            //The array method instantiates the array object and assigns its length based on the inputted agrument
            fileNames = new string[size];
            fileIds = new int[size];
            newIds = new int[size];
            newNames = new string[size];
        }


        public string fileLetters;
        public string fileId;
        char ch;
        public void Split(string filename)
        {
            //The split method checks if the element in the arguments are either characters or integer and store each different types in different string based on the 
            fileLetters = "";
            fileId = "";
            for (int i = 0; i < filename.Length; i++)
            {
                ch = filename[i];
                if (Char.IsLetter(ch))
                {
                    fileLetters += ch;
                }
                else if (Char.IsDigit(ch))
                {
                    fileId += ch;
                }
            }
        }


        public int Ids;
        public void store(int i)
        //stores the fileids into an integer array
        {
            fileNames[i] = fileLetters;

            Ids = int.Parse(fileId);

            fileIds[i] = Ids;
        }


        public int existing_file;
        public void duplicate(int numberOfFiles)
        {   //This method checks for each 
            for (int i = 0; i < numberOfFiles; i++)
            {
                for (int j = 0; j < numberOfFiles; j++)
                {

                    if (String.Equals(newNames[j], fileNames[i]))
                    {
                        existing_file = j;
                        break;
                    }
                    else
                    {
                        existing_file = -1;
                    }

                }

                if (existing_file == -1)
                {
                    newNames[i] = String.Copy(fileNames[i]);
                    newIds[i] = fileIds[i];
                }
                else
                {
                    if (newIds[existing_file] <= fileIds[i])
                    {
                        newNames[i] = String.Copy(fileNames[i]);
                        newIds[i] = -1;
                    }
                    else
                    {
                        newNames[i] = String.Copy(fileNames[i]);
                        newIds[existing_file] = fileIds[i];
                        newIds[i] = -1;
                    }

                }

            }
            Array.Sort(newIds);
            foreach (int id in newIds)
            {
                if (id != -1)
                {
                    Console.Write("{0}\t", id);
                }
            }

            Console.WriteLine();

        }


    }

    class RunProgram
    {
        public static int testcases;
        public static int no_files;
        public static string file;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of testcases:\t\n");
            testcases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testcases; i++)
            {
                Console.WriteLine("Enter number of files:\t\n");
                no_files = int.Parse(Console.ReadLine());
                Folder Read = new Folder();
                Read.array(no_files);


                for (int k = 0; k < no_files; k++)
                {
                    Console.WriteLine("Enter file :\t\n");
                    file = Console.ReadLine();
                    Read.Split(file);
                    Read.store(k);

                }

                Read.duplicate(no_files);
            }
        }
    }
}
