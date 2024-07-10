using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RoverController : MonoBehaviour
{
    public float speed = 5f; // Speed of the rover
    //public Transform spawnArea;
    public float x;
    public float y;
    public float z;
    void Start() {
        transform.position = new Vector3(x, y, z);
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
        transform.position += movement * speed * Time.deltaTime;
        PlayerPrefs.SetFloat("x", x);
        PlayerPrefs.SetFloat("y", y);
        PlayerPrefs.SetFloat("z", z);
    }
    
}
