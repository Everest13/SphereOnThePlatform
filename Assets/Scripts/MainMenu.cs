using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource audioData;
    public Slider audioSlider;

    //Push StartGame Button
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Quit from game
    public void QuitGame()
    {
        Application.Quit();
    }

    //Set audio val on slider
    public void SetGameVolume()
    {
        audioData.volume = audioSlider.value;
    }
}
