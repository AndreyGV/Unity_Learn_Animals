using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timer = 3;
    public float cooldown = 3;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && cooldown > timer)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldown = 0;
        }
        cooldown += Time.deltaTime;
    }
}
