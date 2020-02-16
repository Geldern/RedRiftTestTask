using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPlanet", menuName = "NewPlanetData")]
public class PlanetData : ScriptableObject
{
    public Color SkyColor;
    public float Gravity;
}
