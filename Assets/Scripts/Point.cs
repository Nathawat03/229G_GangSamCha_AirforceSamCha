using UnityEngine;

public class Point : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlaneController pc = other.GetComponent<PlaneController>();

        if (pc != null)
        {
            pc.PointCollected();
            gameObject.SetActive(false);
            
        } // 
        
    } // OnTriggerEnter
    
} // Point
