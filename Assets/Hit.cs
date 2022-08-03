using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour
{
    public static int score = 0;
   
    public GameObject explosion;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "nave(Clone)")
        {
            Destroy(explosion);
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Do something here");
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
            score++;

            Instantiate(explosion, transform.position, transform.rotation);
            
            

        }

    }
}

