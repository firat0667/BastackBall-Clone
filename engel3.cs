using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engel3 : MonoBehaviour
{
    public GameObject ball;
    public GameObject engell3;
   
   
    Animator anim;


    void Start()
    {
        
       
       
       
       
        anim = GetComponent<Animator>();
    }

    private void StartCoroutine(Func<IEnumerator> waitfor)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {


        
        




    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("ball"))
        {
            anim.SetBool("stop",true);
        }
    }
  
}


   
    
