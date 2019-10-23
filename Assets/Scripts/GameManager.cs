using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Текущее кол-во очков
    public int currentScore = 0;
    public int test = 0;
    public bool isRestarting = false;

    public Transform musicPrefab;
    public AudioSource audioData;
    public AudioClip gameOver;
    public Transform player;

    public static int finalScores = 0;

    void Start()
    {
        currentScore = 0;
        //Create music fon
        if (GameObject.FindGameObjectsWithTag("MusicManager").Length == 0)
        {
             var musicManager = Instantiate(musicPrefab, transform.position, Quaternion.identity);
             musicManager.name = musicPrefab.name;
             DontDestroyOnLoad(musicManager); //не отключать при перезагрузке
        }
    }

    //Load active scene
    //And play Game Over sound
    public IEnumerator Restart()
    {
        isRestarting = true;
        //set clip in gameObject audioSource
        audioData.clip = gameOver;
        audioData.pitch = 1;
        audioData.Play();
        yield return new WaitForSeconds(audioData.clip.length);

        SelfDestruct selfDestruct = player.GetComponent<SelfDestruct>();
        selfDestruct.DeDestruct();
        player.position = CheckPoint.ReachedPoint;
        isRestarting = false;
    }

    public void LoadNexLevel()
    {
        finalScores += currentScore;
        CheckPoint.ReachedPoint = new Vector3();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
