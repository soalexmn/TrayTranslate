using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Models;

namespace Core.Tests
{
    [TestClass]
    public class TranslationTests
    {
        [TestMethod]
        public void BaseTranslateGetFirst()
        {
            Translation translation = new Translation();
            var mostFrequencyVariant = new TranslationVariant { Text = "One", Frequency = 1 };
            translation.Translations.Add(new TranslationVariant { Text = "Two", Frequency = 0.1f });
            translation.Translations.Add(new TranslationVariant { Text = "Three", Frequency = 0.4f });
            translation.Translations.Add(mostFrequencyVariant);
            translation.Translations.Add(new TranslationVariant { Text = "Two", Frequency = 0.1f });


            var baseTranslate = translation.BaseTranslate();

            Assert.ReferenceEquals(mostFrequencyVariant, baseTranslate);
        }
    }
}
