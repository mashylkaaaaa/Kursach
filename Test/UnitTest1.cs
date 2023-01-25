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
            string key = "������";
            string word = "�����";
            string expected = "�����";
            string actual = V.Vigenerecipher(word, key, 1);

            Assert.Pass(actual, expected);
        }

        [Test]
        public void Test2()
        {
            string key = "��������";
            string word = "������ ������ �� ������";
            string expected = "������ ������ �� ������";
            string actual = V.Vigenerecipher(word, key, 0);

            Assert.Pass(actual, expected);
        }

        [Test]
        public void Test3()
        {
            string key = "��������";
            string word = "����� ����� � ������� ����� ����� � �������";
            string expected = "����� ����� � �������";
            string actual = V.Vigenerecipher(word, key, 1);

            Assert.Pass(actual, expected);
        }

        [Test]
        public void Test4()
        {
            string key = "��";
            string word = "�����������������������������������";
            string expected = "�����������������������������������";
            string actual = V.Vigenerecipher(word, key, 1);

            Assert.Pass(actual, expected);
        }
    }
}