using System.Collections.Generic;
using System.Linq;

namespace EnglishClassroom.Core
{
    public class Translator
    {
        private readonly List<ILinguist> _linguists;

        public Translator(List<ILinguist> linguists)
        {
            _linguists = linguists;
        }

        public string Translate(string textToTranslate)
        {
            var result = "Sorry, don't know this language";

            var linguist = _linguists.FirstOrDefault(l => l.CanTranslateText(textToTranslate));
            if(linguist != null)
            {
                result = linguist.Translate(textToTranslate);
            }

            return result;
        }
    }
}