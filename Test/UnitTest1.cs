using NUnit.Framework;
using Kursach;
using System.Collections.Generic;

namespace Test
{
    public class Tests
    {
        
        Vigenere V = new Vigenere();
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            string key = "€блоко";
            string word = "волна";
            string expected = "вршэл";
            string actual = V.Vigenerecipher(word, key, 1);

            Assert.Pass(actual, expected);
        }

        [Test]
        public void Test2()
        {
            string key = "цветочек";
            string word = "облако похоже на €блоко";
            string expected = "Єдсуъж хъмсмш эш емгсрв";
            string actual = V.Vigenerecipher(word, key, 0);

            Assert.Pass(actual, expected);
        }

        [Test]
        public void Test3()
        {
            string key = "курсова€";
            string word = "будет сдана в четверг мзхчв феащф у йфхгеьч";
            string expected = "будет сдана в четверг";
            string actual = V.Vigenerecipher(word, key, 1);

            Assert.Pass(actual, expected);
        }

        [Test]
        public void Test4()
        {
            string key = "€д";
            string word = "пхежыцопоснугуресцмутхичерьцтжугщнй";
            string expected = "превысокомногорассмотрительствующий";
            string actual = V.Vigenerecipher(word, key, 1);

            Assert.Pass(actual, expected);
        }
    }
}