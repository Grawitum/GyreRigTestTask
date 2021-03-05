using UnityEngine.UI;

namespace Task1
{
    public class ButtonController
    {
        private Text _text;
        private Counter _counter;
        public ButtonController(UISkreenFactory skreen)
        {
            _text = skreen.Text;

            skreen.Button.onClick.AddListener(ButtonEvent);
        }

        private void ButtonEvent()
        {
            if(_counter == null)
            {
                _counter = new Counter(_text);
            }
            _counter.Act();
        }
    }
}