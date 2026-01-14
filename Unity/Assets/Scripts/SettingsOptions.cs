using System.Globalization;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class SettingsOptions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public string BackButton = "Main menu"; 
    public Slider slider;
    float SValue;

    public void ValueChange()
    {
        slider.value = SValue;
    }
    public void Save()
    {
        
        File.WriteAllText("settings.txt", SValue.ToString(CultureInfo.InvariantCulture));

    }
    public void Back()
    {
        SceneManager.LoadScene(BackButton);
    }
}
