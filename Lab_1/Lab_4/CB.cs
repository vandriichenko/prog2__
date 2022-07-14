namespace Lab_4
{
    public class CB
    {
        public string _text { get; set; }
        // конструктор за умовчанням
        public CB()
        {

        }

        // конструктор з параметрами
        public CB(string text)
        {
            _text = text;
        }

        // конструктор копіювання
        public CB(CB cb)
        {
            _text = cb._text;
        }

        // метод обчислення довжини рядка
        public int Length()
        {
            return _text.Length;
        }

        // методи отримання даних рядка
        public override string ToString()
        {
            return _text;
        }

        // перевантаження оператора +
        public static CB operator +(CB a, CB b)
        {
            return new CB(a._text + b._text);
        }

        // перевантаження оператора *
        public static CB operator *(CB a, int count)
        {
            var text = "";
            for (int i = count; i > 0; i--)
            {
                text = text + a._text;
            }
            return new CB(text);
        }

    }
}