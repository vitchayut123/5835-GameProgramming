using UnityEngine;

[CreateAssetMenu(menuName = "Create Audio Clips", fileName = "New Audio Clips")]
public class SoAudioClips : ScriptableObject
{
    [SerializeField] private AudioClip[] audioClips;

    public AudioClip GetAudioClip()
    {
        var index = 0;
        var totalAudioClips = audioClips.Length;

        switch (totalAudioClips)
        {
            case 1:
                break;
            default:
                index = Random.Range(0, totalAudioClips);
                break;
        }
        
        return audioClips[index];
    }
}
