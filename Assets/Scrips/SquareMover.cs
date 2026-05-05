using System;
using UnityEngine;

public class SquareMover : MonoBehaviour
{
    public float Acceleration = 0.01f;
    public float speed = 0.02f;
   public float xMax= 10f;
    public float xMin = -10f;
    Boolean moving= true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x += speed;
        transform.position = newPosition;
       
      
        
        if (transform.position.x > xMax || transform.position.x < xMin)
        {
            speed = -speed;
        }
       
        
          
    

}}