using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings
{
    private static GameSettings _instance;

    public static GameSettings m_instance => _instance ?? (_instance = new GameSettings());
    
    public int m_ballHit { get; set; }
}
