using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamecontroLler1 : MonoBehaviour
{

    public static gamecontroLler1 instance;
    public float time;
    float _time;
    public GameObject eneMi;
    public GameObject GameOverPanel;
    int score;
    public Text endScore;
    public Text Scoretext;
    public Text Bestscoretext;
    public const string HightScore = "Hight Score";
    bool isgameover;
    SceneManager ahi;
    audiosource hit;

    void Start()
    {
        _time = 0;
        Time.timeScale = 0;
        hit = FindObjectOfType<audiosource>();   

    }

    private void Awake()
    {
        _IsgameStartFortheFirttime();
    }
    void Update()
    {
        if (isgameover == true)
        {
            Showpnanel();
            hit._tatnhacnen();
            Time.timeScale = 0;
        }
        _time -= Time.deltaTime;
        if (_time < 0)
        {
            _taoraEnemi();
            _time = time;
        }
        _setscoretext();
    }
    public void Showpnanel()
    {
        GameOverPanel.SetActive(true);
        endScore.text = "EndScore :" + score;
        if (score > _getIntScore())
        {
            _setIntScore(score);

        }
        Bestscoretext.text = "BestScore :" + _getIntScore();
    }
    public void _taoraEnemi()
    {
        float vitriEnemi = Random.Range(5.5f, 8.5f);
        Vector2 noisinhra = new Vector2(vitriEnemi, 6.5f);
            Instantiate(eneMi, noisinhra, Quaternion.identity);

    }
    public void _setIntScore(int valuee)
    {
        score = valuee;
        PlayerPrefs.SetInt(HightScore, score);
    }
    public int _getIntScore()
    {
        return PlayerPrefs.GetInt(HightScore);
    }
    public void _getScore(int value)
    {
        score = value;
    }
    public int _setScore()
    {
        return score;
    }
    public void _setisShowpanel(bool state)
    {
        isgameover = state;
    }
    public bool _getisGameover()
    {
        return isgameover;
    }
    public void _diemSo()
    {
        score++;
    }
    public void _setscoretext()
    {        
            Scoretext.text = ("Score:") + score;                  
    }
    
    public void _showGamepanel(bool isShow)
    {
        GameOverPanel.SetActive(isShow);
    }
    public void _replay()
    {
       
        score = 0;
        SceneManager.LoadScene("MainMenu");
        GameOverPanel.SetActive(false);

    }
    void _IsgameStartFortheFirttime()
    {
        if (!PlayerPrefs.HasKey("_IsgameStartFortheFirttime"))
        {
            PlayerPrefs.SetInt(HightScore, 0);
            PlayerPrefs.SetInt("_IsgameStartFortheFirttime", 0);
        }
    }
    
}
