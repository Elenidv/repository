using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 60f;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        if (currentTime >= 0)
        {
            print(currentTime);
        }
       
    }
}
