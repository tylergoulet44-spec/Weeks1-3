using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float speed = 1.0f; // Speed of the bounce
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.y += speed;
        newPosition.x += speed;
        if (transform.position.y > 0.5f || transform.position.y < -0.5f)
        {
            speed *= -1f; // Reverse the direction of the bounce
        }
    }
}
