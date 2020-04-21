using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(SpriteRenderer))]
public class PlatformColorController : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";

    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag.Equals(PLAYER_TAG))
        {
            _spriteRenderer.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
