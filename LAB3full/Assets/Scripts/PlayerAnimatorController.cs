using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void SetAnimatorParameter(Vector2 playerVelocity, bool groundState)
    {
        animator.SetFloat("xVelocity", Mathf.Abs(playerVelocity.x));
        animator.SetBool("IsGrounded", groundState);
    }
}
