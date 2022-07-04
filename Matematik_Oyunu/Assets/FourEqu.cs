
using UnityEngine;
using UnityEngine.UI;

public class FourEqu : MonoBehaviour
{
    public Text firstNumber, secondNumber, equationSymbol,answer, result;
    public UnityEngine.UI.InputField answerInput;
    int number1, number2, equSymbol;
    int equationAnswer;

    void Start()
    {
       newQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
// with using int.parse() we changed the string text to int
    public void answerControl()
        {
        if(int.Parse(answer.text) == equationAnswer)
        {
            result.text = "TRUE";
        }
        else
        {
            result.text = "FALSE";
        }
    
        }

    public void newQuestion()
    {
        answerInput.text = "";
        result.text = "";
 // Our second number in range is excluded.
        number1 = Random.Range(1,11);
        number2 = Random.Range(1,11);
        equSymbol = Random.Range(1,5);
        
        switch (equSymbol)
        {
            case 1:
            equationSymbol.text = "+";
            equationAnswer = number1 + number2;
            break;
        }
        switch (equSymbol)
        {
            case 2:
            equationSymbol.text = "-";
            equationAnswer = number1 - number2;
            break;
        }
        switch (equSymbol)
        {
            case 3:
            equationSymbol.text = "*";
            equationAnswer = number1 * number2;
            break;
        }
        switch (equSymbol)
        {
            case 4:
            equationSymbol.text = "/";
            equationAnswer = number1 / number2;
            break;
        }

        firstNumber.text =  number1 + "";
        secondNumber.text = number2 + "" ;
        
    }
}
