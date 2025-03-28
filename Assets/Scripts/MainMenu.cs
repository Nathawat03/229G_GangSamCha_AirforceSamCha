using Mono.Cecil.Cil;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    } //Play

    public void quit()
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game");
    } // Quit

} //PlayScene
