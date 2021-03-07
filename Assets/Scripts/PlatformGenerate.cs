using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerate : MonoBehaviour
{
    public GameObject platformPrefab;

    public Vector3 SpawnerPosition;
    public int numberOfPlatforms = 10;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;
    [SerializeField]
    private Transform _parent;

    public static PlatformGenerate instance;
    void Start()
    {
        if (instance == null)                        
        {
            instance = this;
        }

        for (int i = 0; i < numberOfPlatforms; i++)                
        {
            GeneratePlatform();
        }
    }

    public static void GeneratePlatform()
    {
        instance.SpawnerPosition.x = Random.Range(-instance.levelWidth, instance.levelWidth);
        instance.SpawnerPosition.y += Random.Range(instance.minY, instance.maxY);

        GameObject platform = Instantiate(instance.platformPrefab, Vector3.one, Quaternion.identity, instance._parent);
        platform.transform.localPosition = instance.SpawnerPosition;
    }
    public static Vector3 GetUpdatedSpawnerPosition()
    {
        instance.SpawnerPosition.x = Random.Range(-instance.levelWidth, instance.levelWidth);
        instance.SpawnerPosition.y += Random.Range(instance.minY, instance.maxY);

        return instance.SpawnerPosition;
    }
}
