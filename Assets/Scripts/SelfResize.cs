using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SelfResize : MonoBehaviour
{
    private Transform playerTransform;
    public float minSize = 0.25f, maxSize = 0.5f;
    public float scaleChange;
    private PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = transform;
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (playerTransform.localScale.x <= 0.375f)
            {
                scaleChange = maxSize - playerTransform.localScale.x;
                playerTransform.localScale += new Vector3 (scaleChange, scaleChange, scaleChange);
                playerMovement.speed = 450f;
                
            }
            else
            {
                scaleChange = playerTransform.localScale.x - minSize;
                playerTransform.localScale -= new Vector3(minSize, minSize, minSize);
                playerMovement.speed = 300f;
            }
        }
    }
}
