using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayScoreMeter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _metersTxt;
    [SerializeField] private Transform _playerTransform;
    private Vector2 _startPosition;

    private void Start()
    {
        _startPosition = _playerTransform.position;
    }

    private void Update()
    {
        Vector2 meters = (Vector2)_playerTransform.position - _startPosition;
        meters.y = 0f;

        if (meters.x < 0)
        {
            meters.x = 0;
        }
        _metersTxt.text = meters.x.ToString("F0") + "m";
    }
}
