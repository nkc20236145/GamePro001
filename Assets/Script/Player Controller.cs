using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;

        // �A�j���[�^�[�R���|�[�l���g��animator�ϐ��ɕۑ�
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        float speed = 0.15f;
        transform.position += new Vector3(x * speed, y * speed, 0);

        // �v���C���[�ɃA�j���[�V����������
        if(y == 0)
        {
            this.animator.Play("Flyt Animation");
        }
        else if(y == 1)
        {
            this.animator.Play("Left Animation");
        }
        else
        {
            this.animator.Play("Right Animation");
        }

    }
}
