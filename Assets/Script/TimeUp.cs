using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeUp : MonoBehaviour
{
    GameObject outCome;
    GameObject result;

    // Start is called before the first frame update
    void Start()
    {
        this.outCome = GameObject.Find("OutCome");
        this.result = GameObject.Find("GameDirector");

    }

    // Update is called once per frame
    void Update()
    {
        this.result.GetComponent<GameDirector>().DistanceResult();

        this.outCome.GetComponent<TextMeshProUGUI>().text = "TIME UP !!!" + "\n" + "Result : " + this.result + "\n" + "Z or Buttom0\r\nStart";


        // Fire1‚ğ‰Ÿ‚µ‚½‚çƒV[ƒ“‘JˆÚ
        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
