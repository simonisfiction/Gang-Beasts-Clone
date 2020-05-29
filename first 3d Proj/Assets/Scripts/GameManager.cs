using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay;
	public void EndGame ()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }
	
    void Restart ()
    {
        SceneManager.LoadScene("Moving Block");
    }
	
}
