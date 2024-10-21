using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject stagesPGMinus1;
    [SerializeField] GameObject stagesPG1;
    [SerializeField] GameObject stagesPG2;
    [SerializeField] GameObject stagesPGBoss;
    public int menuPage;
    // Start is called before the first frame update
    void Start()
    {
        menuPage = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnterTutorial()
    {
        SceneManager.LoadScene(3);
    }
    public void EnterSectionMinus1()
    {
        SceneManager.LoadScene(2);
    }
    public void EnterSection1()
    {
        SceneManager.LoadScene(4);
    }
    public void EnterSection2()
    {
        SceneManager.LoadScene(5);
    }
    public void EnterSection3()
    {
        SceneManager.LoadScene(6);
    }
    public void EnterSection4()
    {
        SceneManager.LoadScene(7);
    }
    public void EnterSection5()
    {
        SceneManager.LoadScene(8);
    }
    public void EnterBossfight()
    {
        SceneManager.LoadScene(9);
    }
    public void PlayButton()
    {
        menuPage = 1;
        mainMenu.SetActive(false);
        stagesPG1.SetActive(true);
    }
    public void NextPage()
    {
        switch (menuPage)
        {
            case 1:
                menuPage = 2;
                stagesPG1.SetActive(false);
                stagesPG2.SetActive(true);
                break;
            case 2:
                menuPage = 3;
                stagesPG2.SetActive(false);
                stagesPGBoss.SetActive(true);
                break;
        }
    }
    public void PrevPage()
    {
        switch (menuPage)
        {
            case 1:
                menuPage = -1;
                stagesPGMinus1.SetActive(true);
                stagesPG1.SetActive(false);
                break;
            case 2:
                menuPage = 1;
                stagesPG1.SetActive(true);
                stagesPG2.SetActive(false);
                break;
            case 3:
                menuPage = 2;
                stagesPG2.SetActive(true);
                stagesPGBoss.SetActive(false);
                break;
        }
    }
    public void BackToMainMenu()
    {
        mainMenu.SetActive(true);
        stagesPG1.SetActive(false);
        stagesPG2.SetActive(false);
        stagesPGBoss.SetActive(false);
    }
}
