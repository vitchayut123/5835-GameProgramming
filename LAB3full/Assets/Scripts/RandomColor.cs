using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    [SerializeField] private Sprite[] sprites;
    [SerializeField] private int randomNumber;
    [SerializeField] private SpriteRenderer spriteRenderer;
    public CollectColor color;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        randomNumber = Random.Range(0, sprites.Length);

        switch (randomNumber)
        {
            case 0:
                color = CollectColor.Blue;
                break;
            case 1:
                color = CollectColor.Yellow;
                break;
            case 2:
                color = CollectColor.Green;
                break;
        }
        spriteRenderer.sprite = sprites[randomNumber];
    }
}