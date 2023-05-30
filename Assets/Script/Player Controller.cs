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
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        float speed = 0.15f;
        transform.position += new Vector3(x * speed, y * speed, 0);

        if(y < 0)
        {
            this.animator.SetTrigger("Right Trigger");
        }
        if(y > 0)
        {
            this.animator.SetTrigger("Left Trigger");
        }

    }
}
