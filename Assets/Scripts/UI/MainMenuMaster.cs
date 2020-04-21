using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuMaster : MonoBehaviour
{
    [SerializeField] 
    private Text _ballHitCount = default;

    private void Start()
    {
        _ballHitCount.text = $"Ball Hit: {GameSettings.m_instance.m_ballHit}";
    }

    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
