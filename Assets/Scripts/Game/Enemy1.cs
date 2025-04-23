using UnityEngine;

public class Enemy1 : Enemy
{
    protected override void Attac()
    {
        Debug.Log(gameObject.name + " Giro doble");
    }

    protected override void Habilidad() 
    {
        Debug.Log("Habilidad no definida en Enemy1");
    }
}
