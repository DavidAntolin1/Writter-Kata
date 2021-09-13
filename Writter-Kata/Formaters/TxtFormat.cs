using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Formaters
{
    class TxtFormat : IFormatable
    {
        public string GetContent()
        {
            return "Contenido en formato txt";
        }
        public string GetExtension()
        {
            return "txt";
        }
    }
}
