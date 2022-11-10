using UnityEngine;

public abstract class ABonusView : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlaerView>())
        {
            PlaerView plaer = collision.GetComponent<PlaerView>();
            OnPick(plaer);
            Destroy(this.gameObject);
        }
    }

    public virtual void OnPick(PlaerView plaer)
    {
    }
}