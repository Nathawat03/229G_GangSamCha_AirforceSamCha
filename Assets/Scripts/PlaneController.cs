using System;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    [Header("Plane Stats")]
    [Tooltip("How much the throttle ranps up or down.")]
    public float throttleincrement = 0.1f;
    [Tooltip("Maxinum engine thrust when at 100% throttle.")]
    public float maxthrottle = 200f;
    [Tooltip("How responsive the plane is when rolling, pitching, and yawing.")]
    public float responsiveness = 10f;
    
    private float throttle; // Percentage of maxinum engine thrust currently being used.
    private float roll;     // Tilting left to right.
    private float pitch;    // Tilting front to back.
    private float yaw;      // "Turning" left to right.

    private float responseModifier // Value used to tweak responsiveness to suit plane's mass.
    {
        get
        {
            return (rb.mass / 10f) * responsiveness;
        }
    }
    
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void HeadleInpact()
    {
        // Set rotational values from our axis inputs.
        roll = Input.GetAxis("Roll");
        pitch = Input.GetAxis("Pitch");
        yaw = Input.GetAxis("Yaw");
        
        // Handle throttle value being sure to clanp it between 0 and 100.
        if (Input.GetKey(KeyCode.LeftShift)) throttle += throttleincrement; //เพิ่มความเร็ว
        else if (Input.GetKey(KeyCode.LeftControl)) throttle -= throttleincrement; //ลดความเร็ว
        throttle = Mathf.Clamp(throttle, 0f, 100f);
        
    }// HeadleImpact

    private void Update()
    {
        HeadleInpact();
    }

    private void FixedUpdate()
    {
        // Apply forces to our plane.
        rb.AddForce(transform.forward * maxthrottle * throttle);
        rb.AddTorque(transform.up * yaw * responseModifier);
        rb.AddTorque(transform.right * pitch * responseModifier);
        rb.AddTorque(transform.forward * roll * responseModifier);
    }
}
