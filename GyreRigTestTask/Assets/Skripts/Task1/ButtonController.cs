using UnityEngine.UI;

namespace Task1
{
    public class ButtonController
    {
        private int _click = 0;
        private Text _text;
        public ButtonController(UISkreenFactory skreen)
        {
            _text = skreen.Text;

            skreen.Button.onClick.AddListener(ButtonEvent);
        }

        private void ButtonEvent()
        {
            _click++;
            _text.text = $"Вынажали {_click} раз";
        }
    }
}