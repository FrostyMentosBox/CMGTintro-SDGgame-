using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class PMS : MonoBehaviour
{
    public float Speed;
    private bool isFacingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            transform.position = new Vector2(transform.position.x - Speed * Time.deltaTime, transform.position.y); //negative move hor
        }
        if(Input.GetKey(KeyCode.D)){
            transform.position = new Vector2(transform.position.x + Speed * Time.deltaTime, transform.position.y); //positive move hor
        }
        if(Input.GetKey(KeyCode.Space)){
            transform.position = new Vector2(transform.position.x, transform.position.y + Speed * Time.deltaTime); //jump
        }
        Flip();
    }
    private void Flip()
    {
        if(isFacingRight && Input.GetKeyDown(KeyCode.A) || !isFacingRight && Input.GetKeyDown(KeyCode.D)){
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
