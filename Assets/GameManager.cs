using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] TMP_Text ScoreFireBoy;
    [SerializeField] TMP_Text ScoreWaterGirl;
    public int ScoreF=0;
    public int ScoreW=0;
    [SerializeField] GameObject WaterGirl;
    [SerializeField] GameObject FireBoy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreFireBoy.text = ScoreF.ToString();
        ScoreWaterGirl.text = ScoreW.ToString();
        //if they are at their doors them end the game
        if(WaterGirl.transform.position.x<=11.93 && WaterGirl.transform.position.x>= 11.4&& WaterGirl.transform.position.y <= 7 && WaterGirl.transform.position.y >= 6.5&& FireBoy.transform.position.x <= 10.14 && FireBoy.transform.position.x >= 9.54 && FireBoy.transform.position.y <= 7 && FireBoy.transform.position.y >= 6.5)
        {
            canvas.SetActive(true);
        }


    }
   
}
