using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    public static int lives = 3;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Player") {
            lives--;
            Debug.Log("Lives remaining: " + lives);
            if (lives == 0) {
                Destroy(col.gameObject);
            }
        }
    }
}
