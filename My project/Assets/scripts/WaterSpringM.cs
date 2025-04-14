using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class WaterSpringM : MonoBehaviour
{
    private float velocity = 0;
    private float force = 0;
    private float height = 0f;
    //current height
    private float target_height = 0f;
    //normal height
    public void WaveSpringUpdate(float springStiffness, float dampening) {
        height = transform.localPosition.y;
        //max extention
        var x = height - target_height;
        var loss = -dampening * velocity;

        force = - springStiffness * x + loss;
        velocity += force;
        var y = transform.localPosition.y;
        transform.localPosition = new Vector2(transform.localPosition.x, y+velocity);
    }
}
