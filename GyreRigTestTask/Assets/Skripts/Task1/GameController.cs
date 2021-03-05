using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task1
{
    public class GameController : MonoBehaviour
    {
        private Factory _factory;
        void Awake()
        {
            _factory = new Factory();
        }
    }
}
