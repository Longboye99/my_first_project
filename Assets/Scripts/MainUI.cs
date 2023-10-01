using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainUI : MonoBehaviour
{
    [SerializeField]
    private TMP_Text notiText;



    public static MainUI Instance;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    public void ShowNotiText(string s)
    {
        notiText.text = s;
    }
}
