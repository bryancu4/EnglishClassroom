using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace EnglishClassroom.Core
{
    public class MorseCodeToEnglish : MorseCode, ILinguist
    {
        public string Translate(string textToTranslate)
        {
            var result = "Invalid Morse Code Or Spacing";

            if (IsValid(textToTranslate))
            {
                result = string.Join(" ", textToTranslate.Split(new[] { "   " }, StringSplitOptions.None)
                    .Select(w => string.Concat(w.Split(' ').Select(c => Codex.FirstOrDefault(x => x.Value.Equals(c)).Key).ToArray()).Replace("\0", string.Empty))
                    .ToArray());
            }

            return result;
        }

        public bool IsValid(string textToTranslate)
        {
            var result = true;

            var r = new Regex(@"(\s +)", RegexOptions.IgnoreCase);
            Match m = r.Match(textToTranslate);
            if (m.Success)
            {
                result = !m.Groups.Cast<Group>().Any(g => g.Length % 3 != 0);
            }

            return result;
        }
    }
}