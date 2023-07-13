using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    [SerializeField] private Sprite _pedalRB;
    [SerializeField] private Sprite _pressedPedalRB;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private bool _isDrive = false;

    void OnMouseDown()
    {
        _spriteRenderer.sprite = _pressedPedalRB;
        _isDrive = true;
    }

    void OnMouseUp()
    {
        _spriteRenderer.sprite = _pedalRB;
        _isDrive = false;
    }

    public bool getIsDrive()
    {
        return _isDrive;
    }
}
