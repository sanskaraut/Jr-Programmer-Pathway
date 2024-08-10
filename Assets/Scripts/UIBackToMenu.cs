using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBackToMenu : MonoBehaviour
{
    public bool pauseGame = false;
    public GameObject pauseScreenUI;

    // Start is called before the first frame update
    void Start()
    {
        pauseScreenUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void BackToMenu()
    {
        pauseScreenUI.gameObject.SetActive(true);
        pauseGame = true;

    }
    public void ReturnToMenu()
    {
        pauseScreenUI.gameObject.SetActive(false);
        SceneManager.LoadScene(0);
    }
    public void CancelReturnToMenu()
    {
        pauseScreenUI.gameObject.SetActive(false);
        pauseGame = false;
    }
}
