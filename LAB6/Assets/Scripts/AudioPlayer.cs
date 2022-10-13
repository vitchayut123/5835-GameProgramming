using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioPlayer : MonoBehaviour
{
    [SerializeField] private float muteDuration = 0.12f;
    
    private AudioSource _audioSource;
    
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(SoAudioClips audioClips, float volume = 1f)
    {
        _audioSource.PlayOneShot(audioClips.GetAudioClip(), volume);
    }
    
    public void MuteAudioSource()
    {
        StartCoroutine(MuteAudioTemporary());
    }

    private IEnumerator MuteAudioTemporary()
    {
        ToggleMuteAudioSource();
        yield return new WaitForSecondsRealtime(muteDuration);
        ToggleMuteAudioSource();
    }

    private void ToggleMuteAudioSource()
    {
        _audioSource.mute = !_audioSource.mute;
    }
}
