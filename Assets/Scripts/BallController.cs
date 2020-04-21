using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallController : MonoBehaviour
{
    [SerializeField] 
    [Range(0f, 100f)]
    private float _inputPower = 10f;

    private Camera _camera;
    private Rigidbody2D _rigidbody;
    private LevelMaster _levelMaster;

    private const string GROUND_TAG = "Ground";

    private void Awake()
    {
        _camera = Camera.main;
        _rigidbody = GetComponent<Rigidbody2D>();
        _levelMaster = FindObjectOfType<LevelMaster>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var mouseWorldPosition = _camera.ScreenToWorldPoint(Input.mousePosition);
            var forceDirection = mouseWorldPosition - transform.position;
            forceDirection.z = 0f;
            _rigidbody.AddForce(_inputPower * forceDirection.normalized);
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag.Equals(GROUND_TAG))
        {
            _levelMaster.OnBallHit();
        }
    }
}
