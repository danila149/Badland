using UnityEngine;

public class LevelPartsSpawner
{
    private ObsticalActivator _obsticalActivator = new ObsticalActivator();
    public void RandomSpawn(int level, LevelPartView[] levelPartViews, Transform spawnPosition, FinichLineView finichLineView)
    {
        LevelPartView startLevel = Object.Instantiate(levelPartViews[Random.Range(0, levelPartViews.Length)], spawnPosition);
        _obsticalActivator.RandomActivation(startLevel);
        for (int i = 0; i < level; i++)
        {
            LevelPartView levelPart = Object.Instantiate(levelPartViews[Random.Range(0, levelPartViews.Length)], spawnPosition);
            levelPart.transform.position = startLevel.LevelPartEnd1.position;
            startLevel = levelPart;
            _obsticalActivator.RandomActivation(startLevel);
        }
        finichLineView.transform.position = startLevel.LevelPartEnd1.position;
    }
}
