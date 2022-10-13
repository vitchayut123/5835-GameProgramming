using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI livesText;
    [SerializeField] private Image[] heartImages;
    [SerializeField] private Sprite emptyHeartSprite;

    public void UpdateLives(int lives)
    {
        livesText.text = $"Lives: {lives}";

        for (var i = heartImages.Length - 1; i >= lives; i--)
        {
            heartImages[i].sprite = emptyHeartSprite;
        }
    }
}
