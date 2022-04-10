using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace robocop
{
    public class robotNet : MonoBehaviour
    {
        void Start()
        {

        }

        [SerializeField] private float Spead;
        [SerializeField] private float rotationSpeed;

        void Update()
        {

            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            Debug.Log(horizontal);
            Debug.Log(vertical);

            Vector3 runs = new Vector3(horizontal, 0, vertical) * Spead * Time.deltaTime;
            Vector3 mouse = new Vector3(0, mouseX, 0) * rotationSpeed * Time.deltaTime;


            transform.Translate(runs);
            transform.Rotate(mouse);


        }
    }
}
