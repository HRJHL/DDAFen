using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class action : MonoBehaviour
{
    private Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    float timer;
    int waitingTime;
    // Start is called before the first frame update
    void Start()
    {
        bulletSpawnPoint = this.transform.Find("point");
        timer = 0f;
        waitingTime = 4;
    }

    // Update is called once per frame
    void Update()

    {
        timer += Time.deltaTime;
        if(timer > waitingTime){
            var bulletGo = Instantiate<GameObject>(this.bulletPrefab);
            bulletGo.transform.position = this.bulletSpawnPoint.position;
            timer = 0;
        }
    }
}
