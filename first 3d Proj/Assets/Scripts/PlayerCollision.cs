
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    

    void OnCollisionEnter(Collision other)
    {
       
        if (other.collider.tag == "Deadly Surface")
        {

            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
}
