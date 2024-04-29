using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterHeadControl : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float forceY = 10f;
    [SerializeField] float minX;
    [SerializeField] float maxX;
    [SerializeField] GameObject WaterGirlHead;
    [SerializeField] GameObject WaterGirlBody;
    [SerializeField] GameObject FireBoy;
    Rigidbody2D rb;
    Animator HeadAnimator;
    Animator BodyAnimator;
    SpriteRenderer Headsr;
    SpriteRenderer Bodysr;
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindAnyObjectByType<GameManager>();
        rb = GetComponent<Rigidbody2D>();
        HeadAnimator = WaterGirlHead.GetComponent<Animator>();
        BodyAnimator = WaterGirlBody.GetComponent<Animator>();
        Headsr = WaterGirlHead.GetComponent<SpriteRenderer>();
        Bodysr = WaterGirlBody.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //WaterGirl (Up,Left,Right arrows)
        //jump
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(forceY * Vector2.up);
            HeadAnimator.SetBool("Jump", true);
            BodyAnimator.SetBool("Jump", true);
            //transform.Translate(0f,speed)
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            HeadAnimator.SetBool("Run", true);
            BodyAnimator.SetBool("Run", true);
            Headsr.flipX = false;
            Bodysr.flipX = false;
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            HeadAnimator.SetBool("Run", true);
            BodyAnimator.SetBool("Run", true);
            Headsr.flipX = true;
            Bodysr.flipX = true;
            transform.Translate(-speed * Time.deltaTime, 0f, 0f);

        }
        else
        {
            HeadAnimator.SetBool("Run", false);
            BodyAnimator.SetBool("Run", false);
        }

        if (transform.position.x < minX)
        {
            transform.position = new Vector3(minX, transform.position.y, 0f);
        }
        if (transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y, 0f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            HeadAnimator.SetBool("Jump", false);
            BodyAnimator.SetBool("Jump", false);
        }
       
        if (collision.gameObject.CompareTag("lava"))//set both players to start
        {
            transform.position = new Vector3(-10.72f, -3.47f, 0f);

            FireBoy.transform.position = new Vector3(-10.54f, -4.44f, 0f);
        }
        if (collision.gameObject.CompareTag("slime"))//set both players to start
        {
            transform.position = new Vector3(-10.72f, -3.47f, 0f);

            FireBoy.transform.position = new Vector3(-10.54f, -4.44f, 0f);
        }

        //if (collision.gameObject.CompareTag("waterdoor"))
        //display the end game points round over thanks for playing screen 
        if (collision.gameObject.CompareTag("blueGem"))
        {
            gm.ScoreW = gm.ScoreW + 1; 
            Destroy(collision.gameObject);
        }

    }


}
