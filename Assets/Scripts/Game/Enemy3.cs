using UnityEngine;

public class Enemy3 : Enemy, IHabilidades
{
    protected override void Attac()
    {
        Debug.Log(gameObject.name + " Combo especial de ataque");
    }

    public void habilidad()
    {
        Debug.Log("Enemy 3: Envenenamiento de bruja");
    }

    protected override void Habilidad() 
    {
        habilidad();
    }
}
