using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public static float speed;


    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * speed;

        if(transform.position.x < -4)
        {
            transform.position = new Vector3(4, Random.Range(-2f,2f), 0);
        }
    }
}
