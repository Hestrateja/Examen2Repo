using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetector : MonoBehaviour
{
    public Player player;
    private Vector2 startPos;
    public int pixelDistToDetect = 20;
    private bool fingerDown;

    private void Update()
    {
        if (fingerDown == false && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            startPos = Input.touches[0].position;
            fingerDown = true;
        }
        if (fingerDown)
        {
            if (Input.touches[0].position.y >= startPos.y + pixelDistToDetect)
            {
                fingerDown = false;
                //Debug.Log("swipe up");
                player.MoveVertically(5);
            }

            else if (Input.touches[0].position.y <= startPos.y - pixelDistToDetect)
            {
                fingerDown = false;
                //Debug.Log("swipe down");
                player.MoveVertically(-5);
            }

            else
            {
                player.MoveVertically(0);
            }

        }
        if (fingerDown && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Ended)
        {
            fingerDown = false;
            player.MoveVertically(0);
        }
    }
}
