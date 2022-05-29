using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureSpawnManager : MonoBehaviour
{
    public GameObject[] TreasureChestPrefabs;
    public GameObject TreasureArrowPrefab;

    float timeBetweenChests = 20;
    float timeSinceChest = 19;

    float chestSpawnRadius = 50;


    // Update is called once per frame
    void Update()
    {
        if (EnemyTarget.Instance == null)
            return;

        timeSinceChest += Time.deltaTime;
        if (timeSinceChest < timeBetweenChests)
            return;

        timeSinceChest = 0;

        Vector3 offset = Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360))) * Vector3.right * chestSpawnRadius;
        Vector3 playerPos = EnemyTarget.Instance.transform.position;

        SpawnChest(playerPos + offset);
    }

    public void SpawnChest(Vector2 pos)
    {
        GameObject chestGO = Instantiate(TreasureChestPrefabs[Random.Range(0, TreasureChestPrefabs.Length)], pos, Quaternion.identity);
        Instantiate(TreasureArrowPrefab).GetComponent<TreasureArrow>().TreasureChestTarget = chestGO;

    }
}
