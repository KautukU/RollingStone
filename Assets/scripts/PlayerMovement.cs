using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private GameController gameControllerScript;

    private Rigidbody2D rigidbody2d;

    public float moveSpeed = 5f;
    public float jumpVelocity = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();


        GameObject GameControllerObject = GameObject.FindWithTag("GameController");

        if (GameControllerObject != null)
        {
            // I got the game controller object!!
            gameControllerScript = GameControllerObject.GetComponent<GameController>();
        }
        if (GameControllerObject == null)
        {
            Debug.Log("IT didn't work");
        }
    }

  
    // Update is called once per frame
    void Update()
    {

        HandleMovement();

        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
        }
    }

    private void HandleMovement()
    {
        

        if (Input.GetKey(KeyCode.A))
        {
            rigidbody2d.velocity = new Vector2(-moveSpeed, rigidbody2d.velocity.y);
        }
        else
        {
            if (Input.GetKey(KeyCode.D))
            {
                rigidbody2d.velocity = new Vector2(+moveSpeed, rigidbody2d.velocity.y);
            }

        }
    }

    private bool IsGrounded()
    {
        return transform.Find("GroundCheck").GetComponent<GroundCheck>().isGrounded;

    }

    void OnCollisionEnter2D(Collision2D colide)
    {
        if(colide.gameObject.name=="blade")
        {
            Destroy(this.gameObject);
            gameControllerScript.GameOver();
        }

        if (colide.gameObject.name == "Acid")
        {
            Destroy(this.gameObject);
            gameControllerScript.GameOver();
        }
        
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Boundry")
        {
            Destroy(this.gameObject);
            gameControllerScript.GameOver();
        }
    }

}