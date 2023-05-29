using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // フレーム毎に等速で右から左へ流す
        transform.Translate(-0.1f, 0, 0);

        //画面外に出たら破棄
        if(transform.position.x < -10.0f)
        {
            Destroy(gameObject);
        }
    }

    // 当たり判定
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //衝突したオブジェクトがplayerだったとき
        if (collision.gameObject.CompareTag("player"))
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseTime2();

            // 衝突したときは消す
            Destroy(gameObject);
        }
    }

}
