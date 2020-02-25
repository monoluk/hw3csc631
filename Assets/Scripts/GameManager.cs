
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public GameObject CompletedLevelUI;

    public void EndGame(){

        if(!gameHasEnded){
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart",restartDelay);
        
        }
    }

    void Restart(){
        SceneManager.LoadScene("lv1");
    }

    public void CompletedLevel() {
        CompletedLevelUI.SetActive(true);
    }

}
