namespace EnglishClassroom.Core
{
    public interface ILinguist
    {
        string Translate(string textToTranslate);
        bool IsValid(string textToTranslate);
        bool CanTranslateText(string textToTranslate);
    }
}