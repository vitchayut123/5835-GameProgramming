using UnityEngine;

public class JumpPad : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private AudioPlayer audioPlayer;
    [SerializeField] private SoAudioClips jumpPadAudioClips;
    [SerializeField] private float jumpPadForce = 13f;
    [SerializeField] private float additionalSleepJumpTime = 0.3f;
    
    private static readonly int Bounce = Animator.StringToHash("Bounce");

    private void TriggerJumpPad()
    {
        animator.SetTrigger(Bounce);
        audioPlayer.PlaySound(jumpPadAudioClips);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.TryGetComponent(out PlayerCollision playerCollision)) return;

        TriggerJumpPad();
        playerCollision.MuteFallImpactSounds();
        playerCollision.Bounce(jumpPadForce, additionalSleepJumpTime);
    }
}
