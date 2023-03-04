using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class GameOverText : MonoBehaviour
{

    public GameObject capsule;
    private Text text;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();

        // start text off as completely transparent black
        text.color = new Color(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (capsule == null)       
        {
            // reveal text only when helicopter is null (destroyed)
            text.color = new Color(237, 255, 230, 1);
        }
    }
}