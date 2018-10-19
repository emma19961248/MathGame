using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecontroller : MonoBehaviour
{

    public string randomOperator;
    public int answer;

    public GameObject question;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;

    public int option;

    // Use this for initialization
    void Start()
    {

      GenerateQuestion();

    }

    // Update is called once per frame
    void Update()
    {
    }


    public void GenerateQuestion()
    {
        int a = Random.Range(0, 101);
        int b = Random.Range(0, 101);
        int c = Random.Range(0, 21);

        int operatorNumber = Random.Range(0, 2);
        if (operatorNumber == 0)
        {
            randomOperator = "+";
            answer = (a + b) * c;
        }
        if (operatorNumber == 1)
        {
            randomOperator = "-";
            answer = (a - b) * c;
        }


        question.GetComponent<TextMesh>().text = "("+ a + " " + randomOperator + " " + b + ")" + "" + "*" + "" + c + " = ?";


        option = Random.Range(0, 3);
        if (option == 0)
        {
            option1.GetComponent<TextMesh>().text = answer.ToString();
            option2.GetComponent<TextMesh>().text = (answer + Random.Range(-5, 0)).ToString();
            option3.GetComponent<TextMesh>().text = (answer + Random.Range(1, 6)).ToString();
            option1.GetComponent<option>().isCorrect = true;
            option2.GetComponent<option>().isCorrect = false;
            option3.GetComponent<option>().isCorrect = false;
        }

        else if (option == 1)
        {
            option1.GetComponent<TextMesh>().text = (answer + Random.Range(-5, 0)).ToString();
            option2.GetComponent<TextMesh>().text = answer.ToString();
            option3.GetComponent<TextMesh>().text = (answer + Random.Range(1, 6)).ToString();
            option1.GetComponent<option>().isCorrect = false;
            option2.GetComponent<option>().isCorrect = true;
            option3.GetComponent<option>().isCorrect = false;

        }

        else if (option == 2)
        {
            option1.GetComponent<TextMesh>().text = (answer + Random.Range(1, 6)).ToString();
            option2.GetComponent<TextMesh>().text = (answer + Random.Range(-5, 0)).ToString(); 
            option3.GetComponent<TextMesh>().text = answer.ToString(); 
            option1.GetComponent<option>().isCorrect = false;
            option2.GetComponent<option>().isCorrect = false;
            option3.GetComponent<option>().isCorrect = true;
        }
       




    }

}
