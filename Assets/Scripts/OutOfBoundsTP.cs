using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class OutOfBoundsTP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -30)
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
