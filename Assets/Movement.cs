using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
        [SerializeField]
        private float velocity;
        [SerializeField]
        private float distanceToDestroy;
        void Update()
        {
            transform.position += Vector3.right * velocity * Time.deltaTime;
            if (transform.position.x < distanceToDestroy)
            {
                Destroy(gameObject);
            }
        }
    }