using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text life, score;

    public void UpdateLife(int number)
    {
        life.text = "Lifes: " + number;
    }
    public void UpdateScore(int number)
    {
        score.text = "Score: " + number;
    }

}
