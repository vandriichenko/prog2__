using System;

namespace Lab_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Створення змінних, конвертація
                int A, B;
                Console.Write("Enter 1 value: ");
                A = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter 2 value: ");
                B = Convert.ToInt32(Console.ReadLine());
                // Стрічки для створення двійкового коду
                string AS, BS;
                AS = BS = "";
                // Ділимо по 2 і створюємо обернений двійковий код
                do
                {
                    if (A % 2 == 0)
                    {
                        AS += '0';
                    }
                    else
                    {
                        AS += '1';
                    }
                    A = A / 2;
                } while (A > 0);
                // Обертаємо стрічку
                char[] AT = AS.ToCharArray();
                Array.Reverse(AT);
                AS = new string(AT);
                // Ділимо по 2 і створюємо обернений двійковий код
                do
                {
                    if (B % 2 == 0)
                    {
                        BS += '0';
                    }
                    else
                    {
                        BS += '1';
                    }
                    B = B / 2;
                } while (B > 0);
                // Обертаємо стрічку
                char[] BT = BS.ToCharArray();
                Array.Reverse(BT);
                BS = new string(BT);
                // Створюємо змінну результат для виконання 2 завдання
                string Result = "";
                Task2(ref Result, AS, BS);
                Console.WriteLine(Result);
            }
            catch
            {

            }
        }

        static void Task2(ref string Result, string A, string B)
        {
            Result = "A = B";
            if (A.Length == B.Length)
            {
                // Перевіряємо на старший біт
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] > B[i])
                    {
                        Result = "A > B";
                    }
                    else if (A[i] < B[i])
                    {
                        Result = "A < B";
                    }
                }
            }
            if (A.Length > B.Length)
            {
                for (int i = 0; i < A.Length - B.Length; i++)
                {
                    // Перевіряємо на старший біт
                    if (A[i] == '1')
                    {
                        Result = "A > B";
                    }
                }
                if (Result != "A > B")
                {
                    // Перевіряємо на старший біт
                    for (int i = A.Length - B.Length; i < A.Length; i++)
                    {
                        if (A[i] > B[i])
                        {
                            Result = "A > B";
                        }
                        else if (A[i] < B[i])
                        {
                            Result = "A < B";
                        }
                    }
                }
            }
            if (B.Length > A.Length)
            {
                for (int i = 0; i < B.Length - A.Length; i++)
                {
                    // Перевіряємо на старший біт
                    if (B[i] == '1')
                    {
                        Result = "A < B";
                    }
                }
                if (Result != "A < B")
                {
                    // Перевіряємо на старший біт
                    for (int i = B.Length - A.Length; i < B.Length; i++)
                    {
                        if (A[i] > B[i])
                        {
                            Result = "A > B";
                        }
                        else if (A[i] < B[i])
                        {
                            Result = "A < B";
                        }
                    }
                }
            }
        }
    }
}

