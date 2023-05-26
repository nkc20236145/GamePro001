using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // フレーム毎に等速で右に移動させる
        transform.Translate(0, 0.1f, 0);

        //画面外に出たら破棄
        if (transform.position.y > 10.0f)
        {
            Destroy(gameObject);
        }

        // 当たり判定
        {
            void OnCollisionEnter(Collision collision)
            {
                //衝突したオブジェクトがplayerだったとき
                if (collision.gameObject.CompareTag("enemy"))
                {
                    // 衝突したときは消す
                    Destroy(gameObject);
                }
            }
        }
    }
}
