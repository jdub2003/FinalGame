using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorControls : MonoBehaviour
{
    [SerializeField] float elevatorMin;
    [SerializeField] float elevatorMax;
    [SerializeField] float speed;
    public bool ElevatorActive;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (ElevatorActive)
        {
            
            transform.Translate(speed * Time.deltaTime * Vector3.up);
            if (transform.position.y > elevatorMax)
            {
                transform.position = new Vector3(transform.position.x, elevatorMax, 0f);
            }
        }
        else
        {
            transform.Translate(-speed * Time.deltaTime * Vector3.up);
            if (transform.position.y < elevatorMin)
            {
                transform.position = new Vector3(transform.position.x, elevatorMin, 0f);
            }
        }
    }
    
}
