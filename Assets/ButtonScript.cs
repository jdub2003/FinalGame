using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    SpriteRenderer srB1;
    SpriteRenderer srB2;
    //[SerializeField] GameObject Player;
    [SerializeField] GameObject B1;
    [SerializeField] GameObject B2; 
    [SerializeField] GameObject elevator1;
    [SerializeField] GameObject elevator2;
    [SerializeField] float elevator1Min;
    [SerializeField] float elevator1Max;
    [SerializeField] float elevator2Min;
    [SerializeField] float elevator2Max;
    bool elevatorActivated; 

    // Start is called before the first frame update
    void Start()
    {
        srB1 = B1.GetComponent<SpriteRenderer>();
        srB2 = B2.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(elevatorActivated)
        {
            ActivateElev();
        }
        else
        {
            DeactivateElev();
        }
    }
    public void ActivateElev()
    {
        srB1.color = Color.green;
        srB2.color = Color.green;
        //Make the elevator a parent of the player so it move swith the elevator
        //Player.SetParent(elevator1);
        elevator1.transform.Translate(2f * Time.deltaTime * Vector3.up);
        if (elevator1.transform.position.y > elevator1Max)
        {
            elevator1.transform.position = new Vector3(elevator1.transform.position.x, elevator1Max, 0f);
        }
        

        elevator2.transform.position = new Vector3(elevator2.transform.position.x, elevator2Max, 0f);
    }
    public void DeactivateElev()
    {
        srB1.color = Color.white;
        srB2.color = Color.white;
        //Player.SetParent(null);
        elevator1.transform.position = new Vector3(elevator1.transform.position.x, elevator1Min, 0f);


        elevator2.transform.position = new Vector3(elevator2.transform.position.x, elevator2Min, 0f);
        elevatorActivated = false; 

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        elevatorActivated = true; 

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        elevatorActivated = false;

    }




}
