using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class jump : MonoBehaviour
{

    
    public float jumpAmount = 100;
    public GameObject ball;
    private Rigidbody2D rgb;
    public GameObject balleffect;
    public GameObject engell3;
    public GameObject engell4;
    public GameObject engell5;
    public GameObject engell6;
    public GameObject engell7;
    public GameObject engell8;
    public GameObject engell9;
    public GameObject engell10;
    public float y;
    private Scene scene2;
    public int score;
    public int gold;
    public TextMeshProUGUI playerscore;
    public TextMeshProUGUI goldscore;
    public GameObject congratulations;
    public GameObject complitedmusic;
    public GameObject hitmusic;
    public GameObject backgraundmusic;
    public GameObject jumpmusic;
    public Slider slider;
   





    IEnumerator waitbefore()
    {

        yield return new WaitForSeconds(1f);
        engell5.SetActive(true);



    }
    IEnumerator waitbefore2()
    {
        yield return new WaitForSeconds(0.5f);
        engell9.SetActive(true);
    }
    IEnumerator waitbefore3()
    {
        yield return new WaitForSeconds(1f);
        engell10.SetActive(true);
    }
    IEnumerator restart()
    {
        yield return new WaitForSeconds(2f);
        Application.LoadLevel(scene2.name);
    }

    public void repeat()
    {
        Application.LoadLevel(scene2.name);
    }
 

    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        engell3.SetActive(false);
        engell4.SetActive(false);
        engell5.SetActive(false);
        engell6.SetActive(false);
        engell7.SetActive(false);
        engell8.SetActive(false);
        engell9.SetActive(false);
        engell10.SetActive(false);
        scene2 = SceneManager.GetActiveScene();
        score = 0;
        complitedmusic.SetActive(false);
        hitmusic.SetActive(false);
        backgraundmusic.SetActive(true);
        jumpmusic.SetActive(false);
        gold = 0;
       
       
        



    }

    // Update is called once per frame
    void Update()
    {
        playerscore.text = score.ToString();
        goldscore.text = gold.ToString();
        y = ball.transform.position.y;

        

        if (Input.GetMouseButtonDown(0) && Mathf.Approximately(rgb.velocity.y, 0))
        {
            rgb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);

            transform.rotation = Quaternion.Euler(180f, 0f, 0f);
           



        }
       
        
        if (Mathf.Approximately(rgb.velocity.y, 0))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            balleffect.SetActive(true);



        }
        else
        {
            balleffect.SetActive(false);
        }


        if (-1.6f<y  && y<-0.4f && Mathf.Approximately(rgb.velocity.y, 0))
        {
            
            engell3.SetActive(true);
          //  StartCoroutine(waitbefore());

        }
         if(y > -0.4f && y <0.94f && Mathf.Approximately(rgb.velocity.y, 0)) 
        {
            
            engell4.SetActive(true);

        }


         if(y > 0.94f && y<2.17f && Mathf.Approximately(rgb.velocity.y, 0))
        {

            StartCoroutine(waitbefore());
        }
        if (y > 2.17f && y<3.4f && Mathf.Approximately(rgb.velocity.y, 0))
        {
            engell6.SetActive(true);
        }
        if (y>3.4f && y<4.7f && Mathf.Approximately(rgb.velocity.y, 0))
        {
            engell7.SetActive(true);
        }
        if (y > 4.7f && y<6f &&   Mathf.Approximately(rgb.velocity.y, 0))
        {
            engell8.SetActive(true);
        }
        if (y > 5.8f &&  y<7.1f && Mathf.Approximately(rgb.velocity.y, 0))
        {
            StartCoroutine(waitbefore2());
        }
        if (y > 7.1f && Mathf.Approximately(rgb.velocity.y, 0))
        {
            StartCoroutine(waitbefore3());
        }
        if(y > 8.4f && Mathf.Approximately(rgb.velocity.y, 0))
        {
            Time.timeScale = 0;
            congratulations.SetActive(true);
            complitedmusic.SetActive(true);
            backgraundmusic.SetActive(false);
        }



        if (ball.transform.position.y <= -25)
        {
            hitmusic.SetActive(true);

            StartCoroutine(restart());

           

           

           




        }


        
    }

    public void timescale()
    {
        Time.timeScale = 0;
    }

    

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("enemy"))
        {
            ball.GetComponent<Rigidbody>().AddForce(Vector3.right * 200f);
        }

        if (collision.gameObject.tag.Equals("engel"))
        {
            score += score + 1;
            jumpmusic.SetActive(true);
            gold += 10;
            slider.value += 7;

           


        }
        else
        {
            jumpmusic.SetActive(false);
        }
       
    }
    
   

}

