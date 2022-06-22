using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    [SerializeField] private double diameter;
    [SerializeField] private double width;
    private Material material;
    private double circumference = 0;
    private double grip = 0;

    void Start()
    {
        circumference = 2 * 3.14 * (diameter / 2);
        grip = (circumference / 360) * width;
    }

    void Update()
    {
        
    }
}
