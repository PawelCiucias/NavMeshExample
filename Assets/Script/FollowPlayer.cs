using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //refrence to the player game obect
    public GameObject Player;

    //refrence to camera Z start point
    private float cameraZ;

    void Start(){
        // save the cameras initial Z point
        this.cameraZ = this.transform.position.z;
    }
    void LateUpdate()
    {
        var x = this.transform.position.x;
        var y = this.transform.position.y;
        //Maintain consitant z distance between Camera & Player
        var z = Player.transform.position.z + cameraZ;

        //update camera position.
        var newCameraPos = new Vector3(x, y, z);
        this.transform.position = newCameraPos;

        //rotate camera to look at the player
        this.transform.LookAt(Player.transform);
    }
}