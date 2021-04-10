using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public float timer;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        	timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1;
    }
}
