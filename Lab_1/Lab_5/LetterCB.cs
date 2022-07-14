using Lab_4;

namespace Lab_5
{
    public class LetterCB : CB
    {
        public LetterCB(string text) : base(text)
        {
        }

        public LetterCB shift()
        {
            _text = _text[_text.Length - 1] + _text.Substring(1, _text.Length - 2);
            return this;
        }
    }
}