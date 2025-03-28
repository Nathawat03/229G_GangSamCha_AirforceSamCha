using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    public void EndGameScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }//Play
    
    public void quit()
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game");
    } // Quit
    
}
