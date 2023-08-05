using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public int frameNum = 0;
    public MusicLogic logic;
    public float downForce = 0;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<MusicLogic>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (logic.frame == frameNum)
        {
            pop();
        }
    }

    void pop()
    {
        Debug.Log("pop" + logic.frame);
        myRigidbody.AddForce(transform.up * (-1 * downForce));
    }
}
