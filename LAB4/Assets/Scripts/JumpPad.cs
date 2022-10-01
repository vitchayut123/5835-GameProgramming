using UnityEngine;

public class JumpPad : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private float jumpPadForce = 13f;
    [SerializeField] private float additionalSleepJumpTime = 0.3f;
    
    private static readonly int Bounce = Animator.StringToHash("Bounce");

    public float GetJumpPadForce() => jumpPadForce;
    public float GetAdditionalSleepJumpTime() => additionalSleepJumpTime;
    
    public void TriggerJumpPad()
    {
        animator.SetTrigger(Bounce);
    }
}
