using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int currentScore = 0;
    public int test = 0;
    public float offsetY = 50;
    public float sizeX = 100;
    public float sizeY = 30;

    public Transform musicPrefab;

    void Start()
    {
        currentScore = 0;

        if (GameObject.FindGameObjectsWithTag("MusicManager").Length == 0)
        {
            //не поняла зачем клонируем
            var musicManager = Instantiate(musicPrefab, transform.position, Quaternion.identity);
            musicManager.name = musicPrefab.name;
            DontDestroyOnLoad(musicManager); //не отключать при перезагрузке
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width/2 - sizeX/2, offsetY, sizeX, sizeY), "Score: " + currentScore);
    }
}
