using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PanelManager : MonoBehaviour
{
    // Start is called before the first frame update

    public TMP_Text Pasos ;
    public GameObject GameManager;
    public List<string> ListPasos;
    public bool ConsultarPasos;
    
    
    
    void ObtenerPasos(){    
        //ListPasos = GameManager.getListaPasos();
        //Pasos.SetText(ListPasos[1]);
    }


    void Start()
    {
        ConsultarPasos=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(ConsultarPasos){
            ObtenerPasos();
            ConsultarPasos = false;
        }
    }
}
