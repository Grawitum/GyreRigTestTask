using UnityEngine;
using UnityEngine.UI;

namespace Task1
{
    public class UISkreenFactory
    {
        private Canvas _canvas;
        private Button _button;
        private Text _text;

        public Canvas Canvas
        {
            get
            {
                if (_canvas == null)
                {
                    var gameObject = Resources.Load<GameObject>("Task1/UI/Canvas");
                    Object.Instantiate(gameObject);
                    _canvas = Object.FindObjectOfType<Canvas>();
                }
                return _canvas;
            }
        }

        public Button Button
        {
            get
            {
                if (_button == null)
                {
                    var gameObject = Resources.Load<Button>("Task1/UI/Button");
                    _button = Object.Instantiate(gameObject, Canvas.transform);
                }

                return _button;
            }
        }

        public Text Text
        {
            get
            {
                if(_text == null)
                {
                    var gameObject = Resources.Load<Text>("Task1/UI/Text");
                    _text = Object.Instantiate(gameObject, Canvas.transform);
                }

                return _text;
            }
        }
    }
}