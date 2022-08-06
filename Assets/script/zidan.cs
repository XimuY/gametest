using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zidan : MonoBehaviour
{
    public float speed;
    public float flag;

    private float t;

    // Start is called before the first frame update
    void Start()
    {
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(t<flag)
        {
            transform.Translate(new Vector2(speed, 0));
            t += speed;
        }
        else
        {
            DestroyImmediate(this.gameObject);
        }
      
    }
}
