using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GameObject result = GameObject.Find("GameDirector");
        result.GetComponent<GameDirector>().DistanceResult();

        GetComponent<TextMeshProUGUI>().text = "TIME UP !!!" + "\n" + "Result : " + result + "\n" + "Z or Buttom0\r\nStart";


        // Fire1‚ğ‰Ÿ‚µ‚½‚çƒV[ƒ“‘JˆÚ
        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
