using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Formaters
{
    class XmlFormat : IFormatable
    {
        public string GetContent()
        {
            return "Contenido en formato Xml";
        }
        public string GetExtension()
        {
            return "Xml";
        }
    }
}
