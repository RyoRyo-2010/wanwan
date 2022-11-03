using UnityEngine;
public class wanwan_ugokasu : MonoBehaviour
{
    int jump = 400; //ジャンプのy座標
    public static bool end = false; //もう動かさない
    public GameObject butukaru; //絶対当たったらアカン
    int push_count; //何回スペースキー？
    public static bool jump_ok = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (end) return;

        Transform myTransform = this.transform;
        Vector3 worldPos;


        if(Input.GetKeyDown(KeyCode.Space))
        {
            goto ikuyo;
        }

        Touch[] ts = Input.touches;
        foreach (Touch t in ts)
        {
            if (t.phase == TouchPhase.Ended)
            {
                goto ikuyo;
            }
        }
        return;

    ikuyo:
        if (!jump_ok) return;
        push_count++;
        worldPos = myTransform.position;
        if (worldPos.y <= 1.5f) //ジャンプ規格に適していたら
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            Vector2 force = new Vector2(0, jump);

            //Rigidbody2Dに力を加える
            rb.AddForce(force); //とぶ
            jump_ok = false;
        }
        if (push_count % 10 == 0) //10こたまったらやばい奴
        {
            Instantiate(butukaru, new Vector2(20, -3.86f), Quaternion.identity);
        }
    }
    //y< -18
    //worldPos = myTransform.position;
    //if (worldPos.y < -18)
    //{
    //    gameover.gameover_switch = true;
    //}




    //合格！！
    private void OnTriggerEnter2D(Collider2D collision)
    {

        print(collision.gameObject.name);
        if (collision.gameObject.name == "kumo")
        {
            gameover.gameover_switch = true;
            end = true;
        }
        if (collision.gameObject.name == "otita_hantei")
        {
            gameover.gameover_switch = true;
            end = true;
        }
    }
}
