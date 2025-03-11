using UnityEngine;
using UnityEngine.SceneManagement;

public class PageManager : MonoBehaviour
{
    public bool isEscapetoExit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp (KeyCode.Escape)) {
            if (isEscapetoExit) {
                Application.Quit();
            }
        }
    }

    public void GameStart()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
