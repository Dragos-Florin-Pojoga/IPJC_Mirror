using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string TestingWorld = "ShootingRange";
    public string CafeteriaLevel = "Cafeteria";
    public string TrainStationLevel = "TrainStation";
    public string WarehouseLevel = "Warehouse";
    public string BackButton = "Main menu";
    public void TestingLevel()
    {
        SceneManager.LoadScene(TestingWorld);
    }
    public void Cafeteria()
    {
        SceneManager.LoadScene(CafeteriaLevel);
    }
    public void TrainStation()
    {
        SceneManager.LoadScene(TrainStationLevel);
    }
    public void Warehouse()
    {
        SceneManager.LoadScene(WarehouseLevel);
    }
    public void Back()
    {
        SceneManager.LoadScene(BackButton);
    }

}
