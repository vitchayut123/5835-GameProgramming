using UnityEngine;
using DG.Tweening;

public class BackgroundMusicFadeUp : MonoBehaviour
{
    [SerializeField] private AudioSource backgroundMusicAudioSource;
    [SerializeField] private float endVolume;
    [SerializeField] private float duration = 3f;

    private void Start()
    {
        backgroundMusicAudioSource.DOFade(endVolume, duration).SetEase(Ease.OutCubic);
    }
}
