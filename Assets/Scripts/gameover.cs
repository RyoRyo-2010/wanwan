using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public static bool gameover_switch = false;//これをtrueにすると、ゲームオーバーにします。
    public int timer = 15;
    public GameObject camerao;
    public GameObject score;
    float eazing = 0.01f;
    Vector3 targetxyz = new Vector3(-69.6f, 14.9f, -10.0f);
    Vector3 xyz;
    float time;
    //gameover()を実行すると、ゲームオーバーにできます。
    // Start is called before the first frame update
    void Start()
    {
        Transform tr = camerao.transform;
        Vector3 t = tr.position;
        xyz = new Vector3(t.x, t.y, t.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameover_switch) return; //こうすると、めちゃ短い
        
        xyz.x += (targetxyz.x - xyz.x) * eazing;
        xyz.y += (targetxyz.y - xyz.y) * eazing;
        xyz.z += (targetxyz.z - xyz.z) * eazing;
        Transform t = camerao.transform;
        t.position = xyz;
        time += Time.deltaTime;
        if (time >= timer)
        {
            gameover_switch = false;
            wanwan_ugokasu.end = false;
            score_static.time = score_kanri.time;
            SceneManager.LoadScene("kekka");
        }
    }
}
