using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour
{
    public Player player;
    public float multiplier = 5;

    private void Update()
    {
        player.MoveVertically(Mathf.Clamp(Input.acceleration.y * multiplier,-5,5));
    }
}