using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Formaters
{
    class YmlFormat : IFormatable
    {
        public string GetContent()
        {
            return "Contenido en formato yml";
        }
        public string GetExtension()
        {
            return "yml";
        }
    }
}
