using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // используйте цикл foreach для вывода каждого элемента списка на экран




            //List<int> numbers = new List<int> { 1, 2, 3, 4};

            //// проверка списка на пустоту
            //if (numbers.Count == 0)
            //{
            //    // вывод результата
            //    Console.WriteLine("Список пустой.");
            //}
            //else
            //{
            //    Console.WriteLine("числа списка: ");
            //    // перебор всех значений списка для вывода в консоль 
            //    foreach (int num in numbers)
            //    {
            //        // вывод результата
            //        Console.Write(num + " ");
            //    }
            //}





            // Используйте цикл foreach для перебора символов в строке и вывода каждого символа на экран.





            // иницилизация переменной 
            //string str = "abcdef";

            //// перебор строки
            //foreach (var letter in str)
            //{
            //    // вывод результата
            //    Console.WriteLine(letter);
            //}





            // найдите количество слов в строке





            //Console.Write("Введите строку: ");
            ////ввод строки через консоль
            //string inputSentence = Console.ReadLine();
            //// счетчик слов
            //int counterWords = 0;

            //// проверка на пустоту или null значение
            //if (string.IsNullOrEmpty(inputSentence))
            //{
            //    Console.WriteLine("Строка пуста или равна null.");
            //}
            //else
            //{
            //    // Удаляем все знаки препинания, заменяя их на пробел.
            //    string cleanedSentence = Regex.Replace(inputSentence, @"[^\w\s]+", " ").Trim();
            //    // разделение слов через пробел
            //    string[] inputWords = cleanedSentence.Split(new[] { ' ' });

            //    // перебор слов
            //    foreach (var word in inputWords)
            //    {
            //        counterWords++;
            //    }

            //    Console.WriteLine(counterWords);
            //}




            // Подсчет количества гласных в строке. Введите с консоли любое слово и через foreach найдите количество гласных букв





            // массив с гласными буквами русского языка
            //char[] vowelLetters = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };

            //Console.Write("Введите слово на русском языке: ");
            //// ввод слова от пользователя
            //string inputSentence = Console.ReadLine();

            //// Разделяем строку по пробелам и берем первое слово
            //string inputWord = inputSentence.Split(' ')[0].ToLower();

            //// счетчик гласных в слове
            //int vowelCounter = 0;

            //foreach (var letter in inputWord)
            //{
            //    // проверка буквы гланая ли она 
            //    if (vowelLetters.Contains(letter))
            //    {
            //        vowelCounter++;
            //    }
            //}

            //// вывод результата
            //Console.WriteLine($"В слове '{inputWord}' {vowelCounter} гласных букв.");





            // Вывод элементов списка





            //// создание списка
            //List<string> sentences = new List<string>();
            //// переменная для ввода данных через консоль
            //string inputString = "";

            //AddStringsToList(sentences, ref inputString);

            //Console.WriteLine("Введенные предложения:");
            //foreach (string sentence in sentences)
            //{
            //    Console.WriteLine(sentence);
            //}






            // Подсчет длины строк в списке





            ////создание списка
            //List<string> sentences = new List<string>();
            //// сумма длин слов
            //int totalWordLengthSum = 0;
            //// флаг для цикла
            //bool isOpen = true;
            ////
            //string inputString = "";

            //// цикл для нескольких повторений, если произодет ошибка
            //while (isOpen)
            //{
            //    Console.WriteLine("Варианты действий:");
            //    Console.WriteLine("1: Добавить слова в список");
            //    Console.WriteLine("2: Выйти и подсчитать длину");
            //    Console.Write("Ваш выбор: ");
            //    if (int.TryParse(Console.ReadLine(), out int actionNumber))
            //    {
            //        switch (actionNumber)
            //        {
            //            case 1:
            //                AddWordsToList(sentences, ref inputString);
            //                break;
            //            case 2:
            //                isOpen = false;
            //                break;
            //            default:
            //                Console.WriteLine("Пожалуйста, введите корректное число (1 или 2).");
            //                break;
            //        }
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ошибка: Введите числовое значение.");
            //    }
            //}

            //// цикл для подсчета символов в предложении
            //foreach (var word in sentences)
            //{
            //    totalWordLengthSum += word.Length;
            //}

            //Console.WriteLine($"Длина слов в введенной строке: {totalWordLengthSum}");
            //Console.WriteLine("Сама строка: " + inputString);




            // Поиск максимального числа в списке





            //// создание списка
            //List<int> numbers = new List<int> { 1, 2, 3, 4 };
            //// максимальное число в списке
            //int maxValueInNumbers = int.MinValue;

            //// проверка списка на пустоту
            //if (numbers.Count == 0)
            //{
            //    // вывод результата
            //    Console.WriteLine("Список пустой.");
            //    isOut = false;
            //}
            //else
            //{
            //    foreach (int num in numbers)
            //    {
            //        maxValueInNumbers = Math.Max(maxValueInNumbers, num);
            //    }
            //    Console.WriteLine("Максимальное число в спике: " + maxValueInNumbers);
            //}





            // Преобразование всех элементов в строку





            //// создание списка
            //List<int> numbers = new List<int> { 1, 2, 3, 4 };
            //string numbersInString = "";

            //// проверка списка на пустоту
            //if (numbers.Count == 0)
            //{
            //    // вывод результата
            //    Console.WriteLine("Список пустой.");
            //}
            //else
            //{
            //    foreach (int num in numbers)
            //    {
            //        numbersInString += Convert.ToString(num);
            //    }

            //    Console.WriteLine(numbersInString + " тип: " + numbersInString.GetType());
            //}



            // Удаление элементов по условию




            ////создание списка
            //List<int> numbers = new List<int>();
            //// новый список с элементами меньше 10
            //List<int> newNumbers = new List<int>();
            //// сумма длин слов
            //int totalWordLengthSum = 0;
            //// флаг для цикла
            //bool isOpen = true;

            //// цикл для нескольких повторений, если произодет ошибка
            //while (isOpen)
            //{
            //    Console.WriteLine("Варианты действий:");
            //    Console.WriteLine("1: Добавить число в список");
            //    Console.WriteLine("2: Выйти и подсчитать длину");
            //    Console.Write("Ваш выбор: ");
            //    if (int.TryParse(Console.ReadLine(), out int actionNumber))
            //    {
            //        switch (actionNumber)
            //        {
            //            case 1:
            //                AddNumberToList(numbers);
            //                break;
            //            case 2:
            //                isOpen = false;
            //                break;
            //            default:
            //                Console.WriteLine("Пожалуйста, введите корректное число (1 или 2).");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ошибка: Введите числовое значение.");
            //    }
            //}

            //PrintElementsLessThanTen(numbers, ref newNumbers);

            //if (newNumbers.Count == 0)
            //{
            //    Console.WriteLine("Список пустой");
            //}
            //else
            //{
            //    Console.WriteLine("элеметы нового списка: ");
            //    // вывод на экран элементы нового списка
            //    foreach (int num in newNumbers)
            //    {
            //        Console.Write(num + " ");
            //    }
            //}
        }

        // методы 


        // Вывод элементов списка

        //public static void AddStringsToList(List<string> sentences, ref string inputLine)
        //{
        //    Console.WriteLine("Введите предложения, разделите предожения (. ! ?) знаками:");
        //    inputLine = Console.ReadLine();

        //    if (!string.IsNullOrWhiteSpace(inputLine))  // Проверка на пустой ввод
        //    {
        //        string[] inputSentences = inputLine.Split(new[] {'.', '!', '?'});

        //        foreach (string sentence in inputSentences)
        //        {
        //            string trimmedSentence = sentence.Trim(); // Удаляем пробелы в начале и конце

        //            if (!string.IsNullOrWhiteSpace(trimmedSentence)) // Проверяем, что предложение не пустое
        //            {
        //                sentences.Add(trimmedSentence);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ввод не содержит слов."); // при пустой строке
        //    }
        //}

        // Подсчет длины строк в списке

        //static void AddWordsToList(List<string> sentences, ref string inputLine)
        //{
        //    Console.WriteLine("Введите слово/слова, разделенные пробелом:");
        //    inputLine = Console.ReadLine();

        //    if (!string.IsNullOrWhiteSpace(inputLine))  // Проверка на пустой ввод
        //    {

        //        string[] inputWords = inputLine.Split(new[] {' '}); 
        //        foreach (string word in inputWords)
        //        {
        //            sentences.Add(word); //  Проверка на пустоту уже сделана с Split
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ввод не содержит слов."); // вывод при нулейвой строке
        //    }
        //}

        // Удаление элементов по условию

        //public static void AddNumberToList(List<int> numbers)
        //{
        //    Console.WriteLine("Введите число: ");
        //    int inputNumber = Convert.ToInt32(Console.ReadLine());
        //    numbers.Add(inputNumber);
        //}

        //public static void PrintElementsLessThanTen(List<int> numbers, ref List<int> NewNumbers)
        //{
        //    if (numbers.Count == 0)
        //    {
        //        Console.WriteLine("Список пустой");
        //    }
        //    else
        //    {
        //        foreach (int num in numbers)
        //        {
        //            if (num < 10)
        //            {
        //                NewNumbers.Add(num);
        //            }
        //        }
        //    }
        //}
    }
}
