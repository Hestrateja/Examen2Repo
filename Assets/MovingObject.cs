using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    [SerializeField] float speed;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        if (transform.position.x < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            direction = new Vector3(1, 0, 0);
        }
        else
        {
            transform.localScale = new Vector3(-1, 1, 1);
            direction = new Vector3(-1, 0, 0);
        }
            

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
