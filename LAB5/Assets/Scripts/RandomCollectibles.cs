using UnityEngine;
using Random = UnityEngine.Random; // This is to define which Random to use between System.Random and UnityEngine.Random

public class RandomCollectibles : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private SpriteRenderer spriteRenderer;

    /*private Collectibles _collectible;

    private void Awake()
    {
        // What is awake? It is Start() but runs before anything else. For more info, please check the Script Execution Order.
        
        _collectible = GetComponent<Collectibles>();
    }

    private void OnEnable()
    {
        var randomizedIndex = Random.Range(0, sprites.Length);
        CollectibleType collectibleType;
        
        switch (randomizedIndex)
            {
            default: // or case 0:
                collectibleType = CollectibleType.Red;
                break;
            case 1:
                collectibleType = CollectibleType.Green;
                break;
            case 2:
                collectibleType = CollectibleType.Blue;
                break;
            }

        _collectible.SetCollectibleType(collectibleType);
        spriteRenderer.sprite = sprites[randomizedIndex];
    }*/
}
