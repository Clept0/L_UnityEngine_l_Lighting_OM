using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingFlicker : MonoBehaviour
{
    private Light pointLight;
    private float minValueIntensity;
    private float maxValueIntensity;


    // Start is called before the first frame update
    void Start()
    {
        pointLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        pointLight.intensity = Random.Range(minValueIntensity, maxValueIntensity);
    }
}
