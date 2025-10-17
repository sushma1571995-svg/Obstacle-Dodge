using UnityEngine;

public class Mover : MonoBehaviour
{


    [SerializeField] float moveSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
      float yValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float zValue = 0f;
        

      transform.Translate(xValue,yValue,zValue);
    }
}