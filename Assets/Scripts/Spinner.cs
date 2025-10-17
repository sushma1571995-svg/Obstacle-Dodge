using UnityEngine;
using UnityEngine.UIElements;

public class Spinner : MonoBehaviour
{

    [SerializeField] float xRotate;
    [SerializeField] float yRotate;
    [SerializeField] float zRotate;
      
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotate, yRotate, zRotate);
    }
}
