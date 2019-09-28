using UnityEngine;

public class player_collision : MonoBehaviour
{
    //tags are used to group things together.
    public playermovement movement; 
    void OnCollisionEnter(Collision collision_Info)
    {
        //Debug.Log(collision_Info.collider.name);

        if (collision_Info.collider.tag == "Obstacle")
        {
            //we need to disable the movement after hitting the obstacle.
            //Debug.Log("We hit a cube.");
            GetComponent<playermovement>().enabled = false;
            FindObjectOfType<manager>().end_game();

        }
    }
}
