using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockEnemy : Enemy_Controller
{
    [SerializeField]
    protected float Rock_05_Speed = 10f;

    protected override void Start()
    {
        base.Start();
        Speed = Rock_05_Speed;
    }

    protected override void Update()
    {
        base.Update();
    }

    protected override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);
    }
}
