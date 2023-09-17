using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum BallColor
{
    White,
    Red,
    Yellow,
    Green,
    Brown,
    Blue,
    Pink,
    Black
}

public class Ball : MonoBehaviour
{
    [SerializeField] private int point;
    [SerializeField] private BallColor ballColor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log(point);
        GameManager.instance.UpdateScore(point);
        Destroy(gameObject);
    }
}
