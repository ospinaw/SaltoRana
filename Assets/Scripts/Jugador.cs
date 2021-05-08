using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public Animator estadoSalto;
    public GameManager game;
    private Rigidbody2D rigidbody2D;
    public float fuerzaSalto;
    public int nRana;

    // public float final = -6,42;
    // public float speed = 2;
    // public Vector3 target;


    // Start is called before the first frame update
    void Start()
    {
        //transform.Translate(40, 40,0);
       estadoSalto = this.GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        //target = new Vector3(final, 0.0f,0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // float step = speed * Time.deltaTime;
        // transform.position = Vector3.MoveTwards(transform.position, target, step);

    }

    void OnMouseDown() {
        // UnityEngine.Debug.Log("Cualquier cosa");
        // estadoSalto.SetBool("estadoSalto", true);
        estadoSalto.SetTrigger("salto");
        UnityEngine.Debug.Log(this.nRana);
        fuerzaSalto = game.RetornarPosicion(this.nRana);

        if (fuerzaSalto > 400)
        {

            rigidbody2D.AddForce(new Vector2(fuerzaSalto - 350, 500));
            
        }
        else if (fuerzaSalto > 200)
        {
            rigidbody2D.AddForce(new Vector2(fuerzaSalto, 35));
            
        }
        else if (fuerzaSalto< -400)
        {
            rigidbody2D.AddForce(new Vector2(fuerzaSalto + 350, 500));
            

        }
        else if(fuerzaSalto<-200) {
            
            rigidbody2D.AddForce(new Vector2(fuerzaSalto, 35));
           
        }

       
    }
}
