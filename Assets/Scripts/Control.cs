using UnityEngine;
using UnityEngine.SceneManagement;
public class Control : MonoBehaviour
{
    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("Restart Game");
    }
    
} // Restart Game
