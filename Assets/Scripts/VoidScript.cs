using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VoidScript : MonoBehaviour
{
    [SerializeField] TMP_Text voidText;
    [SerializeField] GameObject deletion;
    void Start()
    {
        Invoke("Text1", 3f);
    }
    void Text1()
    {
        voidText.text = "t h e v o i d .";
        Invoke("Text2", 30f); //30
    }
    void Text2()
    {
        voidText.text = "r e m e m b e r .";
        Invoke("Text3", 5f); //5
    }
    void Text3()
    {
        voidText.text = "i f y o u d e l e t e m e , y o u w i l l b e d e p r i v e d o f y o u r s e n s o r y .";
        Invoke("DisplayButton", 20f); //20
    }
    void DisplayButton()
    {
        voidText.text = "";
        deletion.SetActive(true);
    }
    public void CanvasDeletion()
    {
        Invoke("CamDeletion", 1f);
        Destroy(GameObject.Find("Canvas"));
    }
    public void CamDeletion()
    {
        Destroy(this.gameObject);
    }
}
