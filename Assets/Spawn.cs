using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{

    public Vector3 center, size;
    public GameObject o;
    Rigidbody rb;
    private float time = 0.0f;
    public static int wave = 1;
    private int count = 5;
    public Text waves, scores;

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        scores.text = "Score: " + Hit.score;
        waves.text = "Wave: " + wave;
        time += Time.deltaTime;
        if (time >= 2.5 && count>0)
        {
            time = 0.0f;
            SpawnObject();
            count--;          
        }
        if (time >= 18)
        {
            wave++;
            count = 5;
        }
    }

    public void SpawnObject()
    {
        Vector3 pos =  new Vector3(transform.position.x, transform.position.y, transform.position.z+10);
        //GameObject c = Instantiate(o, pos, Quaternion.identity) as GameObject;
        GameObject ball = Instantiate(o, pos, transform.rotation);
        rb = ball.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.down * 5);
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
       
    }
}