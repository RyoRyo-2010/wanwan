using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ura_start : MonoBehaviour
{
    public Text text;
    public GameObject prehub;
    public int nanbiki = 5;
    public float kankaku = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Timer()
    {
        text.text = "のこり3びょう...";
        yield return new WaitForSeconds(1);
        text.text = "のこり2びょう...";
        yield return new WaitForSeconds(1);
        text.text = "のこり1びょう...";
        yield return new WaitForSeconds(1);
        text.text = "スタート!";
        yield return new WaitForSeconds(1);
        text.text = "";
        float x = 20;
        for(int i = 0;i < Random.Range(nanbiki, nanbiki+5);i++)
        {
            Instantiate(prehub, new Vector2(x,-3.86f), Quaternion.identity);
            x += Random.Range(kankaku, kankaku + 10);
        }
        

    }
}
