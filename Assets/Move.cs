using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Animation animation;
    public GameObject projectile, jet;
    public float launchVelocity = 4000f;
    public Camera MainCamera;
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;
    private float speed = 15f;
    Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x; //extents = size of width / 2
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y; //extents = size of height / 2

        animation = GetComponent<Animation>();
    }

    void LateUpdate(){
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + objectWidth, screenBounds.x - objectWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, -3.5f, screenBounds.y - objectHeight);
       viewPos.z = Mathf.Clamp(viewPos.z, 10f, 10f);
        transform.position = viewPos;
    }
    // Update is called once per frame
    void Update()
    {

        

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * Time.deltaTime * speed);

            float angle = Mathf.MoveTowardsAngle(transform.eulerAngles.y, -60, 500 * Time.deltaTime);
            transform.eulerAngles = new Vector3(-90, angle, 0);

        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * Time.deltaTime * speed);
            float angle = Mathf.MoveTowardsAngle(transform.eulerAngles.y, 60, 500 * Time.deltaTime);
            transform.eulerAngles = new Vector3(-90, angle, 0);

        }
        else if(!Input.anyKey)
        {
            float angle = Mathf.MoveTowardsAngle(transform.eulerAngles.y, 0, 500 * Time.deltaTime);
            transform.eulerAngles = new Vector3(-90, angle, 0);
        }
        
        
        




        /*
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        */
    }
}
