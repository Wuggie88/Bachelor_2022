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
    public GameObject Score;
    public GameObject Combo;
    public int ScoreVal = 0;
    public int ComboVal = 1;



    // Start is called before the first frame update
    void Start()
    {
        AnsObject = GameObject.Find("AssignmentTxt");
        AnsField = GameObject.Find("AnsField");
        answer = "DGADGAIEGQPIEGH";
        PullAnswer();
        Score = GameObject.Find("ScoreTxt");
        Combo = GameObject.Find("ComboTxt");
    }

    //function that starts a coroutine that pulls the correct answer for the current assignment.
    public void PullAnswer()
    {
        StartCoroutine(GetAns());
    }

    //Coroutine that gets the correct answer after waiting 5 seconds. this is done, so you couldn't answer with a empty answer really fast and get through the first assignment.
    IEnumerator GetAns()
    {
        yield return new WaitForSeconds(5);
        answer = AnsObject.GetComponent<Assignment>().answer;
    }

    //function that starts a coroutine to check the answer.
    public void CheckAns() {
        StartCoroutine(Check());
    }

    //coroutine that checks the inputted answer, and calculates/manages score
    //This is a coroutine, to mak sure we get the new answer for all assignments, set it and then wait before checking against the inputted field, else there's  a small chance it would do it in the wrong order.
    IEnumerator Check()
    {
        InputField input = AnsField.GetComponent<InputField>();
        fieldAns = input.text;
        yield return new WaitForEndOfFrame();

        if(fieldAns == answer)
        {
            //correct answer!
            Debug.Log("Correct");
            AnsObject.GetComponent<Assignment>().ChangeAssignment();
            ScoreVal = ScoreVal + 100 * ComboVal;
            ComboVal++;
            Score.GetComponent<Text>().text = "Score:" + ScoreVal;
            Combo.GetComponent<Text>().text = "Combo: x" + ComboVal;
        }
        else
        {
            //incorrect
            Debug.Log("Not correct, actually wrong");
            ComboVal = 1;
            Combo.GetComponent<Text>().text = "Combo: x" + ComboVal;
        }
        


    }
}
