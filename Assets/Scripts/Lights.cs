using UnityEngine;
using System.Collections;

public class Lights : MonoBehaviour
{
    [SerializeField] Light[] mainWorldLight;

    [SerializeField] float blinkWorldTime;
    WaitForSecondsRealtime WaitBlinkWorldTime;

    private void Awake()
    {
        WaitBlinkWorldTime = new WaitForSecondsRealtime(blinkWorldTime);
    }

    private void Update()
    {
        StartCoroutine(BlinkWorldLights());
    }

    IEnumerator BlinkWorldLights()
    {
        yield return WaitBlinkWorldTime;
        foreach (var light in mainWorldLight)
        {
            light.enabled = !light.enabled;
        }
    }
}