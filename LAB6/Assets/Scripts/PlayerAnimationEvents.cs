using UnityEngine;

public class PlayerAnimationEvents : MonoBehaviour
{
    [SerializeField] private PlayerAudioController audioController;
    [SerializeField] private ParticleSystem runEffect;

    public void PlayWalkSound()
    {
        audioController.PlayWalk();
        runEffect.Play();
    }
}
