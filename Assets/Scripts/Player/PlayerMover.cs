using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _maxSpeed;
    [SerializeField] private float _speedUpGap;
    [SerializeField] private float _speedUpValue;

    private Rigidbody _player;
    private PlayerInput _playerInput;
    private float _speedUpTime;

    private void Awake()
    {
        _playerInput = new PlayerInput();

        _playerInput.Player.Jump.performed += ctx => Jump();
    }

    private void Start()
    {
        _player = GetComponent<Rigidbody>();

        _player.velocity = Vector3.right * _speed;
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void Update()
    {
        if (_speed >= _maxSpeed)
        {
            _speedUpTime += Time.deltaTime;

            if (_speedUpTime >= _speedUpGap)
            {
                _speed += _speedUpValue;
                _speedUpTime = 0;
            }
        }

        if (_player.velocity.x <= _speed)
        {
            _player.velocity += Vector3.right * _speed * Time.deltaTime;
        }
    }

    private void Jump()
    {
        if (_player.velocity.y == 0)
            _player.AddForce(Vector3.up * _jumpForce);
    }
}
