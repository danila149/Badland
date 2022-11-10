using UnityEngine;

public class StaticObsticle : AObsticleView
{
    public override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
        Debug.Log("Static");
    }
}
