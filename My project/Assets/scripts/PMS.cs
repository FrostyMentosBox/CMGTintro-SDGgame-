using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMS : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            transform.position = new Vector2(transform.position.x - Speed * Time.deltaTime, transform.position.y);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.position = new Vector2(transform.position.x + Speed * Time.deltaTime, transform.position.y);
        }
        if(Input.GetKey(KeyCode.Space)){
            transform.position = new Vector2(transform.position.x , transform.position.y + Speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftShift)){
            transform.position = new Vector2(transform.position.x , transform.position.y - Speed * Time.deltaTime);
        }
    }
}
