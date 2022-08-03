using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Vector3 down, up, left;
    private Vector3 right;
    private bool stop, vert = false;
    private int distance;
    private float time = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        down = new Vector3(0, -90, 0);
        right = new Vector3(-120, 0, 0);
        left = new Vector3(120, 0, 0);
        up = new Vector3(0, 90, 0);


    }

    // Update is called once per frame
    void Update()
    {
        
        if (Spawn.wave%2 !=0)
            square();
        else     
            diamond();



    }

    void square()
    {
        time += Time.deltaTime;

        if (time < 4)
            transform.Translate(down * Time.deltaTime / 50);

        else if (time < 7)
            transform.Translate(right * Time.deltaTime / 50);

        else if (time < 9)
            transform.Translate(up * Time.deltaTime / 50);

        else if (time < 30)
            transform.Translate(left * Time.deltaTime / 50);

    }

    void diamond()
    {
        time += Time.deltaTime;
        if (time < 4)
        {
            transform.Translate(down * Time.deltaTime / 50);
            transform.Translate(right * Time.deltaTime / 50);
        }
        else if (time < 6)
        {
            transform.Translate(down * Time.deltaTime / 50);
            transform.Translate(left * Time.deltaTime / 50);

        }
        else if (time < 10)
        {
            transform.Translate(up * Time.deltaTime / 50);
            transform.Translate(left * Time.deltaTime / 50);

        }
        else if (time < 15)
        {
            transform.Translate(down * Time.deltaTime / 50);
            transform.Translate(left * Time.deltaTime / 50);

        }


    }
}
