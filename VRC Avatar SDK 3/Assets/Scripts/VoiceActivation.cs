using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRC.SDK3.Avatars.Components;
public class VoiceActivation : MonoBehaviour
{
    Animator anim;
    Renderer rend;
    public float brightness = 6.66f;
    void Awake()
    {
        rend = GetComponent<Renderer>();
        anim = GetComponent<Animator>();
        //VRC.SDK3.Avatars.Components.VRCAvatarDescriptor
    }
}
