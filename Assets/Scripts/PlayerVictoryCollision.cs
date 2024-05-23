using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVictoryCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Player") {
            Debug.Log("WON!");
            Destroy(col.gameObject);
        }
    }
}
