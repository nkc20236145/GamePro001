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
        this.timeGauge = GameObject.Find("timeGauge");
        this.Distance = GameObject.Find("Distance");
    }

    void Update()
    {
        DecreaseTime();

        if (this.timeGauge.GetComponent<Image>().fillAmount < 0)   // タイムゲージがゼロになったらだと思うけどわからない
        {
            SceneManager.LoadScene("TimeUp");
        }

        this.dis += Time.deltaTime / 0.7f;
        this.Distance.GetComponent<TextMeshProUGUI>().text =this.dis.ToString("F1") + "m";
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
}
