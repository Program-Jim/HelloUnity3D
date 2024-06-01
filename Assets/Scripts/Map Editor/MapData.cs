using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapData
{
    public List<ObstacleEntry> obstacles;
    public float[] playerSpawnPoint = new float[3];
    public GroundEntry ground;

    public MapData(List<ObstacleEntry> _obstacles, float[] _playerSpawnPoint, GroundEntry _ground)
    {
        obstacles = _obstacles;
        playerSpawnPoint = _playerSpawnPoint;
        ground = _ground;
    }

}
