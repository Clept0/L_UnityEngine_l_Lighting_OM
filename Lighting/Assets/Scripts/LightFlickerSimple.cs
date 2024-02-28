using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlickerSimple : MonoBehaviour
{

    void Update()
    {
        float intensity = Random.Range(0.4f, 1f);
        GetComponent<Light>().intensity = intensity;
    }

}
