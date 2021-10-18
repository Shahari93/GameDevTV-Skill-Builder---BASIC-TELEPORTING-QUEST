using UnityEngine;

// GameDev.tv Challenge Club. Got questions or want to share your nifty solution?
// Head over to - http://community.gamedev.tv

public class Teleport : MonoBehaviour
{
    [SerializeField] private Transform[] teleportTarget;
    public Transform[] TeleportTarget
    {
        get
        {
            return teleportTarget;
        }
    }
    [SerializeField] Light[] areaLight;
    [SerializeField] GameObject player;

    void OnTriggerEnter(Collider other)
    {
        // Challenge 2:
        // Challenge 3: DeactivateObject();
        // Challenge 4: IlluminateArea();
        // Challenge 5: StartCoroutine ("BlinkWorldLight");
        // Challenge 6: TeleportPlayerRandom();
    }

    void DeactivateObject()
    {
        // code goes here 
    }

    void IlluminateArea()
    {
        // code goes here 
    }

    // IEnumerator BlinkWorldLight()
    // {
    // code goes here
    // }

    void TeleportPlayerRandom()
    {
        // code goes here... or you could modify one of your other methods to do the job.
    }
}
