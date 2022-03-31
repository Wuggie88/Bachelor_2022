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

    // Update is called once per frame
    void Update()
    {

    }

    public void PullAnswer()
    {
        StartCoroutine(GetAns());
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
