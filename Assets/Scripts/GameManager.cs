using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] 
    private int playerScore = 0;

    [SerializeField] 
    private GameObject ballPrefab;

    [SerializeField] 
    private GameObject[] ballPositions;

    [SerializeField]
    private GameObject cueBall;

    [SerializeField]
    private float xInput;

    public static GameManager instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        SetBall(BallColor.Red,1);
        SetBall(BallColor.Yellow,2);
        SetBall(BallColor.Green,3);
        SetBall(BallColor.Brown,4);
        SetBall(BallColor.Blue,5);
        SetBall(BallColor.Pink,6);
        SetBall(BallColor.Black,7);


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shootBall();
            
        }

        rotateBall();

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            stopBall();
        }
    }

    // Update is called once per frame
    public void UpdateScore(int n)
    {
        playerScore += n;
    }

    private void SetBall(BallColor color ,int i)
    {
        GameObject obj = Instantiate(ballPrefab, ballPositions[i].transform.position, Quaternion.identity);
        Ball b = obj.GetComponent<Ball>();
        b.SetColorAndPoint(color);
    }

    private void shootBall()
    {
        Rigidbody rb = cueBall.GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.forward*30, ForceMode.Impulse);

    }

    private void stopBall()
    {
        Rigidbody rb = cueBall.GetComponent<Rigidbody>();

        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        cueBall.transform.eulerAngles = Vector3.forward;
    }

    private void rotateBall()
    {
        xInput = Input.GetAxis("Horizontal");
        cueBall.transform.Rotate(new Vector3(0f, xInput, 0f));
    }
}
