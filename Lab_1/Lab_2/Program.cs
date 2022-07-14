using System;

namespace Lab_2
{
    internal class Program
    {
        /* Клас-рядок, який містить методи, необхідні для роботи методів класу-контейнера.
           Клас-контейнер, який є абстракцією тексту та складається з 
            об’єктів класу-рядка та 
            методів додавання рядка до тексту, 
            видалення рядка з тексту, 
            заміни вказаного рядка заданим рядком, 
            очищення тексту, повернення кількості рядків, 
            повернення рядка з символів-цифр, що трапляються в тексті */
        public static void Main(string[] args)
        {
            var myString01 = new MyString("Hello");
            Console.Out.Write("Рядок: " +
                              myString01
                                  .Concat(", World")
                              );

            var myString02 = new MyString("Hello");

            Console.Out.Write("Рядок: " +
                              myString02
                                  .Concat(", World")
                                  .Replace("World", "Ukraine")
                              );

            var container = new MyContainer()
                .add(myString01)
                .add(myString02);
            container.Show();

        }
    }
}

