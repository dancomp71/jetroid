using Assets.Jetroid.Scripts;
using UnityEngine;

/// <summary>
/// a collectible item for a player
/// </summary>
public class Collectible : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == TagNames.Player)
        {
            Destroy(gameObject);
        }
    }
}
