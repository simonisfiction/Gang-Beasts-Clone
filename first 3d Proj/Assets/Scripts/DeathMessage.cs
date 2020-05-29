using UnityEngine;
using UnityEngine.UI;
public class DeathMessage : MonoBehaviour {

    public PlayerMovement pirate;
    public Text playerDeathMessage;
	
	// Update is called once per frame
	void Update () {
		if(pirate.enabled == false)
        {
            playerDeathMessage.text = "You Died";
        }
	}
}
