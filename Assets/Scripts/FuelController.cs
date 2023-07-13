using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelController : MonoBehaviour
{
    public static FuelController instance;

    [SerializeField] private Image _fuelImg;
    [SerializeField, Range(0.1f, 5f)] private float _fuelDrain = 1f;
    [SerializeField] private float _maxFuel = 100f;
    private float _currentFuel;
    [SerializeField] private Gradient _gradient;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        _currentFuel = _maxFuel;
        _fuelImg.fillAmount = (_currentFuel / _maxFuel);
        _fuelImg.color = _gradient.Evaluate(_fuelImg.fillAmount);
    }

    private void Update()
    {
        _currentFuel -= Time.deltaTime * _fuelDrain;
        _fuelImg.fillAmount = (_currentFuel / _maxFuel);
        _fuelImg.color = _gradient.Evaluate(_fuelImg.fillAmount);

        if (_currentFuel <= 0f)
        {
            GameManager.instance.GameOver();
        }
    }

    public void FillFuel()
    {
        _currentFuel = _maxFuel;
        _fuelImg.fillAmount = (_currentFuel / _maxFuel);
        _fuelImg.color = _gradient.Evaluate(_fuelImg.fillAmount);
    }

}
