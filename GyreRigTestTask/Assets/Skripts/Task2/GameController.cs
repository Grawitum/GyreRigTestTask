using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task2
{
    public class GameController : MonoBehaviour
    {
        private Factory _factory;
        // Start is called before the first frame update
        void Awake()
        {
            _factory = new Factory();
        }

        private void FixedUpdate()
        {
            var fixedDeltaTime = Time.fixedDeltaTime;
            var cubes = Object.FindObjectsOfType<CubeController>();
            for (var i = 0; i < cubes.Length; i++)
            {
                if (cubes[i] is IMove cube)
                {
                    cube.Move(fixedDeltaTime);
                }
            }
        }
    }
}
