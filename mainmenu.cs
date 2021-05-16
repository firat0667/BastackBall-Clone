using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class mainmenu : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject mainmenuu;
    public GameObject mainmenuu2;
    public GameObject awesome;
   
    void Start()
    {
        Time.timeScale = 0;
        mainmenuu2.SetActive(false);
    }

   public void playgame()
    {
        mainmenuu.SetActive(false);
        Time.timeScale = 1f;
        mainmenuu2.SetActive(false);
        

    }
    public void quitgame()
    {
        Debug.Log("çýktýk");
        Application.Quit();
    }
    public void optionsgame()
    {

    }
    public void pausegame()
    {
        Time.timeScale = 0;
        mainmenuu2.SetActive(true);
        
       
    }

    public void backgame()
    {
        awesome.SetActive(false);
}
   
}
