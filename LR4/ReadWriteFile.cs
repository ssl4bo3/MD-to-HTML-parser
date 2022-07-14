using System;
using System.IO;

namespace LR4
{
    public class ReadWriteFile
    {
        public static string GetLines(string sourcePath)
        {
            
            if (File.Exists(sourcePath))
            {
                string text = string.Empty;
                foreach (var line in File.ReadAllLines(sourcePath))
                {
                    text += line + "\n";
                }
                return text;
            }
            else
            {
                throw new Exception("File not found");
            }
        }

        public static void WriteLines(string text, string finalPath)
        {

                if (!File.Exists(Console.ReadLine()))
                {
                    using var file = File.Create(finalPath);
                }
                else
                {
                    throw new Exception("Chose another file name");
                }
            File.AppendAllText(finalPath, text);
        }
    }
}