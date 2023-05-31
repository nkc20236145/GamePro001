using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPrefab;
    float span = 0.3f;   // “G‚ªoŒ»‚·‚éŠÔŠu
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(EnemyPrefab);
            int py = Random.Range(-4, 4);       // “G‚ªoŒ»‚·‚éY²‚Ì”ÍˆÍ
            go.transform.position = new Vector3(9, py, 0);
        }
    }
}
