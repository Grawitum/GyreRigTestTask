using UnityEngine.UI;

namespace Task1
{
    public class Counter
    {
        private int _click = 0;
        private Text _text;

        public Counter(Text text)
        {
            _text = text;
        }

        public void Act()
        {
            _click++;
            _text.text = $"Вынажали {_click} раз";
        }
    }
}