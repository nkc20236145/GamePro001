using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
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

        // 当たり判定
        {
            Vector2 e1 = transform.position;
            Vector2 p1 = this.player.transform.position;
            Vector2 dir = e1 - p1;
            float d = dir.magnitude;
            float er = 0.5f;
            float pr = 1.0f;

            if(d < er + pr)
            {
                // 監督スクリプトにプレイヤーと衝突したことを伝える
                GameObject director = GameObject.Find("GameDirector");
                director.GetComponent<GameDirector>().DecreaseTime();

                // 衝突したときは消す
                Destroy (gameObject);
            }
        }
    }
}
