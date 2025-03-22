using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Transform firePoint;
    public GameObject vfxFirePoint , vfxHitPoint ;
 
    void Update()
    {
        Shooting();
    }// Update
 
    void Shooting()
    {
        Debug.DrawRay( firePoint.position , transform.forward * 60f , Color.green );
        
        RaycastHit hit;
 
        if ( Physics.Raycast ( firePoint.position , transform.forward , out hit , 60f ) )
        {
            Debug.DrawRay(firePoint.position, transform.forward * 60f, Color.red);
            print( hit.collider.name );
            
            if ( Input.GetKeyDown( KeyCode.Space ) )
            {
                Instantiate( vfxFirePoint , firePoint.position , Quaternion.identity );
                Instantiate(vfxHitPoint, hit.point, Quaternion.identity);
                
                if ( hit.collider.name == "Enemy" )
                {
                    Enemy enemy = hit.collider.GetComponent<Enemy>();
 
                    if ( enemy != null )
                    {
                        enemy.TakeDamage( 1 );
                    }
                }
            }// KeyCode.Space
            
        } // Physics.Raycast
        
    }// Shooting
    
}
