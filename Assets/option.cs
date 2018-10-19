using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class option : MonoBehaviour
{

    public bool isCorrect;

    public GameObject core;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;

    void OnMouseDown()
    {
        if (isCorrect)
        {
            GetComponent<TextMesh>().color = Color.green;
        }
        else
        { 
            if (core.GetComponent<Gamecontroller>().option == 0)
            {
                option1.GetComponent<TextMesh>().color = new Color(1, 0.6f, 0.4f, 1);
            }

            else if (core.GetComponent<Gamecontroller>().option == 1)
            {
                option2.GetComponent<TextMesh>().color = new Color(1, 0.6f, 0.4f, 1);

            }

            else if (core.GetComponent<Gamecontroller>().option == 2)
            {
                option3.GetComponent<TextMesh>().color = new Color(1, 0.6f, 0.4f, 1);

            }
            GetComponent<TextMesh>().color = Color.grey;


        }
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
