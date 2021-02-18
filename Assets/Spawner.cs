using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Tooltip("Enemy prefab")]
    public GameObject enemyPrefab;
    public List<GameObject> spawners;

    List<Rigidbody2D> enemies;

    public float minTime = 2.0f;
    public float maxTime = 4.0f;
    public float waitTime = 0.0f;

    float outTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = Random.Range(minTime, maxTime);
        enemies = new List<Rigidbody2D>();
        InstantiateEnemies();
        //StartCoroutine("SpawnEnemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InstantiateEnemies()
    {
        for (int i = 0; i < spawners.Count; ++i)
        {
            Rigidbody2D rb = Instantiate(enemyPrefab, spawners[i].transform.position, enemyPrefab.transform.rotation, spawners[i].transform).GetComponent<Rigidbody2D>();
            //rb.gameObject.SetActive(false);
            rb.gameObject.transform.SetPositionAndRotation(rb.gameObject.transform.position, Quaternion.Euler(-115, 180, -180));
            enemies.Add(rb);
        }
    }
    //IEnumerator SpawnEnemy()
    //{
    //    while(true)
    //    {
    //        yield return new WaitForSeconds(waitTime);
    //        StartCoroutine("HideOutEnemy");

    //    }
    //}

    //IEnumerator HideOutEnemy()
    //{
    //    bool finish = false;
    //    while(!finish)
    //    {
    //        enemy.MovePosition(Vector2.up);
    //        yield return new WaitForSeconds(0.1f);

    //    }
    //}
}
