using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.3f, 0, 0);   //弾の移動速度

        if (transform.position.x > 10.0f)  //弾の破棄
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
        Destroy(this.gameObject);               
        GameObject.Find("Canvas").GetComponent<ScoreCtrl>().AddScore();   //スコア加算
    }

}
