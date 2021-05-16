using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crash : MonoBehaviour

   
{
    public GameObject bass;
    public float power;
    Animator anim;
   // public GameObject wall;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("ball"))
        {
            bass.GetComponent<Rigidbody2D>().AddForce(Vector3.right * power);
            
            
        }
    }


}
