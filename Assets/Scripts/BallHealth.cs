using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BallHealth : MonoBehaviour
{
    public int maxFallDistance = -1;
    public AudioClip gameOver;
    public AudioSource audioData;
    private bool isRestarting = false;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= maxFallDistance && isRestarting == false)
        {
            StartCoroutine(Restart());
        }
    }

    //Load active scene
    //And play Game Over sound
    IEnumerator Restart()
    {
        isRestarting = true;
        //set clip in gameObject audioSource
        audioData.clip = gameOver;
        audioData.pitch = 1;
        audioData.Play();
        yield return new WaitForSeconds(audioData.clip.length);
        //reload active scene level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
