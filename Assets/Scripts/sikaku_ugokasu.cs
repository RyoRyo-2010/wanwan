using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class sikaku_ugokasu : MonoBehaviour
{
    public float step = 1.0f;
    public float reset_x = -18; //ÇÊÇËè¨Ç≥Ç¢
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(-step, 0, 0);
        Transform myTransform = this.transform;
        Vector3 worldPos = myTransform.position;
        if (worldPos.x < -18)
        {
            myTransform = this.transform;
            worldPos = myTransform.position;
            worldPos.x = 20.0f;
            myTransform.position = worldPos;
        }
    }
}
