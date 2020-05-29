using UnityEngine;
using UnityEngine.UI;
public class DeathMessage : MonoBehaviour {

    public PlayerMovement pirate;
    public Text playerDeathMessage;
    public GameManager gameManager;
	
	// Update is called once per frame
	void Update () {
		if(pirate.enabled == false)
        {
            playerDeathMessage.text = "You Died";
        }

        if(gameManager.enemyIsDead)
        {
            playerDeathMessage.text = "You Won";
        }
	}
}
