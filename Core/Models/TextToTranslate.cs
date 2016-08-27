using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class TextToTranslate
    {
        public string Text { get; set; }
        /// <summary>
        /// If language not defined, property null or empty string
        /// </summary>
        public string Language { get; set; }
    }
}
