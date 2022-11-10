using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPartView : MonoBehaviour
{
    [SerializeField] private Transform _levelPartEnd;
    [SerializeField] private AObsticleView[] aObsticleViews;

    public Transform LevelPartEnd1 { get => _levelPartEnd;}
    public AObsticleView[] AObsticleViews { get => aObsticleViews;}
}
