using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] TMP_Text ScoreFireBoy;
    [SerializeField] TMP_Text ScoreWaterGirl;
    [SerializeField] GameObject Firedoor;
    [SerializeField] GameObject Waterdoor; 
    public int ScoreF=0;
    public int ScoreW=0;
    FireDoor firedoor;
    WaterDoor waterdoor;
    

    // Start is called before the first frame update
    void Start()
    {
        
        firedoor = Firedoor.GetComponent<FireDoor>();
        waterdoor = Waterdoor.GetComponent<WaterDoor>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreFireBoy.text = ScoreF.ToString();
        ScoreWaterGirl.text = ScoreW.ToString();
        //if they are at their doors then end the game
        if(firedoor.FBAtEndDoor==true && waterdoor.WGAtEndDoor == true)
        {
            canvas.SetActive(true);
        }
        else
        {
            canvas.SetActive(false);
        }


    }
   
}
