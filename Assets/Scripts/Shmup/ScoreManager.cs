using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text scoreTxt;

    private int score = 0;
    public static ScoreManager  Instance { get; set; }
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public void UpdateScore(int s)
    {
        score += s;
        scoreTxt.text = score.ToString();
    }

    public void Zero()
    {
        score = 0;
        scoreTxt.text = score.ToString();
    }
}
