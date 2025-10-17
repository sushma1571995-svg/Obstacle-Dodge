using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] GameObject Projecttile;
    [SerializeField] GameObject Projecttile1;
    [SerializeField] GameObject Projecttile2;
    [SerializeField] GameObject Projecttile3;
    [SerializeField] GameObject Projecttile4;

    
        
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Projecttile.SetActive(true);
            Projecttile1.SetActive(true);
            Projecttile2.SetActive(true);
            Projecttile3.SetActive(true);
            Projecttile4.SetActive(true);
            
        }
    }
}
