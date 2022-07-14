using System;
using System.Collections.Generic;

namespace LR4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<General> generals = new List<General>
            {
               new Bold(),
               new Strike(),
               new Italics(),
               new BoldItalics(),
               new Code(),
               new Paragraph(),
               new Table(),
               new H1Token(),
               new H2Token(),
               new H3Token(),
               new H4Token(),
               new H5Token(),
               new H6Token(),
               new Quote(),
               new UnnumberedList(),
               new TableCells(),
               new TableLines()
            };

            Console.WriteLine("Please, enter path to source file.");
            string text = ReadWriteFile.GetLines(args[0]);
            
            foreach (var general in generals)
            {
                text = general.ReplaceMarkDown(text);
            }

            Console.WriteLine("Please, enter path to final file.");
            ReadWriteFile.WriteLines(text, args[1]);
            Console.ReadKey();
        }
    }
}