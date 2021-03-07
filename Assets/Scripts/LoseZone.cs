using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseZone : MonoBehaviour
{
    [SerializeField]
    private GameObject _platform;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag(_platform.tag))
        {
            collision.collider.transform.localPosition = PlatformGenerate.GetUpdatedSpawnerPosition();
        }
    }
}
