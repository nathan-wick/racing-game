using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kart : MonoBehaviour
{
    [Header("Parts")]
    [SerializeField] private Frame frame;
    [SerializeField] private Computer computer;
    [SerializeField] private Wheel[] wheels;
    [SerializeField] private Motor[] motors;
    [SerializeField] private Battery[] batteries;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
