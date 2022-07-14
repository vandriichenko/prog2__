using System;
using Lab_4;

namespace Lab_5
{
    internal class Program
    {
        /*
         * Рядки: значення рядка, конструктор з параметром, метод обчислення довжини рядка
         * Буквені рядки:
         *      -   конструктор з параметром,
         *      -   метод зсуву рядка праворуч на один символ (тобто останній символ на перше місце),
         *      -   методи отримання даних об’єкту
         * Описати класи, об’єкт похідного класу;
         * вивести рядок; обчислити і вивести довжину
         */
        public static void Main(string[] args)
        {
            LetterCB a = new LetterCB("Привіт, Україна");
            a.shift();
            Console.WriteLine(a);
            Console.WriteLine(a.Length());
        }
    }
}