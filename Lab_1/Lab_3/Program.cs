using System;

namespace Lab_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Клас інкапсулює двовимірний масив з елементів символьного типу.
            // Створити одновимірний індексатор, що повертає рядок, який
            // складається з усіх елементів однієї з 2-х діагоналей. Створити
            // властивість, що контролює доступ до змінної, яка містить кількість
            // голосних літер у масиві
            var myArray = new MyArray(new char[3, 3] { { 'a', 'b', 'z' }, { 'a', '5', '2' }, { 'b', '+', '#' } });
            Console.WriteLine(myArray[0]);
            Console.WriteLine(myArray[1]);
            Console.WriteLine(myArray.CountVowels);
            myArray.CountVowels = 5;

        }
    }
}