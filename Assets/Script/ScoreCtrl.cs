using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCtrl : MonoBehaviour
{
    int score = 0;
    Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        this.textComponent = GameObject.Find("Score").GetComponent<Text>();
        this.textComponent.text = "Score " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()      //スコアの加算
    {
        this.score += 10;
        this.textComponent.text = "Score" + score.ToString();
    }

}
