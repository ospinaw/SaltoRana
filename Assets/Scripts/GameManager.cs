using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public GameObject sapo1;
    public int[] sapos = new int[] { 1, 6, 0, 3, 4, 5, 6 };

    // Start is called before the first frame update
    void Start()
    {
       sapos=  new int[] { 1, 2, 3, 0, 4, 5, 6 };

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float RetornarPosicion(int n) {
        // UnityEngine.Debug.Log(System.Array.IndexOf(sapos, n));
        if (n < 4) {
            if (System.Array.IndexOf(sapos, n) < 6)
            {
                if (sapos[(System.Array.IndexOf(sapos, n) + 1)] == 0)
                {
                    UnityEngine.Debug.Log("Puede saltar 1");
                    int a = System.Array.IndexOf(sapos, n);
                    int b = System.Array.IndexOf(sapos, n) + 1;
                    UnityEngine.Debug.Log(System.Array.IndexOf(sapos, n));
                    sapos[a] = 0;
                    sapos[b] = n;
                    UnityEngine.Debug.Log(System.Array.IndexOf(sapos, n) + 1);


                    for (int i = 0; i < 7; i++)
                    {
                        UnityEngine.Debug.Log(sapos[i]);
                    }
                    return 250;
                }
                else if ((System.Array.IndexOf(sapos, n) + 2) < 6)
                {

                    if (sapos[(System.Array.IndexOf(sapos, n) + 2)] == 0 && sapos[(System.Array.IndexOf(sapos, n) + 1)] > 3)
                    {
                        UnityEngine.Debug.Log("Puede saltar 2");
                        int a = System.Array.IndexOf(sapos, n);
                        int b = System.Array.IndexOf(sapos, n) + 2;
                        UnityEngine.Debug.Log(System.Array.IndexOf(sapos, n));
                        sapos[a] = 0;
                        sapos[b] = n;
                        UnityEngine.Debug.Log(System.Array.IndexOf(sapos, n) + 2);


                        for (int i = 0; i < 7; i++)
                        {
                            UnityEngine.Debug.Log(sapos[i]);
                        }
                        return 500;
                    }
                    else
                    {
                        UnityEngine.Debug.Log("No puede saltar 2");
                        return 0;

                    }
                }
                // UnityEngine.Debug.Log("fuera del mapa");

            }

        }
        else if (n > 3) {
            if (System.Array.IndexOf(sapos, n) > 0)
            {
                if (sapos[(System.Array.IndexOf(sapos, n) - 1)] == 0)
                {
                    int a = System.Array.IndexOf(sapos, n);
                    int b = System.Array.IndexOf(sapos, n)-1;
                    UnityEngine.Debug.Log(System.Array.IndexOf(sapos, n));
                    sapos[a] = 0;
                    sapos[b] = n;
                    UnityEngine.Debug.Log(System.Array.IndexOf(sapos, n) - 1);
                    
                    
                    for (int i = 0; i < 7; i++)
                    {
                        UnityEngine.Debug.Log(sapos[i]);
                    }
                    return -240;
                }
                else if ((System.Array.IndexOf(sapos, n) - 2) >= 0)
                {

                    if (sapos[(System.Array.IndexOf(sapos, n) - 2)] == 0 && sapos[(System.Array.IndexOf(sapos, n) - 1)] < 4)
                    {
                        UnityEngine.Debug.Log("Puede saltar -2");
                        int a = System.Array.IndexOf(sapos, n);
                        int b = System.Array.IndexOf(sapos, n) - 2;
                        UnityEngine.Debug.Log(System.Array.IndexOf(sapos, n));
                        sapos[a] = 0;
                        sapos[b] = n;
                        UnityEngine.Debug.Log(System.Array.IndexOf(sapos, n) - 2);


                        for (int i = 0; i < 7; i++)
                        {
                            UnityEngine.Debug.Log(sapos[i]);
                        }
                        return -500;
                    }
                    else
                    {
                        UnityEngine.Debug.Log("No puede saltar -2");
                        return 0;

                    }
                }
                // UnityEngine.Debug.Log("fuera del mapa");

            }

        }
        else{
            return 0;
        }
        return 1000;
    }
}
