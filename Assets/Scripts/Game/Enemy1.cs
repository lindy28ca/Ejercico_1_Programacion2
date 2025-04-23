using UnityEngine;

public class Enemy1 : Enemy
{
    protected override void Attac()
    {
        Debug.Log(gameObject.name + " atacó");
    }
}
