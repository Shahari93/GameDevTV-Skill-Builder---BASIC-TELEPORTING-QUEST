// GameDev.tv Challenge Club. Got questions or want to share your nifty solution?
// Head over to - http://community.gamedev.tv
using UnityEngine;

public class Teleport : MonoBehaviour
{

    #region Teleport
    [SerializeField] private Transform[] teleportTarget;
    public Transform[] TeleportTarget
    {
        get
        {
            return teleportTarget;
        }
    }
    #endregion

    #region Lights
    [SerializeField] Light[] areaLight;
    public Light[] AreaLight
    {
        get
        {
            return areaLight;
        }
        set
        {
            value = areaLight;
        }
    } 
    #endregion

    [SerializeField] GameObject player;
}