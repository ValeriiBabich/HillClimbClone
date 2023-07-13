using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private GameObject _gameOver;
    [SerializeField] private GameObject _gameStart;
    [SerializeField] private GameObject _pedalGas;
    [SerializeField] private GameObject _pedalBrake;
    [SerializeField] private GameObject _fuel;
    [SerializeField] private GameObject _venicle;
    [SerializeField] private GameObject _Hud;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        Time.timeScale = 0f;
    }

    public void GameOver()
    {
        _gameOver.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void StartGame()
    {
        _gameStart.SetActive(false);
        _pedalGas.SetActive(true);
        _pedalBrake.SetActive(true);
        _fuel.SetActive(true);
        _venicle.SetActive(true);
        _Hud.SetActive(true);
        Time.timeScale = 1f;
    }
}
