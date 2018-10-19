using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour
{

    public string randomOperator;
    public int answer;

    public GameObject core;

    public GameObject question;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;

    public int option;


    void OnMouseDown()
    {
        option1.GetComponent<TextMesh>().color = Color.white;
        option2.GetComponent<TextMesh>().color = Color.white;
        option3.GetComponent<TextMesh>().color = Color.white;

        core.GetComponent<Gamecontroller>().GenerateQuestion();
    }


    // Update is called once per frame
    void Update()
    {

    }
        }