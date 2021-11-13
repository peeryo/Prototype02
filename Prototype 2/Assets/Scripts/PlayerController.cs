using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizonalInput;
    public float speed = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -10)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        horizonalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizonalInput * Time.deltaTime * speed);
        
    }
}
