using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public class Vigenere
    {
        //Алфавиты, используются в выборе языка Language
        public string alphabet;
        public string alphabetRUS = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public string alphabetRUS1 = "абвгдежзийклмнопрстуфхцчшщъыьэюя";

        //Шифрование
        public string Vigenerecipher(string text, string word, int lang) //Метод принимает текст для шифрования, ключевое слово и параметр выбора языка
        {
            //Выбор алфавита
            alphabet = Language(lang);
            //Проверка на корректность ввода ключа
            if (CheckKey(word, alphabet) == false || CheckText(text, alphabet) == false)
            {
                return "";
            }
            //Создание массива со смещениями (ключ)
            int[] key = Key(word, alphabet);
            //Перевод текста в нижний регистр
            text = text.ToLower();
            //Строка для записи результата шифрования
            string cihper = "";
            //счётчик элементов в ключе
            int counter = 0;
            //Цикл, который проверит каждую букву в тексте
            for (int i = 0; i < text.Length; i++)
            {
                //Проверка какая буква текста по номеру в алфавите, если такой буквы нет в алфавите, то index будет <0
                int index = alphabet.IndexOf(text[i]);
                //Если буква есть в алфавите, то шифруем, если нет, то просто записываем её в выходной текст
                if (index >= 0)
                {
                    //считаем индекс итоговой буквы со смещением и переходим к следующему идексу для шифрования
                    index = index + key[counter];
                    counter++;
                    //Если индекс получился больше длины алфавита, то вычитаем его длину, т.к. шифрование цикличное, т.е 34 буква это а, т.к 33 - я
                    if (index >= alphabet.Length)
                    {
                        index = index - alphabet.Length;
                    }
                    //Если дошли до конца смещений по ключу, начинаем сначала
                    if (counter == key.Length)
                    {
                        counter = 0;
                    }
                    //Записываем полученную букву алфавита в строку
                    cihper = cihper + alphabet[index];
                }
                else
                {
                    cihper = cihper + text[i];
                }
            }
            return cihper;
        }
        //ДеШифрование
        public string VigenereDEcipher(string text, string word, int lang) //Метод принимает текст для дешифрования, ключевое слово и параметр выбора языка
        {
            //Выбор алфавита
            alphabet = Language(lang);
            //Проверка на корректность ввода ключа
            if (CheckKey(word, alphabet) == false || CheckText(text, alphabet) == false)
            {
                return "";
            }
            //Создание массива со смещениями (ключ)
            int[] key = Key(word, alphabet);
            //Перевод текста в нижний регистр
            text = text.ToLower();
            //Строка для записи результата дешифрования
            string decihper = "";
            //счётчик элементов в ключе
            int counter = 0;
            //Цикл, который проверит каждую букву в тексте
            for (int i = 0; i < text.Length; i++)
            {
                //Проверка какая буква текста по номеру в алфавите, если такой буквы нет в алфавите, то index будет <0
                int index = alphabet.IndexOf(text[i]);
                //Если буква есть в алфавите, то дешифруем, если нет, то просто записываем её в выходной текст
                if (index >= 0)
                {
                    //считаем индекс итоговой буквы со смещением и переходим к следующему идексу для дешифрования
                    index = index - key[counter];
                    counter++;
                    //Если индекс получился меньше 0, то прибавляем длину алфавита, т.к. шифрование цикличное, т.е 0 буква это я, т.к 1 - а
                    if (index < 0)
                    {
                        index = index + alphabet.Length;
                    }
                    //Если дошли до конца смещений по ключу, начинаем сначала
                    if (counter == key.Length)
                    {
                        counter = 0;
                    }
                    //Записываем полученную букву алфавита в строку
                    decihper = decihper + alphabet[index];
                }
                else
                {
                    decihper = decihper + text[i];
                }
            }
            return decihper;
        }
        //Выбор языка
        private string Language(int lang)
        {
            if (lang == 0)
            {
                alphabet = alphabetRUS;
            }
            if (lang == 1)
            {
                alphabet = alphabetRUS1;
            }
            return alphabet;
        }
        //Метод возвращает массив значений смещений (ключ с индексами)
        private int[] Key(string word, string alphabet)
        {
            int[] key = new int[word.Length];
            //Перебираем всё ключевое слово
            for (int i = 0; i < word.Length; i++)
            {
                //Записываем индекс смещения как номер буквы в алфавите, +1, т.к счёт идёт с нуля
                key[i] = alphabet.IndexOf(word[i]) + 1;
            }
            return key;
        }
        //Первичная проверка на корректность ввода ключа
        private bool CheckKey(string word, string alphabet)
        {
            if (word == "")
            {
                MessageBox.Show("Введите ключ");
                return false;
            }
            for (int i = 0; i < word.Length; i++)
            {
                //Если буквы ключа нет в используемом алфавите, то он некорректен
                if (alphabet.IndexOf(word[i]) < 0)
                {
                    MessageBox.Show("Ключ введён некорректно");
                    return false;
                }
            }
            return true;

        }
        private bool CheckText(string text, string alphabet)
        {
            if (text == "")
            {
                MessageBox.Show("Введите сообщение для шифрования");
                return false;
            }
            for (int i = 0; i < text.Length; i++)
            {
                //Если буквы текста нет в используемом алфавите, то он некорректен
                if (alphabet.IndexOf(text[i]) < 0)
                {
                    MessageBox.Show("Текст для шифрования введён некоректно");
                    return false;
                }
            }
            return true;
        }
    }
}
