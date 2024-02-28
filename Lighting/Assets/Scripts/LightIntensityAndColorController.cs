using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIntensityAndColorController : MonoBehaviour
{
    //[SerializeField] private Light[] pointLights;
    [SerializeField] private GameObject[] pointLights;
    [SerializeField] private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //pointLights = FindObjectsOfType<Light>();
        pointLights = GameObject.FindGameObjectsWithTag("PointLight");
        player = GameObject.Find("Player");

      
    }

    void Update()
    {
      foreach(GameObject pointLight in pointLights)
      {

      }
      
    }
}
