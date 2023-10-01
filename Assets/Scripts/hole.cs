using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole : MonoBehaviour
{
    [SerializeField]
    private int score;
    private void OnCollisionEnter(Collision collision)
    {
        Ball b = collision.gameObject.GetComponent<Ball>();
        if(b != null)
        {
            GameManager.instance.UpdateScore(b.point);
            Destroy(b.gameObject);
            score += b.point;
            MainUI.Instance.ShowNotiText($"Score : {b.point}\nCurrent Score : {score}");
        }
    }
}
