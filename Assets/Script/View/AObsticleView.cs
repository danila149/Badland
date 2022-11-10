using UnityEngine;

public abstract class AObsticleView : MonoBehaviour
{
    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collide");
    }
}
