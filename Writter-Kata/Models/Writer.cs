using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Models
{
    class Writer
    {
        private IFormatable _formater;
        public Writer(IFormatable formater)
        {
            _formater = formater;
        }
        public void Write(string fileName)
        {
            Console.WriteLine($"{fileName}.{_formater.GetExtension()} : {_formater.GetContent()}");
        }
    }
}
