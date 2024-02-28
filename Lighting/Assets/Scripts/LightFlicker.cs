using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public float minIntensity = 0.2f;
    public float maxIntensity = 1f;
    public float timeBetween = 1.4f;

    private Light lightComponent;
    private float changeTargetTime = 0f;
    private float targetIntensity;

    void Start()
    {
        lightComponent = GetComponent<Light>();
        targetIntensity = lightComponent.intensity;
    }

    void Update()
    {
        // Überprüft, ob es Zeit ist, die Zielintensität zu ändern
        if (Time.time >= changeTargetTime)
        {
            targetIntensity = Random.Range(minIntensity, maxIntensity);
            changeTargetTime = Time.time + timeBetween;
        }

        // Verwendet Mathf.PingPong, um einen Wert zwischen der aktuellen Intensität und der Zielintensität zu interpolieren
        lightComponent.intensity = Mathf.Lerp(minIntensity, targetIntensity, Mathf.PingPong(Time.time, timeBetween) / timeBetween);
    }
}