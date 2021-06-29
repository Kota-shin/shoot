using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float interval = 2.0f;
    private float timeElapsed = 0.0f;
    private bool isGameOver = false;
    public GameObject gameOver;
    public GameObject retry;

    // Start is called before the first frame update
    void Start()
    {
        this.gameOver = GameObject.Find("GameOverText");
        this.gameOver.SetActive(false);
        this.retry = GameObject.Find("Button");
        this.retry.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed >= interval && isGameOver == false)  //敵がランダムの位置に配置
        {
            timeElapsed = 0.0f;
            Vector3 randamPos = new Vector3(11, Random.Range(3.7f, -3.7f), 0);
            Instantiate(enemyPrefab, randamPos, Quaternion.identity);
        }
    }

    public void GameOver()      //GameOverテキストの表示
    {
        
        this.gameOver.SetActive(true);
        this.isGameOver = true; ;
        this.retry.SetActive(true);
    }

}
