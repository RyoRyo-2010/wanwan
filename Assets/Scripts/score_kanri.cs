using UnityEngine;
using UnityEngine.UI;
public class score_kanri : MonoBehaviour
{
    public static float time;
    public GameObject kakusu;
    Text text;
    bool sinai = true;
    //true->������
    //false->�������ē�������
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!sinai) return;

        if (!wanwan_ugokasu.end)
        {
            time += Time.deltaTime;
            text.text = "�X�R��:" + time.ToString("0.0");

        }
        else
        {
            gameObject.SetActive(false);
            kakusu.SetActive(false);
            sinai = false;
        }

    }
}
