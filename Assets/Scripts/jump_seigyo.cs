using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jump_seigyo : MonoBehaviour
{
    //wanにアタッチしています
    bool tobimasita;
    float nokori = 1.5f;
    [SerializeField]
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(wanwan_ugokasu.jump_ok == false)
        {
            nokori -= Time.deltaTime;
            text.text = "ジャンプ可能まで:" + nokori.ToString("0.0");
            if(nokori <= 0)
            {
                wanwan_ugokasu.jump_ok = true;
                nokori = 1.5f;
            }
        }
    }
}
