using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {

    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int enemyCount;

    public Transform topLeft;
    public Transform topRight;
    public Transform bottomLeft;
    public Transform bottomRight;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 10)
        {
            //xPos = Random.Range(-195, -104);
            //zPos = Random.Range(-104, -68);
            xPos = Random.Range((int)topLeft.position.x, (int)topRight.position.x);
            zPos = Random.Range((int)topLeft.position.z, (int)bottomLeft.position.z);
            Instantiate(theEnemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
        }



    }

}




