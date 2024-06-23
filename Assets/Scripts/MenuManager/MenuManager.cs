using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button jogar;

    void Start()
    {
        jogar.onClick.AddListener(irprojogo);
    }

    
    void Update()
    {
        
    }

    void irprojogo()
    {
        SceneManager.LoadScene("JogoManager");
    }
}
