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
    float time = 1; // ��������
    float countTime = 100.0f;
    float dis;

    // Start is called before the first frame update
    void Start()
    {
        // ���ꂼ��̃I�u�W�F�N�g���擾
        this.timeGauge = GameObject.Find("timeGauge");
        this.Distance = GameObject.Find("Distance");
    }

    void Update()
    {
        DecreaseTime();

        if (this.timeGauge.GetComponent<Image>().fillAmount == 0)   // �^�C���Q�[�W���[���ɂȂ�����V�[���J��
        {
            SceneManager.LoadScene("StartScene");
        }

        this.dis += Time.deltaTime / 0.7f;�@�@// ��s�������擾
        this.Distance.GetComponent<TextMeshProUGUI>().text = this.dis.ToString("F1") + "km";   // ��s������\��
    }

    public void DecreaseTime()
    {
        this.timeGauge.GetComponent<Image>().fillAmount -= 1.0f / countTime * Time.deltaTime;  // UI�^�C���Q�[�W�̊Ǘ�

        time -= 1.0f / countTime * Time.deltaTime;  // �������Ԃ̊Ǘ�

        //Debug.Log(time);   //�������ԓ���̊m�F
    }

    public void DecreaseTime2()
    {
        // Enemy�ƏՓ˂����Ƃ��Ɏ��Ԃ�����悤��EnemyComtroller�ɌĂяo���Ă��炤���߂̂���
        this.timeGauge.GetComponent<Image>().fillAmount -= 10.0f / 100.0f;
    }

    public void DistanceResult()
    {
        this.dis += Time.deltaTime / 0.7f;�@�@// ��s�������擾
        this.Distance.GetComponent<TextMeshProUGUI>().text = this.dis.ToString("F1") + "km";   // ��s������\��
    }
}
