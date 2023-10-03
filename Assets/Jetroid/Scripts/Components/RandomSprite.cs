using Assets.Jetroid.Scripts.Consts;
using UnityEngine;

public class RandomSprite : MonoBehaviour
{
    public Sprite[] sprites;
    public SpriteColors currentSprite = SpriteColors.Random;

    // Use this for initialization
    void Start()
    {
        if (currentSprite == SpriteColors.Random)
        {
            currentSprite = (SpriteColors)Random.Range(0, sprites.Length);
        }
        else if ((int)currentSprite > sprites.Length)
        {
            currentSprite = (SpriteColors)sprites.Length - 1;
        }

        GetComponent<SpriteRenderer>().sprite = sprites[(int)currentSprite];

    }

    // Update is called once per frame
    void Update()
    {

    }
}
