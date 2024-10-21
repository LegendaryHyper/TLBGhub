using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EscapeMenu : MonoBehaviour
{
    private bool isEscMenuOpen;
    [SerializeField] GameObject EscMenuScreen;
    // Start is called before the first frame update
    void Start()
    {
        isEscMenuOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isEscMenuOpen)
            {
                EscMenuScreen.SetActive(true);
                isEscMenuOpen = true;
            }
            else
            {
                EscMenuScreen.SetActive(false);
                isEscMenuOpen = false;
            }
        }
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
