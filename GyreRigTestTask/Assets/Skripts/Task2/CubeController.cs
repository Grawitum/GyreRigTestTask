using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task2
{
    public class CubeController : MonoBehaviour, IMove
    {
        public int speed;
        public int moveDistance;
        private Vector3 _point;
        void Start()
        {
            _point = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z + moveDistance);
        }

        public void Move(float fixedDeltaTime)
        {

            this.gameObject.transform.position += Vector3.forward * speed;
            if (this.gameObject.transform.position == _point)
            {
                //Debug.Log("1");
                Destroy(gameObject);
            }
        }
    }
}
