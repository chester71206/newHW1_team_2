using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Text = TMPro.TextMeshProUGUI;
public class gamemannager : MonoBehaviour
{ public womanaction Womanaction;
    public GameObject loselevelUI;
    public bool endgame = false;
    public Text highscore_text;
    // Start is called before the first frame update
    public void lose_level()
    {
        loselevelUI.SetActive(true);
        Debug.Log("HI");
        endgame = true;
        checkhigh_score();
        UpdateHighScoreText();

    }
    public  void pressstart()
    {
        SceneManager.LoadScene(1);
        Debug.Log("2341");
    }
    void Start()
    {
        UpdateHighScoreText();
    }

    // Update is called once per frame
    void checkhigh_score()
    {
        if (Womanaction.score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", Womanaction.score);
        }
    }
    void UpdateHighScoreText()
    {
        highscore_text.text = $"History High Score:{PlayerPrefs.GetInt("HighScore", 0)}";
    }
    void Update()
    {
        if (endgame == true)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                SceneManager.LoadScene(0);
            }
        }
        /*if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(1);
            Debug.Log("2341");
        }*/
    }
}
