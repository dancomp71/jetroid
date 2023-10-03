using UnityEngine;

public class RandomSpriteManager : MonoBehaviour
{
    public Sprite[] sprites;
    public int currentSprite = -1;

    void Start()
    {
        if (currentSprite == -1)
        {
            currentSprite = Random.Range(0, sprites.Length);
        }
        else if (currentSprite > sprites.Length)
        {
            currentSprite = sprites.Length - 1;
        }

        GetComponent<SpriteRenderer>().sprite = sprites[currentSprite];
    }

    void Update()
    {

    }
}
