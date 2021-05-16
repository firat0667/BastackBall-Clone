using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engell : MonoBehaviour
{
    public float movespeed=2;
    float x;
    float y;
    public GameObject engel;
    public GameObject ball;
   
    Animator anim;
   
    void Start()
    {
        x = engel.transform.position.x;
        x -= x * Time.deltaTime * movespeed;
        anim = GetComponent<Animator>();
         anim.SetBool("stop", false);
        engel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {

      
        if (collision.gameObject.tag.Equals("ball"))
        {
            Debug.Log("dokundu");
            anim.SetBool("stop", true);
            engel.SetActive(true);
            
        }
    }
  
}
