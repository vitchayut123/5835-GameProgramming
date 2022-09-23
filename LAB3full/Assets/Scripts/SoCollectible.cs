using UnityEngine;

[CreateAssetMenu(menuName = "Collectibles", fileName = "New Collectible")]

public class SoCollectible : ScriptableObject
{
    [SerializeField] private Sprite sprite;
    [SerializeField] private Sprite outlineSprite;
    [SerializeField] private bool respawnable;
    
    public Sprite GetSprite() => sprite;
    public Sprite GetOutlineSprite() => outlineSprite;
    public bool GetRespawnable() => respawnable;
}