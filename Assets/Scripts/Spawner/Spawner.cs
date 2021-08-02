using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<Sector> _sectorKinds;
    [SerializeField] private Sector _firstSector;
    [SerializeField] private PlayerLife _player;
    [SerializeField] private float _distancePlayerAndSpawn;

    private List<Sector> _spawnedSectors = new List<Sector>();

    private void Start()
    {
        _spawnedSectors.Add(_firstSector);
    }

    private void Update()
    {
        if (_player.transform.position.x >= _spawnedSectors[_spawnedSectors.Count - 1].EndPoint.position.x - _distancePlayerAndSpawn)
        {
            SpawnSector();
        }
    }

    private void SpawnSector()
    {
        var newSector = Instantiate(_sectorKinds[Random.Range(0, _sectorKinds.Count)]);
        newSector.transform.position = _spawnedSectors[_spawnedSectors.Count - 1].EndPoint.position - newSector.StartPoint.localPosition;
        _spawnedSectors.Add(newSector);

        if (_spawnedSectors.Count >= 5)
        {
            Destroy(_spawnedSectors[0].gameObject);
            _spawnedSectors.RemoveAt(0);
        }
    }
}
