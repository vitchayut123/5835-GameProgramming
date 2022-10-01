using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    
    private static readonly int IsGrounded = Animator.StringToHash("isGrounded");
    private static readonly int XVelocity = Animator.StringToHash("xVelocity");
    private static readonly int YVelocity = Animator.StringToHash("yVelocity");

    public void SetAnimatorParameters(Vector2 playerVelocity, bool groundState)
    {
        animator.SetBool(IsGrounded, groundState);
        animator.SetFloat(XVelocity, Mathf.Abs(playerVelocity.x));
        animator.SetFloat(YVelocity, playerVelocity.y);
    }
}
