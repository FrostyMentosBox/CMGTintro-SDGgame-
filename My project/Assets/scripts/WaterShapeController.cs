using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterShapeController : MonoBehaviour
{
    [SerializeField]
    private float springStiffness = 0.1f;
    [SerializeField]
    private List<WaterSpringM> springs = new();
    [SerializeField]
    private float dampening = 0.03f;
    public float spread = 0.006f;
    

    void FixedUpdate()
    {
        foreach(WaterSpringM waterSpringComponent in springs) {
            waterSpringComponent.WaveSpringUpdate(springStiffness, dampening);
        }
    } 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
