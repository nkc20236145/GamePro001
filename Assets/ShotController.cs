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
        if (transform.position.y > 10.0f)
        {
            Destroy(gameObject);
        }

        // �����蔻��
        {
            void OnCollisionEnter(Collision collision)
            {
                //�Փ˂����I�u�W�F�N�g��player�������Ƃ�
                if (collision.gameObject.CompareTag("enemy"))
                {
                    // �Փ˂����Ƃ��͏���
                    Destroy(gameObject);
                }
            }
        }
    }
}
