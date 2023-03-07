using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quizz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [SerializeField] [TextArea(2,6)] private string question = "Enter new question text here";
    [SerializeField] string[] answers = new string[4];

    [SerializeField] int correctAnswerIndex;

    public string GetQuestion()
    {
        return question;
    }

    public string GetCorrectAnswer()
    {
        return answers[correctAnswerIndex];
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }

    public string[] GetAnswers()
    {
        return answers;
    }

    public string GetAnswer(int index)
    {
        return answers[index];
    }
}
