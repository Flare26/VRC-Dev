
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ModerationBonk : UdonSharpBehaviour
{
    [SerializeField] int bonkRange;
    [SerializeField] Transform teleportTo;
    [SerializeField] Transform firePoint;

    [SerializeField] GameObject aimHelper;
    private Vector3 teleportPos;
    private Quaternion teleportRot;
    RaycastHit hit;
    private void Start()
    {
        teleportPos = teleportTo.position;
        teleportRot = teleportTo.rotation;

    }
    public override void OnPickupUseDown()
    {
        SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, nameof(FireGun));

    }

    public void FireGun()
    {
        if (hit.collider.gameObject.layer == 9)
        {
            // raycast hit on player when pickup use down
            
        }
    }
    private void FixedUpdate()
    {
        if (Physics.Raycast(firePoint.position, firePoint.TransformDirection(Vector3.forward), out hit, bonkRange))
        {
            if (aimHelper.activeSelf == false)
                aimHelper.SetActive(true);
            aimHelper.transform.position = hit.point;
        }
        else
            aimHelper.SetActive(false);
    }
}
