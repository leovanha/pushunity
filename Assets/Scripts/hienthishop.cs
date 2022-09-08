using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hienthishop : MonoBehaviour
{
    public GameObject ak;
    public GameObject scal;
    public GameObject m249;
    public GameObject Save;
    public GameObject Detail;
    public GameObject exit;


    public void _hienthishop()
    {
        ak.SetActive(true);
        scal.SetActive(true);
        m249.SetActive(true);
        Save.SetActive(true);
        Detail.SetActive(true);
        exit.SetActive(true);
        Time.timeScale = 0;
    }
    public void _exitshop()
    {
        ak.SetActive(false);
        scal.SetActive(false);
        m249.SetActive(false);
        Save.SetActive(false);
        Detail.SetActive(false);
        exit.SetActive(false);
        Time.timeScale = 1;
    }
    
}
