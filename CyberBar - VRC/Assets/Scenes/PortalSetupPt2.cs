
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class PortalSetupPt2 : UdonSharpBehaviour
{

    Transform playerCamera;
    [SerializeField] GameObject ps;
    void Start()
    {
        VRCPlayerApi p = Networking.LocalPlayer;
        GameObject pcm = GameObject.Find("Player Camera");
        ps.playerCamera = pcm.transform;

    }
}
