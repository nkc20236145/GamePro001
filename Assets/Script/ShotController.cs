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
        // �t���[�����ɓ����ŉE�Ɉړ�������
        transform.Translate(0, 0.1f, 0);

        //��ʊO�ɏo����j��
        if (transform.position.x > 10.0f)
        {
            Destroy(gameObject);
        }
    }

    // �����蔻��       
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("enemy"))
        {
            // �Փ˂����玩����������
            Destroy(gameObject);

            // �Փˑ��肪������
            Destroy(collision.gameObject);
        }
    }
}
