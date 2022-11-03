using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atattarayabai : MonoBehaviour
{
    public float step = 1.0f;
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
            Destroy(this.gameObject);
        }
    }
}
