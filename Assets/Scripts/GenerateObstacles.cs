using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour
{
    public  GameObject[] obstacles;
    public  Material[] materials;
    public int obstaclesNumber;

    private  GameObject[] generatedObstacles;

    void Start()
    {
        generatedObstacles = new GameObject[obstaclesNumber];
        for (int i = 0; i < obstaclesNumber; i++) {
            Vector3 pos = new Vector3(Random.Range(-50.0f, 50.0f), 2f, Random.Range(-50f, 50f));
            Debug.Log(Random.Range(0, obstacles.Length));
            generatedObstacles[i] = Instantiate(obstacles[Random.Range(0, obstacles.Length)], pos, Quaternion.identity);
            generatedObstacles[i].GetComponent<Renderer>().material = materials[Random.Range(0, materials.Length)];
        }
    }

    void Update()
    {
        
    }
}
