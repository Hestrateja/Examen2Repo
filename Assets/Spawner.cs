using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Transform parent;
    [SerializeField] Transform limitNeg, limitPos;
    [SerializeField] GameObject enemy, collectible;
    [SerializeField] float timeBetween,range;
    private float timer;


    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            var spawn = Instantiate(Random.Range(0, 100) < 21 ? collectible : enemy, new Vector3(Random.Range(0, 2) < 1 ? limitNeg.transform.position.x : limitPos.transform.position.x, Random.Range(limitNeg.transform.position.y,limitPos.transform.position.y), 0), Quaternion.identity);
            spawn.transform.parent = parent;
            timer = timeBetween + Random.Range(-range, range);
        }
        timer -= Time.deltaTime;
    }
}
