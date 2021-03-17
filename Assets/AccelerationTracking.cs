using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AccelerationTracking : MonoBehaviour
{
    public enum AccelerationAxis {X, Y, Z};
    public AccelerationAxis axis;
    public Vector3 acceleration;
    TextMeshProUGUI accelText;
    // Start is called before the first frame update
    void Start()
    {
        accelText = GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = new Vector3(Input.acceleration.x,
            Input.acceleration.y,
            Input.acceleration.z);
    
        switch(axis)
        {
            case AccelerationAxis.X:
                accelText.text = "X Acceleration: " + acceleration.x;    		
                break;
            case AccelerationAxis.Y:
                accelText.text = "Y Acceleration: " + acceleration.y; 
                break;
            case AccelerationAxis.Z:
                accelText.text = "Z Acceleration: " + acceleration.z; 
                break;
        }
    }
}