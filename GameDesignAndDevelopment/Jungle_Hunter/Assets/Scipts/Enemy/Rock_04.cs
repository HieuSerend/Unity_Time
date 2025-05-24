using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Rock_04 : Enemy_Controller
{
    [SerializeField]
    protected float Rock_04_Speed = 12f;

    protected override void Start()
    {
        base.Start();
        Speed = Rock_04_Speed;
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