using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedGhost : MonoBehaviour
{
    public Transform Enemy;
    public Transform spawnPoint;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag==("Player"))
        {
            FindObjectOfType<PlayerStats>().TakeDamage(Damage);
            Flip();
        }
    }

    void RespawnEnemy()
    {
        Instantiate(Enemy, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
