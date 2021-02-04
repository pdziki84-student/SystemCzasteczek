using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameController : MonoBehaviour
{
    bool play = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            play = !play;
        
        if (play)
            transform.GetComponent<ParticleSystem>().Play(true);
        else
            transform.GetComponent<ParticleSystem>().Stop(true);
    }
}
