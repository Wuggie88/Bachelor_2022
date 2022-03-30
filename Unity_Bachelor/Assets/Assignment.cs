using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Assignment : MonoBehaviour
{

    public string answer;
    public Text AssText;
    public float x;
    public float y;
    public GameObject AnsField;

    public enum myEnums {ShootPyt1, ShootPyt2, ShootDiv1, ShootDiv2, HorseMul1, HorseMul2, HorseDiv1, HorseDiv2};

    public myEnums MyEnums;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartUp());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StartUp()
    {
        AnsField = GameObject.Find("AnsField");
        InputField input = AnsField.GetComponent<InputField>();
        //input.text = "";
        switch (MyEnums)
        {
            case myEnums.ShootPyt1:
                x = 80;
                y = 45;
                AssText.text = "Pyt1";
                answer = (System.Math.Round(Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2)), 2)).ToString();
                break;

            case myEnums.ShootPyt2:
                x = Random.Range(10, 100);
                y = Random.Range(10, 100);
                AssText.text = "Your two numbers are " + x + " and " + y;
                answer = (System.Math.Round(Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2)), 2)).ToString();
                break;

            case myEnums.ShootDiv1:
                x = 10;
                y = 5;
                AssText.text = "Div1";
                answer = (x / y).ToString();
                break;

            case myEnums.ShootDiv2:
                x = Random.Range(20, 100);
                y = Random.Range(2, 20);
                AssText.text = "Your two numbers are " + x + " and " + y;
                answer = System.Math.Round(x / y, 2).ToString();
                break;

            case myEnums.HorseDiv1:
                x = 10;
                y = 5;
                AssText.text = "Div1";
                answer = (x / y).ToString();
                break;

            case myEnums.HorseDiv2:
                x = Random.Range(20, 100);
                y = Random.Range(2, 20);
                AssText.text = "Your two numbers are " + x + " and " + y;
                answer = System.Math.Round(x / y, 2).ToString();
                break;

            case myEnums.HorseMul1:
                x = 10;
                y = 5;
                AssText.text = "Mul1";
                answer = (x * y).ToString();
                break;

            case myEnums.HorseMul2:
                x = Random.Range(20, 100);
                y = Random.Range(2, 20);
                AssText.text = "Your two numbers are " + x + " and " + y;
                answer = System.Math.Round(x * y, 2).ToString();
                break;

        }


        yield return new WaitForEndOfFrame();
    }

    public void ChangeAssignment()
    {
        switch (MyEnums)
        {
            case myEnums.ShootPyt1:
                MyEnums = myEnums.ShootPyt2;
                StartCoroutine(StartUp());
                break;

            case myEnums.ShootDiv1:
                MyEnums = myEnums.ShootDiv2;
                StartCoroutine(StartUp());
                break;

            case myEnums.HorseDiv1:
                MyEnums = myEnums.HorseDiv2;
                StartCoroutine(StartUp());
                break;

            case myEnums.HorseMul1:
                MyEnums = myEnums.HorseMul2;
                StartCoroutine(StartUp());
                break;
        }
    }
    
}
