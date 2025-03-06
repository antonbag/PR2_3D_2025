using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MueveCubo : MonoBehaviour
{
    float seno = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        seno = Mathf.Sin(Time.time);
        transform.Translate(seno/100,0, 0);
    }
}
