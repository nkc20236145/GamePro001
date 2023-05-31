using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject timeGauge;
    GameObject Distance;
    float time = 1; // 制限時間
    float countTime = 100.0f;
    float dis;

    // Start is called before the first frame update
    void Start()
    {
        // それぞれのオブジェクトを取得
        this.timeGauge = GameObject.Find("timeGauge");
        this.Distance = GameObject.Find("Distance");
    }

    void Update()
    {
        DecreaseTime();

        if (this.timeGauge.GetComponent<Image>().fillAmount == 0)   // タイムゲージがゼロになったらシーン遷移
        {
            SceneManager.LoadScene("StartScene");
        }

        this.dis += Time.deltaTime / 0.7f;　　// 飛行距離を取得
        this.Distance.GetComponent<TextMeshProUGUI>().text = this.dis.ToString("F1") + "km";   // 飛行距離を表示
    }

    public void DecreaseTime()
    {
        this.timeGauge.GetComponent<Image>().fillAmount -= 1.0f / countTime * Time.deltaTime;  // UIタイムゲージの管理

        time -= 1.0f / countTime * Time.deltaTime;  // 内部時間の管理

        //Debug.Log(time);   //内部時間動作の確認
    }

    public void DecreaseTime2()
    {
        // Enemyと衝突したときに時間が減るようにEnemyComtrollerに呼び出してもらうためのもの
        this.timeGauge.GetComponent<Image>().fillAmount -= 10.0f / 100.0f;
    }

    public void DistanceResult()
    {
        this.dis += Time.deltaTime / 0.7f;　　// 飛行距離を取得
        this.Distance.GetComponent<TextMeshProUGUI>().text = this.dis.ToString("F1") + "km";   // 飛行距離を表示
    }
}
