using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int lifes, score;
    public UIManager uiManager;
    public float speed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        uiManager.UpdateLife(lifes);
        uiManager.UpdateScore(score);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, speed * Time.deltaTime, 0);
    }
    public void MoveVertically(float amount)
    {
        speed = amount;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Collectible")
        {
            score += 10;
            uiManager.UpdateScore(score);
            Destroy(collision.gameObject);
        }
        if (collision.tag == "Enemy")
        {
            lifes -= 1;
            
            if (lifes <= 0)
                lifes = 0;
            uiManager.UpdateLife(lifes);
            Destroy(collision.gameObject);
        }
    }
}
