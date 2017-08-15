using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LittleCat
{
    public class CameraBehavior : MonoBehaviour
    {
        private float speed = 5f;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float positionX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
            float positionY = Input.GetAxis("Vertical") * speed;

            transform.SetPositionAndRotation(new Vector3(positionX, positionY, 0), new Quaternion(0, 0, 0, 0));
        }
    }
}