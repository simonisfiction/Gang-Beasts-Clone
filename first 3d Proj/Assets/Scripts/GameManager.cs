using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay;
    public bool playerIsDead = false;
    public bool playerTwoIsDead = false;
    public bool enemyIsDead = false;
    public Text whoWon;

    public GameObject winLevel;

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
	

    public void GameWon(int player)
    {
        
        if (gameHasEnded == false)
        {
            if (player == 1)
            {
                whoWon.text = "Player Two Wins!";
                winLevel.SetActive(true);
                playerIsDead = true;
                gameHasEnded = true;
                Debug.Log("Player 2 wins");
                Invoke("Restart", restartDelay);
            }
            else if(player == 2)
            {
                whoWon.text = "Player One Wins!";
                winLevel.SetActive(true);
                playerTwoIsDead = true;
                gameHasEnded = true;
                Debug.Log("Player 1 wins");
                Invoke("Restart", restartDelay);
            }
        }
    }
}
