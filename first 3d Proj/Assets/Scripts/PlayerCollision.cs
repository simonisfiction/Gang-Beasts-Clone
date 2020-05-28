
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    void OnCollisionEnter(Collision collisionInfo)
    {
       
        if (collisionInfo.collider.tag == "Deadly Surface")
        {
            Debug.Log("You hit lava, and you died");
        }
    }
}
