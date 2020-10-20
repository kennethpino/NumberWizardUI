using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Predict : MonoBehaviour
{
    TMP_Text predictionDisplay = default;
    TMP_Text continueText = default;
    TMP_InputField inputField = default;
    Button continueButton = default;
    Button higherButton = default;
    Button lowerButton = default;

    int max = 1001;
    int min = 0;
    int prediction;

    public void Start()
    {
        predictionDisplay = GameObject.FindGameObjectWithTag("predictionDisplay").GetComponent<TMP_Text>();
        continueText = GameObject.FindGameObjectWithTag("continueText").GetComponent<TMP_Text>();
        inputField = GameObject.FindGameObjectWithTag("inputField").GetComponent<TMP_InputField>();
        continueButton = GameObject.FindGameObjectWithTag("continueButton").GetComponent<Button>();
        higherButton = GameObject.FindGameObjectWithTag("higherButton").GetComponent<Button>();
        lowerButton = GameObject.FindGameObjectWithTag("lowerButton").GetComponent<Button>();

        continueText.color = new Color32(255, 0, 0, 255);
        continueButton.interactable = false;
        higherButton.interactable = false;
        lowerButton.interactable = false;

        PredictNextNumber();
    }

    public void PredictNumber(string name)
    {
        if (name.Equals("higher"))
        {
            min = prediction + 1;
            PredictNextNumber();
        }
        else if (name.Equals("lower"))
        {
            max = prediction - 1;
            PredictNextNumber();
        }
    }

    private void PredictNextNumber()
    {
        prediction = Random.Range(min, max);
        predictionDisplay.text = prediction.ToString();

        if(predictionDisplay.text == inputField.text)
        {
            continueText.color = new Color32(0, 255, 0, 255);
            continueButton.interactable = true;
        }
    }
}
