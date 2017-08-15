using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LittleCat
{
    public class CatTouch : MonoBehaviour
    {

        public Transform newFood;
        // Use this for initialization
        void Start()
        {


        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Transform food = Instantiate(newFood, transform.position, transform.rotation);

                Vector3 fwd = transform.TransformDirection(Vector3.forward);

                food.GetComponent<Rigidbody>().AddForce(500* fwd);
            }
        }
    }
}