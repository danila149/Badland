using UnityEngine;

public class ObsticalActivator
{
    public void RandomActivation(LevelPartView levelPartView)
    {
        for (int i = 0; i < 6; i++)
        {
            levelPartView.AObsticleViews[Random.Range(0, levelPartView.AObsticleViews.Length)].gameObject.SetActive(true);
        }
    }
}
