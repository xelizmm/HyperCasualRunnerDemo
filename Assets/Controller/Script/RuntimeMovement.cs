using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;  

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))]

public class RuntimeMovement : MonoBehaviour
{
    private Movement _input;
    private CharacterController _controller;
    private Animator _animator;

    [SerializeField] private float fraction = 100;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _input = GetComponent<Movement>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        _controller.Move(new Vector3(_input.moveVal.x * _input.moveSpeed / fraction, 0f, _input.moveVal.y * _input.moveSpeed / fraction));
        _animator.SetFloat("speed", _controller.velocity.magnitude);
    }

}
