using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    [SerializeField] private AudioPlayer audioPlayer;
    
    [Header("Audio Clips")]
    [SerializeField] private SoAudioClips walkAudioClips;
    [SerializeField] private SoAudioClips jumpAudioClips;
    [SerializeField] private SoAudioClips deathAudioClips;

    public void PlayJump()
    {
        audioPlayer.PlaySound(jumpAudioClips, 0.5f);
    }

    public void PlayWalk()
    {
        audioPlayer.PlaySound(walkAudioClips, 0.3f);
    }

    public void PlayFallImpact()
    {
        audioPlayer.PlaySound(walkAudioClips, 0.6f);
    }

    public void PlayDeath()
    {
        audioPlayer.PlaySound(deathAudioClips);
    }
    
    public void MuteAudioSource()
    {
        audioPlayer.MuteAudioSource();
    }
}
