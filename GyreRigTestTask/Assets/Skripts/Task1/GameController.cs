using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task1
{
    public class GameController : MonoBehaviour
    {
        private Factory _factory;
        // Start is called before the first frame update
        void Awake()
        {
            _factory = new Factory();
        }
    }
}
