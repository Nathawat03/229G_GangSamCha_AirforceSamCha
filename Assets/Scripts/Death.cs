using System;
using UnityEngine;

public class Death : MonoBehaviour
{
    private int hitpoints = 3;
    private int score = 0;

    public Vector3 spawnPosition;
    public Transform playerTransform;

    private void Update()
    {
        if (playerTransform.position.y <= -1)
        {
            playerTransform.position = spawnPosition;
        }
    }
}
