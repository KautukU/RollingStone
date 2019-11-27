using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    private Rigidbody2D rbody;

    
    // Start is called before the first frame update
    void Start()
    {
         rbody = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (rbody.transform.position.y > 3.0)
        {
            rbody.velocity = new Vector2(0, -2);
        }

        else if(rbody.transform.position.y<0.2)
        {
            rbody.velocity = new Vector2(0, 2);
        }
    }
}
