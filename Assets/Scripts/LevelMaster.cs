using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMaster : MonoBehaviour
{
    [SerializeField] 
    private PlanetSettings _planetSettings = default;

    [SerializeField] 
    private string _mainMenuScene = "MainScene";

    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
        _camera.backgroundColor = _planetSettings.m_skyColor;
        Physics2D.gravity = Vector2.down * _planetSettings.m_gravity;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            SceneManager.LoadScene(_mainMenuScene);
        }
    }

    public void OnBallHit()
    {
        ++GameSettings.m_instance.m_ballHit;
    }
}
