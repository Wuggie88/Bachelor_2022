using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer : MonoBehaviour
{

    public string answer;
    public string fieldAns;
    public GameObject AnsObject;
    public GameObject AnsField;


    // Start is called before the first frame update
    void Start()
    {
        AnsObject = GameObject.Find("AssignmentTxt");
        AnsField = GameObject.Find("AnsField");
        answer = "DGADGAIEGQPIEGH";
        StartCoroutine(GetAns());
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator GetAns()
    {
        yield return new WaitForSeconds(5);
        answer = AnsObject.GetComponent<Assignment>().answer;
    }

    public void CheckAns() {
        StartCoroutine(Check());
    }

    IEnumerator Check()
    {
        InputField input = AnsField.GetComponent<InputField>();
        fieldAns = input.text;
        yield return new WaitForEndOfFrame();

        if(fieldAns == answer)
        {
            //correct answer!
            Debug.Log("Correct");
        }
        else
        {
            //incorrect
            Debug.Log("Not correct, actually wrong");
        }
        


    }
}
