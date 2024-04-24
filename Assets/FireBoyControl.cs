using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBoyControl : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jump;
    [SerializeField] float minX;
    [SerializeField] float maxX;
    [SerializeField] GameObject FireBoyHead;
    [SerializeField] GameObject FireBoyBody;
    [SerializeField] GameObject WaterGirl;
    Animator HeadAnimator;
    Animator BodyAnimator;
    SpriteRenderer Headsr;
    SpriteRenderer Bodysr;
    //bool onGround=true;
    // Start is called before the first frame update
    void Start()
    {
        HeadAnimator=FireBoyHead.GetComponent<Animator>();
        BodyAnimator= FireBoyBody.GetComponent<Animator>();
        Headsr= FireBoyHead.GetComponent<SpriteRenderer>();
        Bodysr= FireBoyBody.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
            //FireBoy (W,A,D arrows)
            //jump
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.Translate(0f, jump * Time.deltaTime, 0f);
                HeadAnimator.SetBool("Jump", true);
                BodyAnimator.SetBool("Jump", true);
                //transform.Translate(0f,speed)
            }
            if (Input.GetKey(KeyCode.D))
            {
                HeadAnimator.SetBool("Run", true);
                BodyAnimator.SetBool("Run", true);
                Headsr.flipX = false;
                Bodysr.flipX = false;
                transform.Translate(speed * Time.deltaTime, 0f, 0f);
            }
            else if (Input.GetKey(KeyCode.A))
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
        if (collision.gameObject.CompareTag("water"))//set both players to start
        {
            transform.position = new Vector3(-10.54f,-4.44f,0f);

            WaterGirl.transform.position = new Vector3(-10.72f,-3.47f,0f);
        }
        if (collision.gameObject.CompareTag("firedoor"))
        {
            //show end screen and display final points
        }
        if (collision.gameObject.CompareTag("redGem"))
        {
            Destroy(collision.gameObject);
        }
    }
   
}
