// BinaryFiles.cs
// Illustrates creating and retrieving from a binary file
using System;
using System.IO;  // Added for File access

namespace BinaryFiles
{
    class BinaryExample
    {
        static void Main(string[] args)
        {
            FileStream filStream;
            BinaryWriter binWriter;
            BinaryReader binReader;

            Console.Write("Enter name of the file: ");
            string fileName = Console.ReadLine();
            if (File.Exists(fileName))
            {
                Console.WriteLine("File - {0} already exists!", fileName);
            }
            else
            {
                filStream = new FileStream(fileName, FileMode.CreateNew);
                binWriter = new BinaryWriter(filStream);
                decimal aValue = 2.16M;
                binWriter.Write("Sample Run");
                for (int i = 0; i < 11; i++)
                {

                    binWriter.Write(i);
                }
                binWriter.Write(aValue);

                binWriter.Close();
                filStream.Close();
                Console.WriteLine("File Created successfully");
            }

            try
            {
                filStream = new FileStream(fileName, FileMode.Open,
                                            FileAccess.Read);
                binReader = new BinaryReader(filStream);

                RetrieveAndDisplayData(binReader);

                binReader.Close();
                filStream.Close();
            }
            catch (IOException exc)
            {
               Console.WriteLine(exc.Message);
            }
            Console.ReadKey();
        }

        public static void RetrieveAndDisplayData(BinaryReader binReader)
        {
            // Read string data from the file
            Console.WriteLine(binReader.ReadString());

            // Read integer data from the file
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(binReader.ReadInt32());
            }

            // Read decimal data from the file
            Console.WriteLine(binReader.ReadDecimal());
        }
    }
}