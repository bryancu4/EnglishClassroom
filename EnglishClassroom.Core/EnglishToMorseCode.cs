using System.Linq;
using System.Text.RegularExpressions;

namespace EnglishClassroom.Core
{
    public class EnglishToMorseCode : MorseCode, ILinguist
    {
        public const string WordSeperator = "   ";
        public const string CodeSeperator = " ";

        public string Translate(string textToTranslate)
        {
            var result = "Invalid Morse Code Or Spacing";

            if (IsValid(textToTranslate))
            {
                result = string.Join(
                    WordSeperator, 
                    textToTranslate.ToLower().Split(' ').Select(w => 
                            string.Join(
                                CodeSeperator, 
                                w.ToCharArray().Select(c => Codex[c]).ToArray())).ToArray());
            }

            return result;
        }

        public bool IsValid(string textToTranslate)
        {
            return !string.IsNullOrEmpty(textToTranslate);
        }

        public bool CanTranslateText(string textToTranslate)
        {
            var result = false;
            if (!string.IsNullOrEmpty(textToTranslate))
            {
                var r = new Regex(@"^[a-zA-Z0-9\.\s]*$");
                result = r.IsMatch(textToTranslate);
            }
            return result;


        }
    }
}