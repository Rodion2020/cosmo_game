using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// using UnityEngine.Text;
public class GameContoller : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameContoller ThisInstance = null;

    public static int Score;
    public string ScorePrefix = string.Empty;
    public Text ScoreText = null;
    public Text GameOverText = null;

    void Awake()
    {
        ThisInstance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreText != null)
        {
            ScoreText.text = ScorePrefix +Score.ToString();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
    public static void GameOver()
    {
        if (ThisInstance.GameOverText != null)
        {
            ThisInstance.GameOverText.gameObject.SetActive(true);
        }
    }

}
