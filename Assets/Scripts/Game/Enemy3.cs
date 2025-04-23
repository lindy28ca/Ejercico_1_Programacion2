using UnityEngine;

public class Enemy3 : Enemy
{
    protected override void Attac()
    {
        Debug.Log(gameObject.name + " atacó");
    }
}
