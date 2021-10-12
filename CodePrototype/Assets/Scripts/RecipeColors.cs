using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeColors : MonoBehaviour
{
    public Material Material1;
    public Material Material2;
    public Material Material3;
    public Material Material4;
    public Material Material5;
   

    void Start()
    {
        int randomNumber = Random.Range(1, 5);
        Debug.Log(randomNumber);

        if (randomNumber == 1)
        {
            GetComponent<Renderer>().material = Material1;
        }
       else if (randomNumber == 2)
        {
            GetComponent<Renderer>().material = Material2;
        }
        else if (randomNumber == 3)
        {
            GetComponent<Renderer>().material = Material3;
        }
        else if (randomNumber == 4)
        {
            GetComponent<Renderer>().material = Material4;
        }
        else if (randomNumber == 5)
        {
            GetComponent<Renderer>().material = Material5;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
