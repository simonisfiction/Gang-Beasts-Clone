using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player Two")
        {
            gameManager.GameWon(2);
            
        }
        if (other.collider.tag == "Player One")
        {
            gameManager.GameWon(1);

        }
    }
}
