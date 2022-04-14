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
    float KmDiaNormal;
    float KmDiaDeLluvia;
    float litrosnormal;
    float litroslluvia;
    float costolitro;
    float litrospordianormal;
    float litrospordialluvia;


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
            KmDiaNormal = 90;
            KmDiaDeLluvia = 120;
            costolitro = 130;
            litrospordianormal = KmDiaNormal/15;
            litrospordialluvia = KmDiaDeLluvia/15; 
            litrosnormal = (dia * litrospordianormal ) * costolitro;
            litroslluvia = (dialluvia * litrospordialluvia) * costolitro; 
            costoDeCombustible = cantidadDeUnidades * ((litrosnormal) + (litroslluvia));

            Debug.Log("Una flota de " + cantidadDeUnidades + " unidades trabajando durante " + periodoDeDias + " días implicará un costo de " + costoDeCombustible + " pesos en concepto de combustible ");



        }
    
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
