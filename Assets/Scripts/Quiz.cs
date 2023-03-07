using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] QuestionSO question;
    [SerializeField] GameObject[] answerButtons;
    [SerializeField] Sprite defaultAnswerSprite;
    [SerializeField] Sprite correcttAnswerSprite;

    int correctAnswerIndex;
    void Start()
    {   
        DisplayQuestion();
    }

// fast create a method, select code with mouse, hit ctrl + . and then click on extract method, then F2 name to rename it
    void DisplayQuestion()
    {
        questionText.text = question.GetQuestion();
        
        for (int i=0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = question.GetAnswer(i);
        }
    }

    

    public void OnAnswerSelected(int index)
    {

        Image buttonImage;
        if(index == question.GetCorrectAnswerIndex())
        {
            buttonImage = answerButtons[index].GetComponent<Image>();
            buttonImage.sprite = correcttAnswerSprite;
            questionText.text = "Correct!";
        }
        else 
        {
            buttonImage = answerButtons[question.GetCorrectAnswerIndex()].GetComponent<Image>();
            buttonImage.sprite = correcttAnswerSprite;
            questionText.text = "Sorry, the correct answer was;\n" + question.GetCorrectAnswer();
        }
    }

}
