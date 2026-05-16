using UnityEngine;
using UnityEngine.InputSystem;

public class NewTimer : MonoBehaviour
{
    float progress = 0f; 
    public float durration = 3f;
    public float speed = 0.02f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (progress < durration)
        {
            progress += Time.deltaTime;
        }
        else
        {
            Vector3 newPosition = transform.position;
            newPosition.x += speed;
            transform.position = newPosition;
        }
    }
}
