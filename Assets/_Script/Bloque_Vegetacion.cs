using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Vegetacion : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        resistencia = 2;
    }

    public override void RebotarBola()
    {
        base.RebotarBola();
    }
}
