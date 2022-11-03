using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kekka_hyouzi : MonoBehaviour
{
    [SerializeField]
    Text kekka_text;
    // Start is called before the first frame update
    void Start()
    {
        kekka_text.text = $"今回のスコアは、{score_static.time.ToString("0.0")}でした。";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
