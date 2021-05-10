using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnReiniciar : MonoBehaviour
{
    // Start is called before the first frame update
    public Button reinicarBoton;

    void Start()
    {
        reinicarBoton.onClick.AddListener(TaskOnClickF);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void TaskOnClickF(){
        UnityEngine.Debug.Log("EL JUEGO SE REINICIARA PRONTO.");
         SceneManager.LoadScene("InicioRana");
    }
}
