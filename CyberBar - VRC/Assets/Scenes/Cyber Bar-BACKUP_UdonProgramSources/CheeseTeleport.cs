
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class CheeseTeleport : UdonSharpBehaviour
{
    [SerializeField] Transform teleportPoint;

    private Vector3 teleportPos;
    private Quaternion teleportRot;

    void Start()
    {
        teleportPos = teleportPoint.position;
        teleportRot = teleportPoint.rotation;
    }
    public void OnPlayerTriggerStay(VRCPlayerApi api)
    {
        api.TeleportTo(teleportPos, teleportRot);
    }
}
