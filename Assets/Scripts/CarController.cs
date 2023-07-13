using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private Drive _drive;
    [SerializeField] private Brake _brake;

    [SerializeField] private Rigidbody2D _tireWJ;
    [SerializeField] private Rigidbody2D _tire1WJ;
    [SerializeField] private Rigidbody2D _carRB;
    [SerializeField] private float _speed = 0.5f;
    [SerializeField] private float _movement = 0.5f;
    [SerializeField] private float _currentSpeed = 0.5f;

    private void Update()
    {
        if (_drive.getIsDrive())
        {
            _movement += 0.009f;
            if (_movement > 0.5f)
                _movement = 0.5f;
        }
        else if (_brake.getIsBrake())
        {
            _movement -= 0.009f;
            if (_movement <= -0.5f)
                _movement = -0.5f;

        }

        else if (!_drive.getIsDrive() && !_brake.getIsBrake())
        {
            _movement = 0;
        }
        _currentSpeed = _movement * _speed;
        _tireWJ.AddTorque(-_currentSpeed);
        _tire1WJ.AddTorque(-_currentSpeed);
        _carRB.AddTorque(-_currentSpeed);    

    }

}
