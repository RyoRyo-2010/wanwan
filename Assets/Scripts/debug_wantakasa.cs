using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debug_wantakasa : MonoBehaviour
{
    public bool start = false;
    public float max_y = -20;
    public float min_y;
    Transform t;
    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            Vector3 takasa = t.position;
            if(takasa.y > max_y)
            {
                max_y = takasa.y;
            }
            if(takasa.y < min_y)
            {
                min_y = takasa.y;
            }
        }
    }
}
