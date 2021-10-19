using System.Collections;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    [SerializeField] Teleport teleportPad;
    private BoxCollider teleportCollider;

    private WaitForSecondsRealtime WaitTimeToTeleprt;
    [SerializeField] float waitTimeToTeleprt = 0.2f;

    private WaitForSecondsRealtime WaitTimeToTurnOffCollider;
    [SerializeField] float waitTimeToTurnOffCollider = 5f;

    private void Awake()
    {
        WaitTimeToTeleprt = new WaitForSecondsRealtime(waitTimeToTeleprt);
        WaitTimeToTurnOffCollider = new WaitForSecondsRealtime(waitTimeToTurnOffCollider);
        teleportCollider = GetComponent<BoxCollider>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Challenge 2:
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(TeleportPlayerToRand(other));
        }
    }

    IEnumerator TeleportPlayerToRand(Collider other)
    {
        GameObject player = other.gameObject;
        int randIndex = Random.Range(0, teleportPad.TeleportTarget.Length);
        yield return WaitTimeToTeleprt;
        player.transform.position = teleportPad.TeleportTarget[randIndex].position;
        teleportPad.AreaLight[randIndex].enabled = true;

        teleportCollider.enabled = false;
        yield return WaitTimeToTurnOffCollider;
        teleportCollider.enabled = true;
        teleportPad.AreaLight[randIndex].enabled = false;
    }
}