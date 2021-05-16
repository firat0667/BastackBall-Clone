using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class dead : MonoBehaviour
{
    public GameObject ball;
    public GameObject wall;
   


   
  
  
    public float distance;
    
    public float speed;
    float x;
    float y;
    Animator anim;

    NavMeshAgent agent;
   

    void Start()
    {

       
        StartCoroutine(wait());
        agent = this.GetComponent<NavMeshAgent>();

          


    }

    // Update is called once per frame

    void Update()
    {
        agent.destination = wall.transform.position;
       
       
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("ball")) {

           

        }
    }


    IEnumerator wait()
    {
        yield return new WaitForSeconds(2);
    }
}
