using UnityEngine;
using UnityEngine.UI;

namespace Task2
{
    public class UISkreenFactory
    {
        private Canvas _canvas;
        private Button _button;
        private Text _speedSpawnText;
        private Text _speedMoveText;
        private Text _distanceText;
        private InputField _speedSpawn;
        private InputField _speedMove;
        private InputField _distance;

        public UISkreenFactory()
        {
            if (_speedSpawn == null)
            {
                var gameObject = Resources.Load<InputField>("Task2/UI/SpeedSpawnInputField");
                _speedSpawn = Object.Instantiate(gameObject, Canvas.transform);
            }

            if (_speedMove == null)
            {
                var gameObject = Resources.Load<InputField>("Task2/UI/SpeedMoveInputField");
                _speedMove = Object.Instantiate(gameObject, Canvas.transform);
            }

            if (_distance == null)
            {
                var gameObject = Resources.Load<InputField>("Task2/UI/DistanceInputField");
                _distance = Object.Instantiate(gameObject, Canvas.transform);
            }

            if (_speedSpawnText == null)
            {
                var gameObject = Resources.Load<Text>("Task2/UI/SpeedSpawnText");
                _speedSpawnText = Object.Instantiate(gameObject, Canvas.transform);
            }

            if (_speedMoveText == null)
            {
                var gameObject = Resources.Load<Text>("Task2/UI/SpeedMoveText");
                _speedMoveText = Object.Instantiate(gameObject, Canvas.transform);
            }

            if (_distanceText == null)
            {
                var gameObject = Resources.Load<Text>("Task2/UI/DistanceText");
                _distanceText = Object.Instantiate(gameObject, Canvas.transform);
            }
        }

        public Canvas Canvas
        {
            get
            {
                if (_canvas == null)
                {
                    var gameObject = Resources.Load<GameObject>("Task2/UI/Canvas");
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
                    var gameObject = Resources.Load<Button>("Task2/UI/CreateButton");
                    _button = Object.Instantiate(gameObject, Canvas.transform);
                }

                return _button;
            }
        }

        public InputField SpeedSpawn
        {
            get
            {
                return _speedSpawn;
            }
        }

        public InputField SpeedMove
        {
            get
            {
                return _speedMove;
            }
        }

        public InputField Distance
        {
            get
            {
                return _distance;
            }
        }


    }
}