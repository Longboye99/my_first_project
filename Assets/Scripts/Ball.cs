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
    [SerializeField] 
    private int point;

    [SerializeField] 
    private BallColor ballColor;

    [SerializeField] 
    private Renderer renderer;

    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private float forcepower = 5;

    // Start is called before the first frame update
    void Awake()
    {
        renderer = GetComponent<Renderer>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        Debug.Log(point);
        GameManager.instance.UpdateScore(point);
    }

    public void SetColorAndPoint(BallColor col)
    {
        switch (col)
        {
            case BallColor.White:
                point = 0;
                renderer.material.color = Color.white;
                break;

            case BallColor.Red:
                point = 1;
                renderer.material.color = Color.red;
                break;

            case BallColor.Yellow:
                point = 2;
                renderer.material.color = Color.yellow;
                break;

            case BallColor.Green:
                point = 3;
                renderer.material.color = Color.green;
                break;

            case BallColor.Brown:
                point = 4;
                renderer.material.color = new Color32(99, 57,30,255);
                break;

            case BallColor.Blue:
                point = 5;
                renderer.material.color = Color.blue;
                break;

            case BallColor.Pink:
                point = 6;
                renderer.material.color = new Color32(225,107,187,255);
                break;

            case BallColor.Black:
                point = 7;
                renderer.material.color = Color.black;
                break;
            default:
                break;
        }
    }

 

}
