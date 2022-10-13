using System.Collections;
using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    // This script is to handle the respawning of the collectible as a disabled gameObject cannot run any methods or coroutines on its own.
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private GameObject collectibleGameObject;
    [SerializeField] private AudioPlayer audioPlayer;
    [SerializeField] private SoAudioClips collectAudioClips;
    [SerializeField] private SoAudioClips respawnAudioClips;
    [SerializeField] private ParticleSystem spriteEffect;
    
    [Header("Collectible Settings")]
    [SerializeField] private float respawnTime = 4f;

    private void Start()
    {
        spriteRenderer.enabled = false;
    }
    
    private IEnumerator RespawnCollectible()
    {
        yield return new WaitForSeconds(respawnTime);
        SetOutlineSpriteActive(false);
        PlayRespawn();
        spriteEffect.Play();
        collectibleGameObject.SetActive(true);
    }

    private void SetOutlineSpriteActive(bool state)
    {
        spriteRenderer.enabled = state;
    }

    public void SetOutlineSprite(Sprite sprite)
    {
        spriteRenderer.sprite = sprite;
    }
    
    public void StartRespawningCountdown() // This method is to let other script trigger the respawn countdown, and let this script handle the coroutine.
    {
        SetOutlineSpriteActive(true);
        PlayCollected();
        StartCoroutine(RespawnCollectible());
    }
    
    #region Audio
    private void PlayRespawn()
    {
        audioPlayer.PlaySound(respawnAudioClips);
    }

    private void PlayCollected()
    {
        audioPlayer.PlaySound(collectAudioClips);
    }
    #endregion
}
