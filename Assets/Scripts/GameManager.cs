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
        SetBall(BallColor.Black);
        SetBall(BallColor.Pink);
        SetBall(BallColor.Red);

        
    }

    // Update is called once per frame
    public void UpdateScore(int n)
    {
        playerScore += n;
    }

    private void SetBall(BallColor color)
    {
        GameObject obj = Instantiate(ballPrefab, Vector3.zero, Quaternion.identity);
        Ball b = obj.GetComponent<Ball>();
        b.SetColorAndPoint(color);
    }
}
