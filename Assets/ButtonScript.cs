using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    SpriteRenderer srB1;
    
    [SerializeField] GameObject B1;
    
    [SerializeField] GameObject elevator1;
    
    [SerializeField] float elevator1Min;
    [SerializeField] float elevator1Max;
    

    // Start is called before the first frame update
    void Start()
    {
        srB1 = B1.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
            
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Turn button color to green
        srB1.color = Color.green;
        while (elevator1.transform.position.y != elevator1Max)
        {
            elevator1.transform.Translate(0f, 1f * Time.deltaTime, 0f);
        }
        
        if (elevator1.transform.position.x > elevator1Max)
        {
            elevator1.transform.position = new Vector3(transform.position.x, elevator1Max, 0f);
        }
        /*
        lever2.transform.Translate(0f, 2f * Time.deltaTime, 0f);
        if (lever2.transform.position.x > lever2Max)
        {
            lever2.transform.position = new Vector3(transform.position.x, lever2Max, 0f);
        }*/
        //Turn button back so white.

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        srB1.color = Color.white;
        //srB2.color = Color.white;
        elevator1.transform.Translate(0f, -1f*Time.deltaTime, 0f);
        if (elevator1.transform.position.x < elevator1Min)
        {
            elevator1.transform.position = new Vector3(transform.position.x, elevator1Min, 0f);
        }
        /*
         * lever2.transform.Translate(0f, -2f*Time.deltaTime, 0f);
        if (lever2.transform.position.x < lever1Min)
        {
            lever2.transform.position = new Vector3 (transform.position.x, lever2Min, 0f);
        }*/
    }
}
