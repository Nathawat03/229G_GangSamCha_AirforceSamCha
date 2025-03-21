using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Tooltip("An array of transforns representing camera positions.")]
    [SerializeField] Transform[] povs;
    [Tooltip("The speed at which the camera follows the plane.")]
    [SerializeField] float speed;
    
    private int index = 1;
    private Vector3 target;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) index = 0;
        else if (Input.GetKeyDown(KeyCode.Alpha2)) index = 1;
        //else if (Input.GetKeyDown(KeyCode.Alpha3)) index = 2;
        //else if (Input.GetKeyDown(KeyCode.Alpha4)) index = 3;
        
        // Set our target to the relevant POV.
        target = povs[index].position;
        
    } // Update

    private void FixedUpdate()
    {
        // Move camare to desired position/orientation. Must be in FixedUpdate to avoid camera jitters.
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        transform.forward = povs[index].forward;
    }
    
}
