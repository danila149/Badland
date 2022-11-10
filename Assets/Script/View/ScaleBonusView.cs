using UnityEngine;


public class ScaleBonusView : ABonusView
{
    [SerializeField] private float _scale;
    [SerializeField] private float _mass;
    public override void OnPick(PlaerView plaer)
    {

        plaer.transform.localScale = new Vector3(_scale * plaer.transform.localScale.x, _scale * plaer.transform.localScale.y, 1);
        
                plaer.Rb.mass += _mass;
    }
}

//plaer.transform.localScale += new Vector3(_scale, _scale, 0);
/*
if (plaer.transform.localScale.x == 1)
{
    Destroy(this.gameObject);
}
else
*/