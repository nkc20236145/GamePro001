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
        // �t���[�����ɓ����ŉE���獶�֗���
        transform.Translate(-0.1f, 0, 0);

        //��ʊO�ɏo����j��
        if(transform.position.x < -10.0f)
        {
            Destroy(gameObject);
        }
    }

    // �����蔻��
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //�Փ˂����I�u�W�F�N�g��player�������Ƃ�
        if (collision.gameObject.CompareTag("player"))
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseTime2();

            // �Փ˂����Ƃ��͏���
            Destroy(gameObject);
        }
    }

}
