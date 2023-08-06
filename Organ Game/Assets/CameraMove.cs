using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float moveSpeed;
    public Transform start;
    public Transform finish;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }   

    void move()
    {

        transform.position = Vector3.MoveTowards(start.position, finish.position, moveSpeed);

    }
}
