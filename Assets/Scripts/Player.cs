using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpSpeed;
    public GameManager game;
    Rigidbody2D rb;
    AudioSource jumpSource;
    bool endGame;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Pipe.speed = 0;
        jumpSource = GetComponent<AudioSource>();
        endGame = false;


    }

    void Update()
    {
        transform.eulerAngles = new Vector3(0, 0, rb.velocity.y*5f);

        if(!endGame)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0)) //KeycCode.Mouse0 ant telefono
            {
                game.StartGame();
                Pipe.speed = 3.5f;
                rb.simulated = true;
                rb.velocity = new Vector2(0, jumpSpeed);
                jumpSource.Play();
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        game.EndGame();
        Pipe.speed = 0;
        endGame = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(!endGame) game.score++;
    }
}
