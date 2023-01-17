using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Castle1WatchLevel2: MonoBehaviour
{
    public GameObject playerPosition;
    public GameObject castle_1;
    public GameObject bird;
    public GameObject gold;
    private bool destroyed = false;
    void Start()
    {
        StartCoroutine(checkPosition());
    }

    IEnumerator checkPosition()
    {
        yield return new WaitForSeconds(2);
        if (!destroyed)
        {
            if (Mathf.Abs(playerPosition.transform.position.x - transform.position.x) > 90.0F)
            {
                destroyed = true;
                Destroy(GameObject.Find("Castle1Level2(Clone)"), 0.0F);

            }
        }
        if (destroyed)
        {
            if (Mathf.Abs(playerPosition.transform.position.x - transform.position.x) < 90.0F)
            {
                destroyed = false;
                addBirds();
                Instantiate(castle_1, new Vector3(18.09F, 25.16F, 0), Quaternion.identity);

            }
        }
        StartCoroutine(checkPosition());
    }

    public void addBirds()
    {
        System.Random rand = new System.Random();
        for (int i = 0; i < rand.Next(3, 9); i++)
        {
            if (i % 2 == 0)
            {
                var bidr = Instantiate(bird, new Vector3(rand.Next(-10, 50), rand.Next(25, 70), 0), Quaternion.identity);
                bidr.GetComponent<bird1>().napravl = -1.0F;
                Instantiate(gold, new Vector3(rand.Next(-10, 50), rand.Next(25, 70), 0), Quaternion.identity);
            }
            else
            {
                var bidr = Instantiate(bird, new Vector3(rand.Next(-10, 50), rand.Next(25, 70), 0), Quaternion.identity);
                bidr.GetComponent<bird1>().napravl = 1.0F;
                Instantiate(gold, new Vector3(rand.Next(-10, 50), rand.Next(25, 70), 0), Quaternion.identity);
            }
        }
    }
}
