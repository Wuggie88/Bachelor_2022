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
                    "Du har vundet runden, men vil gerne have et våben der er blevet smidt på trappen ovre på den anden side \n" +
                    "Men du vil gerne vide hvor langt der er derhen \n \n" +
                    "I denne opgave er A " + x + " og B er " + y +" \n \n " +
                    "Hvad er C? (Den korteste vej til våbnet)";
                answer = (System.Math.Round(Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2)), 2)).ToString();
                break;

            case myEnums.ShootDiv1:
                x = 180;
                y = 30;
                AssImg.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Mag1");
                AssText.text = "Dividere Opgave 1 \n \n" +
                    "Du har " + x + " patroner og der kan være "+ y +" i hvert magazin \n" +
                    "Man kan finde ud af hvor mange magaziner der skal bruges, ved at dividere det antal patroner man har, med hvor mange der kan være i hvert magazin. \n \n" +
                    "Hvor mange magaziner skal du bruge til de " + x + " patroner?";
                answer = (x / y).ToString();
                break;

            case myEnums.ShootDiv2:
                x = Random.Range(16, 80);
                y = Random.Range(5, 16);
                AssImg.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Map1"); //remember to change this image
                AssText.text = "Dividere Opgave 2 \n \n" +
                    "Du vil gerne finde ud af hvor mange kills du har i gennemsnit per runde \n \n" +
                    "Du har " + x +" kills og har spillet " + y + " runder \n \n" +
                    "Hvor mange kills har du i gennemsnit per runde?";
                answer = System.Math.Round(x / y, 2).ToString();
                break;

            case myEnums.HorseDiv1:
                x = 120;
                y = 10;
                AssImg.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Stald1");
                AssText.text = "Dividere Opgave 1\n\n" +
                    "Ved en rideklub er der opstaldning til heste \n" +
                    "De har " + x + " heste der skal i stald, hver stald kan have " + y + " heste \n \n" +
                    "For at finde ud af hvor mange stalde vi skal bruge kan vi dividere antal heste, med hvor mange der kan være per stald \n" +
                    "Hvor mange stalde skal vi bruge til de " + x + " heste, når hver stald kan have" + y + " heste?";
                answer = (x / y).ToString();
                break;

            case myEnums.HorseDiv2:
                x = Random.Range(20, 100);
                y = 4;
                AssImg.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Hestesko1");
                AssText.text = "Dividere Opgave 2 \n \n" +
                    "Hestene skal have nye sko. \n" +
                    "Der er ankommet " + x + " nye sko og der skal bruges 4 sko per hest. \n" +
                    "Hvor mange heste kan få nye sko (rund ned til nærmeste hele tal)?";
                answer = System.Math.Round(x / y - 0.5, 0).ToString();
                break;

            case myEnums.HorseMul1:
                x = 7;
                y = 4;
                AssImg.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Ridning1");
                AssText.text = "Gange Opgave 1 \n\n" +
                    "Du vil gerne vide hvor langt du rider om ugen på din hest \n \n" +
                    "Du ved at den rute du normalt tager er 7km, og du rider 4 gange om ugen \n\n" +
                    "Hvor langt rider du på en uge? (svar angives uden km)";
                answer = (x * y).ToString();
                break;

            case myEnums.HorseMul2:
                x = Random.Range(800, 1200);
                y = Random.Range(2, 12);
                AssImg.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Stald2");
                AssText.text = "Gange Opgave 2 \n\n" +
                    "Du har en hest du gerne vil have i stald, derfor skal der lejes en plads. \n\n" +
                    "Det koster " + x + "kr om måneden og du vil gerne have din hest i stalden i " + y + " måneder\n \n" +
                    "Hvad koster det dig at have hesten i stald? (Svar angives uden kr)";
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
