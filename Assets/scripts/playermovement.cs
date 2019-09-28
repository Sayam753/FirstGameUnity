
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    /* void Start()
    {
        //rb.useGravity = false;
        rb.AddForce(0,200,500); //used only once
    }
    */
    // Update is called once per frame
    public float forward_force=2000f;
    public float sideways_force=500f;


    void FixedUpdate()
    {
        //Debug.Log(10);for printing a statement in console
        rb.AddForce(0,0,forward_force*Time.deltaTime);//it is hardware dependent. So, we need to even the dependency part. 
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideways_force *Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideways_force *Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        // if we add camera to the player,then each rotation of the player is done same by the camera.

        if (rb.position.y < -1f)
        {
            FindObjectOfType<manager>().end_game();
        } 
    }

}
