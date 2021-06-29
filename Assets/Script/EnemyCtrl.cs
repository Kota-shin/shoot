using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    float fallSpeed;    //敵の移動速度
    float rotSpeed;     //敵の回転速度

    // Start is called before the first frame update
    void Start()
    {
        this.fallSpeed = 0.1f + 0.3f * Random.value; 
        this.rotSpeed = 3f + 2f * Random.value;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(-0.02f, 0, 0);  一定の移動速度

        transform.Translate(-fallSpeed, 0, 0, Space.World);     //変則的な移動速度
        transform.Rotate(0, 0, rotSpeed);                       //変則的な回転

        if (transform.position.x < -10.0f)      //通り過ぎると破棄
        {
            Destroy(gameObject);
            GameObject.Find("GameObject").GetComponent<GManager>().GameOver();
        }
    }
}
