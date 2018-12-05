using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[System.Serializable]
public class Boundary
{
    public float xMin, xMax;
}

public class PlayerBehaviour : MonoBehaviour
{


    public GameObject RestartPanel;

    public Boundary boundary;
    public Text tCount;

    public Slider HealthBarPlayer;
    public int HP;
    // constants
    private const string H_AXIS = "Horizontal";
    private const string V_AXIS = "Vertical";

   
   /* [SerializeField]
    private float xMin = -6.9f;
    [SerializeField]
    private float xMax = 6.9f;
    */

    private GameObject gOb;

    private Rigidbody2D rb;


    // Use this for initialization
    void Start()
    {
        // get the current object
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per view frame

    
    // update with the physics engine
    private void FixedUpdate()
    {
        
        // get movement on the axes
        float hMovement = Input.GetAxis(H_AXIS);
       // float vMovement = Input.GetAxis(V_AXIS);
        // My code getting touch for horizontal movement
        if (Input.touchCount > 0)
        {
            hMovement = Input.touches[0].deltaPosition.x;

        }


        // get the current body and change the velocity
        // using the horizontal movement * 10
        rb.velocity = new Vector2(hMovement * 10, hMovement * 0);


        // Mathf.Clamp
        // work out the xValue based on the limits
        float xValue = Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax);


        // keep position.x between two values
        rb.position = new Vector2(xValue, rb.position.y);

    //look at health to see points we have
    HealthBarPlayer.value = HP;

        /*if (HP == 0)
        {
            Destroy(gameObject);
        }*/
    }

void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "EnemyShipTag" )
        {
            HP--;
            
        }
        if (HP == 0)
        {
            RestartPanel.SetActive(true);
            Time.timeScale = 0.0f;
            //Destroy(gameObject);
        }
    }
}
