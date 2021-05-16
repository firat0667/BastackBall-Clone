using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engel2 : MonoBehaviour
     
{
    public GameObject engell2;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        engell2.SetActive(false);
        anim = GetComponent<Animator>();
        anim.SetBool("stop", false);
        engell2.SetActive(false);
      

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("ball"))
            {
                Debug.Log("dokundu");
                anim.SetBool("stop", true);
                engell2.SetActive(true);

            }
    }
}
