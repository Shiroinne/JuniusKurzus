using UnityEngine;
using UnityEngine.SceneManagement;

class GameOverMenu : MonoBehaviour
{
    Vector3 v3;

    public void RestartGame()
    {
        SceneManager.LoadScene("MyFirstGame");
    }
}
