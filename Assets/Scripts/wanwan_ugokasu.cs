using UnityEngine;
public class wanwan_ugokasu : MonoBehaviour
{
    int jump = 400; //�W�����v��y���W
    public static bool end = false; //�����������Ȃ�
    public GameObject butukaru; //��Γ���������A�J��
    int push_count; //����X�y�[�X�L�[�H
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
        if (worldPos.y <= 1.5f) //�W�����v�K�i�ɓK���Ă�����
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            Vector2 force = new Vector2(0, jump);

            //Rigidbody2D�ɗ͂�������
            rb.AddForce(force); //�Ƃ�
            jump_ok = false;
        }
        if (push_count % 10 == 0) //10�����܂������΂��z
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




    //���i�I�I
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
