//added UnityEngine namespaces 
using UnityEngine;
using UnityEngine.AI;
public class PlayerController : MonoBehaviour
{
    //reference of the camera to know what the user
    //clicked on
    public Camera Camera;

    //refernce to the thing that will move
    public NavMeshAgent Agent;

    //Create an enum for mouse buttons 
    enum MouseButton{ Left = 0, Right = 1, Scroll = 3 }

    // Update is called once per frame
    void Update()
    {
        //check if the user left clicked on something
        if(Input.GetMouseButtonDown((int)MouseButton.Left)){
            //what did the user click on
            RaycastHit hit;
            
            //where did the user click on the screen
            var pos = Input.mousePosition;

            //where from the camera's perspective 
            //did the user click
            var ray = Camera.ScreenPointToRay(pos);

            //did the user click on an object
            if(Physics.Raycast(ray, out hit))
                //send the agent to the point the user 
                //clicked on
                Agent.SetDestination(hit.point);
        }
    }
}
