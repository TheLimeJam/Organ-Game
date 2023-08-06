using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedRoundScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public int frameFeq = 0;
    public MusicLogic logic;
    public float force = 0;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<MusicLogic>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (logic.frame % (frameFeq * 2) == 0)
        {
            popUp();
        }

        else if (logic.frame % frameFeq == 0)
        {
            popDown();
        }
    }

    void popUp()
    {
        Debug.Log("pop" + logic.frame);
        myRigidbody.AddForce(transform.up * force);
    }

    void popDown()
    {
        Debug.Log("pop" + logic.frame);
        myRigidbody.AddForce(transform.up * (-1 * force));
    }
}
