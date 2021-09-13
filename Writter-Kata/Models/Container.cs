using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Enum;
using Writter_Kata.Formaters;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Models
{
    class Container
    {
        public Dictionary<FormatType, IFormatable> FormatList = new Dictionary<FormatType, IFormatable> 
        {
            {FormatType.json, new JsonFormat() },
            {FormatType.txt, new TxtFormat() },
            {FormatType.xml, new XmlFormat() },
            {FormatType.yml, new YmlFormat() }
        };
        public Factory Factory;
        public Container()
        {
            Factory = new Factory(FormatList);
        }
    }
}
