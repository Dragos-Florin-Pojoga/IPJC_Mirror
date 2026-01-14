using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string OptionsScene = "Options scene";
    public string LevelSelect = "Level Select";
    public void Play()
    {
        SceneManager.LoadScene(LevelSelect);
    }
    public void Options()
    {
        SceneManager.LoadScene(OptionsScene);
    }
    public void Quit()
    {
        Application.Quit();
    }

}
