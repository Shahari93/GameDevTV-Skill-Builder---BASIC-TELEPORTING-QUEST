using UnityEngine;

public class Lights : MonoBehaviour
{
    [SerializeField] Light[] mainWorldLight;

    private void Start()
    {
        foreach (var light in mainWorldLight)
        {
            light.gameObject.SetActive(false);
        }
    }
}