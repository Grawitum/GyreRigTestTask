using System;
using UnityEngine;

namespace Task2
{
    public class ButtonController
    {
        private UISkreenFactory _skreen;
        private int _speedSpawn;
        private int _speedMove;
        private int _distance;
        private GameObject _cubeSpawner;
        public ButtonController(UISkreenFactory skreen)
        {
            _skreen = skreen;

            skreen.Button.onClick.AddListener(ButtonEvent);
        }

        private void ButtonEvent()
        {
            try
            {
                _speedSpawn = Int32.Parse(_skreen.SpeedSpawn.text);
                _speedMove = Int32.Parse(_skreen.SpeedMove.text);
                _distance = Int32.Parse(_skreen.Distance.text);
                if (_cubeSpawner == null)
                {
                    _cubeSpawner = new GameObject();
                    _cubeSpawner.AddComponent<CubeSpawnerController>();
                }
                _cubeSpawner.GetComponent<CubeSpawnerController>().speedMove = _speedMove;
                _cubeSpawner.GetComponent<CubeSpawnerController>().speedSpawn = _speedSpawn;
                _cubeSpawner.GetComponent<CubeSpawnerController>().distance = _distance;
            }
            catch (FormatException)
            {
                Debug.Log("Введены неверные значения");
            }
        }   
    }
}