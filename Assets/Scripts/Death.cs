using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Death : MonoBehaviour
{

    [SerializeField] TMP_Text deathText;
    void Start()
    {
        Invoke("DeathScreen", 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void DeathScreen() {
        deathText.text = "Didn't expect you to burn out this quick.";
    }
}
