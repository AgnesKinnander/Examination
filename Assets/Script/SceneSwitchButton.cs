using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchButton : MonoBehaviour
{
    public void GoToSceneTwo()
    {
        SceneManager.LoadScene("Menu");
    }
}
