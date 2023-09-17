using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int playerScore = 0;

    [SerializeField] private GameObject ballPrefab;

    public static GameManager instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        Instantiate(ballPrefab, Vector3.zero, Quaternion.identity);
    }

    // Update is called once per frame
    public void UpdateScore(int n)
    {
        playerScore += n;
    }

}
