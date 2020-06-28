using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Quest
{
    public string Question;
    public string correctAnswer;
}

public class Question : MonoBehaviour
{
    public List<Quest> Questions;
    public InputField inputField;
    public Text ShowText = null;
    private int QIndex = 0;

    private string Result = "";
    private string m_Quest;
    private string m_Answer;
    // Start is called before the first frame update
    void Start()
    {
        LoadQuestion();
    }
    private void LoadQuestion()
    {
        QIndex = Random.Range(0, Questions.Count);
        m_Quest = Questions[QIndex].Question;
        m_Answer = Questions[QIndex].correctAnswer;

        ShowText.text = string.Format("Q{0}. {1}", QIndex, m_Quest);
    }
    public void OnClickSubmitBtn()
    {
        Result = inputField.text;

        Debug.Log(Result.Contains(m_Answer));

        if (Result.Contains(m_Answer))
        {
            ShowText.text = string.Format("정답입니다. \nQ{0}. {1}", QIndex, m_Quest);

            Invoke("LoadQuestion", 2.0f);
        }
        else
        {
            ShowText.text = string.Format("오답입니다. \nQ{0}. {1}", QIndex, m_Quest);
        }
        inputField.text = "";
    }
}
