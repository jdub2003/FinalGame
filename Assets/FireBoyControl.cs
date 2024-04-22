using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBoyControl : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float minX;
    [SerializeField] float maxX;
    [SerializeField] GameObject FireBoyHead;
    [SerializeField] GameObject FireBoyBody;
    Animator HeadAnimator;
    Animator BodyAnimator;
    SpriteRenderer Headsr;
    SpriteRenderer Bodysr;
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
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, speed * Time.deltaTime, 0f);
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
            BodyAnimator.SetBool("Run",false);
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
}
