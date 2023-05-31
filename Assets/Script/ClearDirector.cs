using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Fire1‚ğ‰Ÿ‚µ‚½‚çƒV[ƒ“‘JˆÚ
        if(Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
