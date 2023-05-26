using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGenerator : MonoBehaviour
{
    public GameObject shotPrefab;
    GameObject player;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire3"))
        {
            GameObject go  = Instantiate(shotPrefab);
            Vector3 playerPos = this.player.transform.position;
            go.transform.position = new Vector3(playerPos.x, playerPos.y + 1, transform.position.z);

        }
    }
}
