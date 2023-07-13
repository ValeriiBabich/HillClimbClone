using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brake : MonoBehaviour
{
    [SerializeField] private Sprite _pedalRB;
    [SerializeField] private Sprite _pressedPedalRB;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private bool _isBrake = false;

    void OnMouseDown()
    {
        _spriteRenderer.sprite = _pressedPedalRB;
        _isBrake = true;

    }

    void OnMouseUp()
    {
        _spriteRenderer.sprite = _pedalRB;
        _isBrake = false;
    }

     public bool getIsBrake()
    {
        return _isBrake;
    }
}
