using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float backwardForce = -60f;
    public float forwardForce = 100f;
    public float sidewaysForce = 20f;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(100, 100, 200);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Movement force
        rb.AddForce(10, 10, 50.0f * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("w"))
        {
            rb.AddForce(forwardForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
        }
        else if (Input.GetKey("s"))
        {
            rb.AddForce(backwardForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
        }


        /*switch (Input.GetKeyDown())
         {

            // case Input.GetKeyDown("a"):


            //a: rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);


         }
         */

    }
}
                                          