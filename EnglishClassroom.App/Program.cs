using EnglishClassroom.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishClassroom.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("English Classroom");
            Console.WriteLine("Morse code to English text and English text to Morse code.");
            Console.WriteLine();

            var translator = new Translator(new List<ILinguist> {
                new EnglishToMorseCode(),
                new MorseCodeToEnglish() });

            var exit = false;
            while (!exit)
            {
                Console.WriteLine("Enter either Morse Code or English");

                var textToTranslate = Console.ReadLine();
                if (textToTranslate.Equals("-q", StringComparison.InvariantCultureIgnoreCase))
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine(translator.Translate(textToTranslate));
                    Console.WriteLine();
                }
            }
        }
    }
}
