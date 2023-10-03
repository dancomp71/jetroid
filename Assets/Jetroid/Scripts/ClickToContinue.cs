using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToContinue : MonoBehaviour
{
    public string scene;

    private bool loadLock;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && !loadLock)
        {
            LoadScene();
        }
    }

    private void LoadScene()
    {
        loadLock = true;
        SceneManager.LoadScene(scene);
    }
}
