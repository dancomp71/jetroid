using UnityEngine;
using System.Collections;
using Assets.Jetroid.Scripts;

/// <summary>
/// player controller
/// </summary>
public class PlayerController : MonoBehaviour
{

    public Vector2 moving = new Vector2();

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moving.x = moving.y = 0;
        if (Input.GetKey(InputKeyNames.Right))
        {
            moving.x = 1;
        }
        else if (Input.GetKey(InputKeyNames.Left))
        {
            moving.x = -1;
        }

        if (Input.GetKey(InputKeyNames.Up))
        {
            moving.y = 1;
        }
        else if (Input.GetKey(InputKeyNames.Down))
        {
            moving.y = -1;
        }
    }
}
