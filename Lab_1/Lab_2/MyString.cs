namespace Lab_2
{
    public class MyString
    {
        private string _text;

        public MyString(string text)
        {
            this._text = text;
        }

        public MyString Concat(string text)
        {
            _text = _text + text;
            return this;
        }

        public MyString Replace(string subtext, string on)
        {
            _text = _text.Replace(subtext, on);
            return this;
        }

        public override string ToString()
        {
            return _text.ToString();
        }
    }
}