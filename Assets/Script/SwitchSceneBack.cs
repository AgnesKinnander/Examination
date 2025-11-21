using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneBack : MonoBehaviour
{
    public void GoToSceneOne()
    {
        SceneManager.LoadScene("Game");
    }
}