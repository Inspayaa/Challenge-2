using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timeDelay = 2.0f;
    bool doneWaiting = false;
    
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog, prevent spam, delay by 2 seconds
        if (timeDelay > 0)
        {
            timeDelay -= Time.deltaTime;
        }
        
        else
        {
            doneWaiting = true;
            if (Input.GetKeyDown(KeyCode.Space) && doneWaiting)
            {
                getDogPrefab();
               timeDelay = 2;
            }
        }
        
        
        void getDogPrefab()
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }

    }


}
