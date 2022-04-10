using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace robocop
{
    public class Coyns : MonoBehaviour
    {
        private Transform _playerTransform; 
        void Start()
        {
            _playerTransform = FindObjectOfType<robotNet>().gameObject.transform;
        }

         void Update()
        {
            float distanse = Vector3.Distance( _playerTransform.position, transform.position);
            Debug.Log(distanse + "distanse");

            if(distanse < 2f)
            {
                FindObjectOfType<CoinCounter>().Counter += 1;
                Destroy(gameObject);
               
            }
          
        }
    }

}