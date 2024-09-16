using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float buttonCooldown = 1;

    // Update is called once per frame
    void Update()
    {


        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && buttonCooldown <=0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            buttonCooldown = 1;

        }

        if (buttonCooldown >= 0)
        {
            buttonCooldown -= Time.deltaTime;
        }
    }
}
