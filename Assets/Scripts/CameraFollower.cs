using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset = new Vector3(0, 5f, -7f);
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = target.transform.position + offset;
    }
}
