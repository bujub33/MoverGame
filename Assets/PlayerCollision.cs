
using UnityEngine;

public class PlayerCollision : MonoBehaviour{

    public PlayerMovement movement;

    // Start is called before the first frame update
    void OnCollisionEnter(Collision collideInfo)
    {
        if (collideInfo.collider.tag == "Obstacle")
        {
            //movement.enabled = false;
        }
    }
    
}
