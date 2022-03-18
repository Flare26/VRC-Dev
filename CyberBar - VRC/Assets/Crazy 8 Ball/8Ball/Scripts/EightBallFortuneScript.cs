
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;
using VRC.Udon.Common;


namespace CrazyEightBall
{
    public class EightBallFortuneScript : UdonSharpBehaviour
    {
        [SerializeField]  private GameObject innertrigger;
        private bool isheld;
        public float lerpamount;
        public Animator fortuneanimator;
        [UdonSynced] public int fortunenumber;
        private float shaketimer;
        public float shakeendtimer;
        private bool shaken;
        private float movementdetection;

        public override void InputMoveHorizontal(float value, UdonInputEventArgs args)
        {
            movementdetection = value;
        }

        public override void InputMoveVertical(float value, UdonInputEventArgs args)
        {
            movementdetection = value;
        }

        public override void OnPickup()
        {
            if (Networking.IsOwner(gameObject))
            {
                isheld = true;
            }
            else
            {
                SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.Owner, "OnPickup");
            }
        }

        public override void OnDrop()
        {
            isheld = false;
        }

        public void Update()
        {
            if (isheld || shaken)
            {
                if (shaken)
                {
                    if (shaketimer >= shakeendtimer)
                    {
                        SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "FortuneResetSync");
                    }
                    else
                    {
                        shaketimer += Time.deltaTime;
                        innertrigger.transform.position = transform.position;
                    }
                }
                else
                {
                    innertrigger.transform.position = Vector3.Lerp(innertrigger.transform.position, transform.position, lerpamount);
                }
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (innertrigger == other.gameObject)
            {
                if (!shaken && movementdetection == 0)
                {
                        if (Networking.IsOwner(gameObject))
                        {
                            fortunenumber = Random.Range(0, 19);
                            SendCustomEventDelayedSeconds("FortuneSync", 0.7f);
                            shaken = true;
                        }
                }
            }
        }

        public void FortuneResult()
        {
            fortuneanimator.SetBool("Shaken", true);
            fortuneanimator.SetInteger("FortuneInt", fortunenumber);
            shaken = true;
        }
        public void FortuneResetSync()
        {
            shaken = false;
            shaketimer = 0;
            fortuneanimator.SetBool("Shaken", false);
        }
        public void FortuneSync()
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "FortuneResult");
        }
    }
}
