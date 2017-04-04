﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnglishClassroom.Core.Tests
{
    [TestClass]
    public class TranslatorTests
    {
        [TestMethod]
        public void MorseCodeToEnglish()
        {
            var expected = "the wizard quickly jinxed the gnomes before they vaporized.";
            var textToTranslate = "- .... .   .-- .. --.. .- .-. -..   --.- ..- .. -.-. -.- .-.. -.--   .--- .. -. -..- . -..   - .... .   --. -. --- -- . ...   -... . ..-. --- .-. .   - .... . -.--   ...- .- .--. --- .-. .. --.. . -.. .-.-.-";
            var translator = new Translator(new MorseCodeToEnglish());

            var result = translator.Translate(textToTranslate);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MorseCodeWith6SpacesToEnglish()
        {
            var expected = "the  wizard quickly jinxed the gnomes before they vaporized.";
            var textToTranslate = "- .... .      .-- .. --.. .- .-. -..   --.- ..- .. -.-. -.- .-.. -.--   .--- .. -. -..- . -..   - .... .   --. -. --- -- . ...   -... . ..-. --- .-. .   - .... . -.--   ...- .- .--. --- .-. .. --.. . -.. .-.-.-";
            var translator = new Translator(new MorseCodeToEnglish());

            var result = translator.Translate(textToTranslate);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EnglishToMorseCodeWithInvalidTextToTranslateInput()
        {
            var expected = "Invalid Morse Code Or Spacing";
            var textToTranslate = "";
            var translator = new Translator(new EnglishToMorseCode());

            var result = translator.Translate(textToTranslate);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EnglishToMorseCode()
        {
            var expected = "- .... .   .-- .. --.. .- .-. -..   --.- ..- .. -.-. -.- .-.. -.--   .--- .. -. -..- . -..   - .... .   --. -. --- -- . ...   -... . ..-. --- .-. .   - .... . -.--   ...- .- .--. --- .-. .. --.. . -.. .-.-.-";
            var textToTranslate = "The wizard quickly jinxed the gnomes before they vaporized.";
            var translator = new Translator(new EnglishToMorseCode());

            var result = translator.Translate(textToTranslate);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EnglishWith2SpacesToMorseCode()
        {
            var expected = "- .... .      .-- .. --.. .- .-. -..   --.- ..- .. -.-. -.- .-.. -.--   .--- .. -. -..- . -..   - .... .   --. -. --- -- . ...   -... . ..-. --- .-. .   - .... . -.--   ...- .- .--. --- .-. .. --.. . -.. .-.-.-";
            var textToTranslate = "The  wizard quickly jinxed the gnomes before they vaporized.";
            var translator = new Translator(new EnglishToMorseCode());

            var result = translator.Translate(textToTranslate);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MorseCodeToEnglishWithInvalidTextToTranslateInput()
        {
            var expected = "Invalid Morse Code Or Spacing";
            var textToTranslate = "..- .... ..-. .-.. --- .-    ...-";
            var translator = new Translator(new MorseCodeToEnglish());

            var result = translator.Translate(textToTranslate);

            Assert.AreEqual(expected, result);
        }
    }
}
