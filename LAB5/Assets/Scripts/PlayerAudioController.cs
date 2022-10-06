using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private SoAudioClips walkAudioClips;
    [SerializeField] private SoAudioClips jumpAudioClips;
    [SerializeField] private SoAudioClips jumppadAudioClips;
    [SerializeField] private SoAudioClips pickAudioClips;
    [SerializeField] private SoAudioClips RespawnAudioClips;
    [SerializeField] private SoAudioClips DeathAudioClips;
    [SerializeField] private SoAudioClips winningAudioClips;

    private void Start()
    {
        audioSource.Play();
    }

    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(jumpAudioClips.GetAudioClip());
    }
    
    public void PlayWalkSound()
    {
        audioSource.PlayOneShot(walkAudioClips.GetAudioClip());
    }

    public void PlayJumppadSound()
    {
        audioSource.PlayOneShot(jumppadAudioClips.GetAudioClip());
    }

    public void PlaypickSound()
    {
        audioSource.PlayOneShot(pickAudioClips.GetAudioClip());
    }

    public void PlayrespawnSound()
    {
        audioSource.PlayOneShot(RespawnAudioClips.GetAudioClip());
    }

    public void PlayDeathSound()
    {
        audioSource.PlayOneShot(DeathAudioClips.GetAudioClip());
    }

    public void PlaywinningSound()
    {
        audioSource.PlayOneShot(winningAudioClips.GetAudioClip());
    }
}
