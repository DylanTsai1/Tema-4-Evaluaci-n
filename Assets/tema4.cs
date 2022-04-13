using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tema4 : MonoBehaviour
{
    public int cantidadDeUnidades;
    public int periodoDeDias;
    public int dialluvia;
    int dia;
    float costoTotalCombustible;
    float costoDeCombustible;
    float costoDeCombstibleTotal;
    float combustibleDiaDeLluvia;
    float combustibleDiaNormal; 

    // Start is called before the first frame update
    void Start()
    {
        if (periodoDeDias < 5 || dialluvia < 0 || dialluvia > periodoDeDias)

        {
            Debug.Log("Error");
        }
        else  
        {
            dia = periodoDeDias - dialluvia;
            periodoDeDias = dia + dialluvia;
            combustibleDiaDeLluvia = 130;
            combustibleDiaNormal = 90; ;
            costoDeCombustible = cantidadDeUnidades * ((dia * combustibleDiaNormal) + (dialluvia * combustibleDiaDeLluvia));

            Debug.Log("Una flota de " + cantidadDeUnidades + " unidades trabajando durante " + periodoDeDias + " días implicará un costo de " + costoDeCombustible + " pesos en concepto de combustible ");



        }
    
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
