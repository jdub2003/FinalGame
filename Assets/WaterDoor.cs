using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDoor : MonoBehaviour
{
    public bool WGAtEndDoor = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("watergirl"))
        {
            WGAtEndDoor = true;
        }
    }
}
