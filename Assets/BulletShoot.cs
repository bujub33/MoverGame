using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{

    //Reference to bullet emitter
    public GameObject Bullet_Emitter;

    //Reference to bullet prefab
    public GameObject Bullet;

    //Forward force of bullet
    public float Bullet_Force;// = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //When "Space" key is pressed..
        if (Input.GetKey("space")){

            //Temp variable that will hold reference to bullet
            GameObject tempBulletHandler;

            //Temp then instantiates bullet to game using emitter position and angle
            tempBulletHandler = Instantiate(Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation);

            //Corrects angle that bullets appear
            tempBulletHandler.transform.Rotate(Vector3.left * 180);

            //RigidBody instantiated to control bullet physics using bullet handler

            
            Rigidbody tempRigidBody = tempBulletHandler.GetComponent<Rigidbody>();

            //reverse the order


            //Add force to the rigidbody to simulate firing the bullet forward using set bullet force
            tempRigidBody.AddForce(Vector3.forward * Bullet_Force);

            //Free up space from bullets fired (after 4 sec)
            Destroy(tempBulletHandler, 4.0f);
        }
    }
}
