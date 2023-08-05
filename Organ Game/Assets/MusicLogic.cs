using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLogic : MonoBehaviour
{
    
    int framestart;
    public int frame = 0;

    // Start is called before the first frame update
    void Start()
    {
        Time.fixedDeltaTime = 1f / 24f;
    }
    void FixedUpdate()
    {
        if (frame % 24 == 12)
        {
            Debug.Log(frame);
        }
       else if (frame % 24 == 0)
        {
            Debug.Log(frame);
        }

        frame ++;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void down()
    {
        //animator.SetBool("down", true);
    }

    void up()
    {
        
    }

}
