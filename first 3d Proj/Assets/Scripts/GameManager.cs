using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay;
    public bool playerIsDead = false;
    public bool enemyIsDead = false;


	public void EndGame ()
    {
        if(gameHasEnded == false)
        {
            playerIsDead = true;
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }
	

    void Restart ()
    {
        SceneManager.LoadScene("Moving Block");
    }
	

    public void GameWon()
    {
        if (gameHasEnded == false)
        {
            enemyIsDead = true;
            gameHasEnded = true;
            Debug.Log("Level Won");
            Invoke("Restart", restartDelay);
        }
    }
}
