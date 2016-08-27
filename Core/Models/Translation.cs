using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Translation
    {
        public TextToTranslate ToTranslate { get; set; }
        public List<TranslationVariant> Translations { get; set; }
        public string TargetLanguage { get; set; }

        public TranslationVariant BaseTranslate()
        {
            return Translations.OrderByDescending(t => t.Frequency).First();
        }
    }
}
