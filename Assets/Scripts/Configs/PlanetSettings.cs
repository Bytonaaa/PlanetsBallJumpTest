using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlanetSettings", menuName = "Planet Settings")]
public class PlanetSettings : ScriptableObject
{
    [SerializeField] 
    private float _gravity = default;

    public float m_gravity => _gravity;

    [SerializeField] 
    private Color _skyColor = default;

    public Color m_skyColor => _skyColor;
}
