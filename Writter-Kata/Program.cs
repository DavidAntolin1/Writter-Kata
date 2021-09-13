using System;
using Writter_Kata.Enum;
using Writter_Kata.Models;

namespace Writter_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el archivo que desea:");
            string name = Console.ReadLine();
            Console.WriteLine(@"Introduzca el formato en que desea el archivo: 
    1-json
    2-txt
    3-xml
    4-yml");
            int choice;
            FormatType type = new FormatType();
            Int32.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case 1: type = FormatType.json;break;
                case 2: type = FormatType.txt; break;
                case 3: type = FormatType.xml; break;
                case 4: type = FormatType.yml; break;

                default:
                    Console.WriteLine("Formato no válido");
                    break;
            }
            var container = new Container();
            container.Factory.GetWritter(type).Write(name);
        }
    }
}
