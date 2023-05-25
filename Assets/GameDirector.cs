using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject timeGauge;
    float time = 60.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.timeGauge = GameObject.Find("timeGauge");
    }

    void Update()
    {
        this.time -= Time.deltaTime;
        this.timeGauge.GetComponent<Image>().fillAmount = this.time;
    }

    public void DecreaseTime()
    {
        this.timeGauge.GetComponent<Image>().fillAmount -= 0.05f;
    }
}
