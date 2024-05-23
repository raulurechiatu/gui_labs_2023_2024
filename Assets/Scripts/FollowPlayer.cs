using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 distance = new Vector3(0, 3.8f, -5.8f);

    private bool firstPerson = false;

    void Start()
    {
        firstPerson = PlayerPrefs.GetInt("firstPerson") == 1;
    }

    void Update()
    {
        Vector3 tmpDist = new Vector3(0, 5, 0.5f);
        transform.rotation = Quaternion.Euler(0, 0, 0);
        if (!firstPerson) {
            tmpDist = new Vector3(distance.x, distance.y, distance.z);
            transform.rotation = Quaternion.Euler(25, 0, 0);
        }

        if (Input.GetKeyDown("b")) {
            firstPerson = !firstPerson;
            PlayerPrefs.SetInt("firstPerson", firstPerson ? 1 : 0);
        }

        if (player) {
            transform.position = player.transform.position + tmpDist;
            
            // transform.LookAt(player.transform);
            // transform.Translate(Vector3.right * Time.deltaTime);

            // transform.LookAt(player.transform);
            // transform.RotateAround(player.transform.position, Time.deltaTime);
        }
    }
}
