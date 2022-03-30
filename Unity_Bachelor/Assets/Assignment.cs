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
    public GameObject AssImg;

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
        AssImg = GameObject.Find("AssImg");
        AnsField = GameObject.Find("AnsField");
        InputField input = AnsField.GetComponent<InputField>();
        
        input.text = "";
        switch (MyEnums)
        {
            case myEnums.ShootPyt1:
                x = 80;
                y = 45;
                AssImg.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Lootbox1");
                AssText.text = "Pythagoras opgave 1" +
                    " \n \n Pythagoras kan bruges til at finde længden på C i en retvinklet trekant.\n" +
                    "Dette kan også bruges til at finde længden på tværs af en firkant, da den kan opdeles i to trekanter.\n" +
                    "Forestil dig du har en lootbox og du vil gerne vide om der kan være et specifikt våben inden i, men våbnet er længere end kassens længde, derfor skal det ligge på tværs.\n" +
                    "Våbnet er 87CM langt, og kassen er 80cm lang, og 45cm bred.\n \n" +
                    "Pythagoras ligning hedder A^2 + B^2 = C^2 \n \n" +
                    "A og B kan ses på billedet og den omvendte funktion af ^2 er kvadratrod. \n" +
                    "Hvor lang er kassen på tværs? (skriv svar uden cm)";
                answer = (System.Math.Round(Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2)), 2)).ToString();
                break;

            case myEnums.ShootPyt2:
                x = Random.Range(10, 100);
                y = Random.Range(10, 100);
                AssImg.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Map1");
                AssText.text = "Pythagoras opgave 2 \n \n" +
                    "Du har vundet mappet, men vil gerne have et våben der er blevet smidt på trappen ovre på den anden side \n" +
                    "Men du vil gerne vide hvor langt der er derhen \n \n" +
                    "I denne opgave er A " + x + " og B er " + y +" \n \n " +
                    "Hvad er C? (Den korteste vej til våbnet)";
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
