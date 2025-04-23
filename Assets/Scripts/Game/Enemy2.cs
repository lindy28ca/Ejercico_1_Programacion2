using UnityEngine;

public class Enemy2 : Enemy
{
    protected override void Attac()
    {
        Debug.Log(gameObject.name + " atacó");
    }
}
