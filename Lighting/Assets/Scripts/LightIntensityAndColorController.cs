using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIntensityAndColorController : MonoBehaviour
{
    //[SerializeField] private Light[] pointLights;
    [SerializeField] private GameObject[] pointLights;
    [SerializeField] private GameObject player;
    [SerializeField] private float maxDistance = 10f;
    [SerializeField] private float maxIntensity = 1f;
    [SerializeField] private Color startColor = Color.red;
    [SerializeField] private Color endColor = Color.green;


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
            Light light = pointLight.GetComponent<Light>();
            if(pointLights.Length > 0)
            {
                UpdateLightProperties(light);
            }
        }
    }

    private void UpdateLightProperties(Light pointLight)
    {
        float distance = Vector3.Distance(pointLight.transform.position, player.transform.position);

        //max distance bei der die Lampe reagiert
        if(distance < maxDistance)
        {
            //Intensität anpassen
            float intensityValue = (1 - (distance / maxDistance)) * maxIntensity;
            pointLight.intensity = intensityValue;

            //Color anpassen
            float colorRatio = (1 - (distance / maxDistance));
            pointLight.color = Color.Lerp(startColor, endColor, colorRatio);

        }
        else
        {
            pointLight.intensity = 0f;
            pointLight.color = startColor;
        }
    }
}