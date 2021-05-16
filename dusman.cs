using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("stop", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("ball"))
        {
            Debug.Log("dusman degdi");
            anim.SetBool("stop", true);
        }
    }
}
