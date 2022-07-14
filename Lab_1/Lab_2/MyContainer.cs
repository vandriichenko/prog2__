using System;
using System.Collections.Generic;

namespace Lab_2
{
    public class MyContainer
    {
        private List<MyString> _strings;

        public MyContainer()
        {
            _strings = new List<MyString>();
        }

        public MyContainer add(MyString one)
        {
            _strings.Add(one);
            return this;
        }

        public void Show()
        {
            Console.Out.WriteLine();
            foreach (var str in _strings)
            {
                Console.Out.WriteLine(str);
            }
        }
    }
}