using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropLedge : MonoBehaviour
{
    private Rigidbody2D rBody;

    
    // Start is called before the first frame update
    void Start()
    {
        rBody = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        

    }

    void OnCollisionEnter2D(Collision2D colide)
    {
        if(colide.gameObject.name=="Player")
        {
            rBody.velocity = new Vector2(0, -6);

        }

        
        if (colide.gameObject.name=="slide")
        {
            Destroy(this.gameObject);
        }

        if(colide.gameObject.name=="Ground2")
        {
            Destroy(this.gameObject);
        }
    }

}
