using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rokCtrl : MonoBehaviour
{
    public GameObject bullet;
    [SerializeField] private float speed;//プレイヤーの移動速度
    [SerializeField] private float maxY, minY;       //移動制限

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();   //プレイヤーを動かすメソッド
        Bullet();       //弾を発射するメソッド
        

    }
    void MovePlayer()
    {
        //もし上矢印キーが押されたら
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            Vector3 playerPos = transform.position; //Vector3型のplayerPosに現在の位置情報を格納
            playerPos.y += speed * Time.deltaTime; //y座標にspeedを加算

            //追加
            //もしplayerPosのY座標がmaxY（最大Y座標）より大きくなったら
            if (maxY < playerPos.y)
            {
                playerPos.y = maxY; //PlayerPosのY座標にmaxYを代入
            }
            transform.position = playerPos; //現在の位置情報に反映させる

        }
        else if (Input.GetAxisRaw("Vertical") < 0)　//もし下矢印キーが押されたら
        {
            Vector3 playerPos = transform.position;
            playerPos.y -= speed * Time.deltaTime;

            //追加
            if (minY > playerPos.y)
            {
                playerPos.y = minY;
            }
            transform.position = playerPos;
        }
    }

    void Bullet()   //弾の発射呼び出し
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }

}
