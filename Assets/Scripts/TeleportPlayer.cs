using System.Collections;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    [SerializeField] Teleport teleportPad;
    [SerializeField] float waitFloat = 0.2f;
    private WaitForSecondsRealtime waitTime;

    private void Awake()
    {
        waitTime = new WaitForSecondsRealtime(waitFloat);
    }

    void OnTriggerEnter(Collider other)
    {
        // Challenge 2:
        StartCoroutine(TeleportPlayerToRand(other));
    }

    IEnumerator TeleportPlayerToRand(Collider other)
    {
        GameObject player = other.gameObject;
        if (player.CompareTag("Player"))
        {
            int randIndex = Random.Range(0, teleportPad.TeleportTarget.Length);
            yield return waitTime;
            player.transform.position = teleportPad.TeleportTarget[randIndex].position;
        }
    }
}