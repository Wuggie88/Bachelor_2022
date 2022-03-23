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

                    
        }


        yield return new WaitForEndOfFrame();
    }
    
}
