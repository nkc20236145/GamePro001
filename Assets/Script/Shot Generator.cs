using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGenerator : MonoBehaviour
{
    public GameObject shotPrefab;
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        // Fire3����������e������
        if(Input.GetButtonDown("Fire3"))
        {
            GameObject go  = Instantiate(shotPrefab);

            // �v���C���[�̑O�ɒe���o��������
            Vector3 playerPos = this.player.transform.position;
            go.transform.position = new Vector3(playerPos.x + 1, playerPos.y, transform.position.z);

        }
    }
}