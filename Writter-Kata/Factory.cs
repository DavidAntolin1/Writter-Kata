using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Enum;
using Writter_Kata.Interfaces;
using Writter_Kata.Models;

namespace Writter_Kata
{
    class Factory
    {
        private readonly Dictionary<FormatType, IFormatable> _formatList;
        public Factory(Dictionary<FormatType, IFormatable> formatList)
        {
            _formatList = formatList;
        }

        public Writer GetWritter(FormatType formater)
        {
            return new Writer(_formatList[formater]);
        }
    }
}
