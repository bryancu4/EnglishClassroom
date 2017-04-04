namespace EnglishClassroom.Core
{
    public class Translator
    {
        private readonly ILinguist _linguist;

        public Translator(ILinguist linguist)
        {
            _linguist = linguist;
        }

        public string Translate(string textToTranslate)
        {
            return _linguist.Translate(textToTranslate);
        }
    }
}