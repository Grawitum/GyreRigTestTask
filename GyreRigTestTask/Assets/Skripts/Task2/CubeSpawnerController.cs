using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task2
{
    public class CubeSpawnerController : MonoBehaviour
    {
        [HideInInspector] public int speedSpawn;
        [HideInInspector] public int speedMove;
        [HideInInspector] public int distance;

        void Start()
        {
            CubeCreate();
        }

        private void CubeCreate()
        {
            var gameObject = Resources.Load<GameObject>("Task2/Cube");
            gameObject.GetComponent<CubeController>().speed = speedMove;
            gameObject.GetComponent<CubeController>().moveDistance = distance;
            Instantiate(gameObject);
            StartCoroutine(Wait());
        }



        IEnumerator Wait()
        {
            yield return new WaitForSeconds(speedSpawn);
            CubeCreate();
            StopCoroutine(Wait());
        }
    }
}
