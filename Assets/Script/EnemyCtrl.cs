using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    float fallSpeed;
    float rotSpeed;

    // Start is called before the first frame update
    void Start()
    {
        this.fallSpeed = 0.1f + 0.3f * Random.value;// 
        this.rotSpeed = 3f + 2f * Random.value;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(-0.02f, 0, 0);

        transform.Translate(-fallSpeed, 0, 0, Space.World);
        transform.Rotate(0, 0, rotSpeed);  //rotSpeed

        if (transform.position.x < -10.0f)
        {
            Destroy(gameObject);
            GameObject.Find("GameObject").GetComponent<GManager>().GameOver();
        }
    }
}
