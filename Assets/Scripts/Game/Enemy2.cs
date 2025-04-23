using UnityEngine;

public class Enemy2 : Enemy, IHabilidades
{
    protected override void Attac()
    {
        Debug.Log(gameObject.name + " Doble golpe con pata giratoria");
    }

    public void habilidad()
    {
        Debug.Log("Enemy 2: Hechizo de encarcelamiento");
    }

    protected override void Habilidad() 
    {
        habilidad(); 
    }
}