using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 300f;
    public float JumpHeight = 5f;
    [SerializeField] UnityEngine.SceneManagement.Scene currentScene;
    private Rigidbody2D rb;
    private Health healthScript;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("EndPassage"))
        {
            SceneManager.LoadScene(currentScene.buildIndex + 1);
        }
        if (collider.gameObject.CompareTag("v o i d"))
        {
            SceneManager.LoadScene(11);
        }
    }
    private void OnCollisionStay2D(Collision2D collision){
        if (collision.gameObject.CompareTag("DarkLiquid"))
        {
            healthScript.updateReason = "DarkLiquid";
            healthScript.Invoke("updateHP", 0.2f);
        }
        else if (collision.gameObject.CompareTag("BossAttack"))
        {
            healthScript.updateReason = "BossAttack";
            healthScript.Invoke("updateHP", 0.2f);
        }
    }
    

    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentScene = SceneManager.GetActiveScene();
        healthScript = GetComponent<Health>();
    }

    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        rb.velocity = movement * speed * Time.fixedDeltaTime;
        
    }



}