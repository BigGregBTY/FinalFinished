using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour {

    public GameObject explosion;
    public GameObject enemyType2;
    public float minReloadTime = 1.0f;
    public float maxReloadTime = 2.0f;

    public int hitsToDie = 1;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("Shoot");
        GameController.SharedInstance.EnemySeen();
    }

    IEnumerator Shoot()
    {
        yield return new WaitForSeconds((Random.Range(minReloadTime, maxReloadTime)));
        while (true)
        {
            Instantiate(enemyType2, gameObject.transform.position, gameObject.transform.rotation);
            yield return new WaitForSeconds((Random.Range(minReloadTime, maxReloadTime)));
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Boundary" && other.gameObject.name != "Top Boundary")
        {
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player Bullet")
        {
            hitsToDie--;

            if (hitsToDie <= 0)
            {
                GameController.SharedInstance.IncrementScore(100);
                float randomNumber = Random.Range(0.0f, 10.0f);

                Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
                gameObject.SetActive(false);

                GameController.SharedInstance.EnemyDied();
            }

            other.gameObject.SetActive(false);
        }
    }
}
