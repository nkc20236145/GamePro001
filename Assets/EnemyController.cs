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
        // �t���[�����ɓ����ŉE���獶�֗���
        transform.Translate(-0.1f, 0, 0);

        //��ʊO�ɏo����j��
        if(transform.position.x < -10.0f)
        {
            Destroy(gameObject);
        }

        // �����蔻��
        {
            Vector2 e1 = transform.position;
            Vector2 p1 = this.player.transform.position;
            Vector2 dir = e1 - p1;
            float d = dir.magnitude;
            float er = 0.5f;
            float pr = 1.0f;

            if(d < er + pr)
            {
                // �ēX�N���v�g�Ƀv���C���[�ƏՓ˂������Ƃ�`����
                GameObject director = GameObject.Find("GameDirector");
                director.GetComponent<GameDirector>().DecreaseTime();

                // �Փ˂����Ƃ��͏���
                Destroy (gameObject);
            }
        }
    }
}
