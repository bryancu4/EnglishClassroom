using System.Linq;

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
    }
}