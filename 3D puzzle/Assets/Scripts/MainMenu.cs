using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _backMenu;
    [SerializeField] private GameObject _infoWhite;
    [SerializeField] private GameObject _infoBlack;
    [SerializeField] private GameObject _telegram;

    public void StarGame()
    {
        FindObjectOfType<LevelManager>().NextLevel();
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Telegram()
    {
        Application.OpenURL("https://t.me/faustingames");
    }
    //public void Exit()
    //{
    //    Application.Quit();
    //}

    public void OnButton()
    {
        _backMenu.SetActive(true);
        _infoWhite.SetActive(false);
        _infoBlack.SetActive(true);
        _telegram.SetActive(true);
    }

    public void OffButton()
    {
        _backMenu.SetActive(false);
        _infoWhite.SetActive(true);
        _infoBlack.SetActive(false);
        _telegram.SetActive(false);
    }
}
