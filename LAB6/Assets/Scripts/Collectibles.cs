using System;
using UnityEngine;
using DG.Tweening;

public class Collectibles : MonoBehaviour
{
    [SerializeField] private CollectibleSpawner collectibleSpawner;
    [SerializeField] private Transform endTweenPosition;
    [SerializeField] private float tweenDuration = 5f;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private SoCollectibles collectibleObject;
    
    
    private CollectibleType _collectibleType;
    private bool _isRespawnable;

    private void Start()
    {
        SetCollectible();
        transform.DOMove(endTweenPosition.position, tweenDuration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutQuad);
    }

    public CollectibleType GetCollectibleInfoOnContact()
    {
        gameObject.SetActive(false);

        if (_isRespawnable)
        {
            
            collectibleSpawner.StartRespawningCountdown();

        }

        return _collectibleType;
    }
    
    private void SetCollectible()
    {
        collectibleSpawner.SetOutlineSprite(collectibleObject.GetOutlineSprite());
        spriteRenderer.sprite = collectibleObject.GetSprite();
        _collectibleType = collectibleObject.GetCollectibleType();
        _isRespawnable = collectibleObject.GetRespawnable();
    }
}
