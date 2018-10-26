using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{

    public Text tCount;

    // constants
    private const string H_AXIS = "Horizontal";
    private const string V_AXIS = "Vertical";

    // fields
    // make available in the unity to test
    [SerializeField]
    private float speed = 15f;
    [SerializeField]
    private float xMin = -1.9f;
    [SerializeField]
    private float xMax = 1.9f;

    private GameObject gOb;

    private Rigidbody2D rb;
   

    // Use this for initialization
    void Start()
    {
        // get the current object
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per view frame
    void Update()
    {

    }
    // update with the physics engine
    private void FixedUpdate()
    {
        //        Input.GetKey(KeyCode.UpArrow )
         // get movement on the axes
            float hMovement = Input.GetAxis(H_AXIS);
        float vMovement = Input.GetAxis(V_AXIS);
        // My code 
        if (Input.touchCount > 0)
        {
            hMovement = Input.touches[0].deltaPosition.x;
            vMovement = Input.touches[0].deltaPosition.y;
        }


        // get the current body and change the velocity
        // using the horizontal movement * speed value
        rb.velocity = new Vector3(hMovement * speed,
                                hMovement * speed);


        // Mathf.Clamp
        // work out the xValue based on the limits
        float xValue = Mathf.Clamp(rb.position.x, xMin, xMax);

        // keep position.x between two values
        rb.position = new Vector2(xValue, rb.position.y);



    }
}

// Touch Position


/* 
 *     if (Input.touchCount > 0) {
       
        float target;
        touchPosition = Input.GetTouch (0).position;
        if (touchPosition.x > Screen.width / 2) {
            target = 1;
        } else {
            target = -1;
        }
     
        moveHorizontal = Mathf.MoveTowards(moveHorizontal, target, sensitivity * Time.deltaTime);
     
    } else {
        moveHorizontal = (moveHorizontal < dead) ? 0 : Mathf.MoveTowards(moveHorizontal, 0, sensitivity * Time.deltaTime);
    }
*/
