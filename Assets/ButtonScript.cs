using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    
    //[SerializeField] GameObject B1;
    //[SerializeField] GameObject B2; 
    [SerializeField] GameObject elevator1;
    //[SerializeField] GameObject elevator2;
    //[SerializeField] float elevator1Min;
    //[SerializeField] float elevator1Max;
    //[SerializeField] float elevator2Min;
    //[SerializeField] float elevator2Max;
    SpriteRenderer sr;    
    bool elevatorActivated;
    ElevatorControls elevatorControls;
    // Start is called before the first frame update
    void Start()
    {
        elevatorControls = elevator1.GetComponent<ElevatorControls>();
        sr = GetComponent<SpriteRenderer>();
       // srB2 = B2.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (elevatorActivated == true )
        {
            Debug.Log("Called Active" + Time.frameCount);
            ActivateElev();
        }
        else
        {
            Debug.Log("Called DeActive"+Time.frameCount);
            DeactivateElev();
        }*/
    }
    /*
    public void ActivateElev()
    {
        //srB1.color = Color.green;
       // srB2.color = Color.green;
        while (elevator1.transform.position.y <= elevator1Max)
        {
            elevator1.transform.Translate(speed * Time.deltaTime * Vector3.up);
            if(elevator1.transform.position.y == elevator1Max)
            {
                break;
            }
        }
        while (elevator2.transform.position.y <= elevator2Max)
        {
            elevator2.transform.Translate(speed * Time.deltaTime * Vector3.up);
            if (elevator2.transform.position.y == elevator2Max)
            {
                break;
            }
        }

        Debug.Log("Up:"+elevator1.transform.position.y) ;
        elevator1.transform.Translate(speed * Time.deltaTime * Vector3.up);
        if (elevator1.transform.position.y > elevator1Max)
        {
            elevator1.transform.position = new Vector3(elevator1.transform.position.x, elevator1Max, 0f);
        }
        elevator2.transform.Translate(speed* Time.deltaTime * Vector3.up);
        if (elevator2.transform.position.y > elevator2Max)
        {
            elevator2.transform.position = new Vector3(elevator2.transform.position.x, elevator2Max, 0f);
        }
    }
    public void DeactivateElev()
    {
        srB1.color = Color.white;
        srB2.color = Color.white;
        Debug.Log("Down:" + elevator1.transform.position.y);
        elevator1.transform.Translate(-speed * Time.deltaTime * Vector3.up);
        if (elevator1.transform.position.y < elevator1Min)
        {
            elevator1.transform.position = new Vector3(elevator1.transform.position.x, elevator1Min, 0f);
        }
        elevator2.transform.Translate(-speed * Time.deltaTime * Vector3.up);
        if (elevator2.transform.position.y < elevator2Min)
        {
            elevator2.transform.position = new Vector3(elevator2.transform.position.x, elevator2Min, 0f);
        }
        //elevatorActivated = false; 

    }*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //call elevator up
        sr.color = Color.green;
        elevatorControls.ElevatorActive=true;
        //elevatorActivated = true;
       // Debug.Log("Enter");

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        sr.color = Color.white;
        //call elevator down
        elevatorControls.ElevatorActive=false;
       // elevatorActivated = false;
        //Debug.Log("Exit");

    }




}
