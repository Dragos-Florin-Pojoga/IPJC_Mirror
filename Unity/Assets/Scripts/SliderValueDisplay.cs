using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderValueDisplay : MonoBehaviour
{
    public Slider slider;
    public TMP_Text valueText;

    void Start()
    {
        UpdateText(slider.value);
    }

    public void ChangeValue()
    {
        UpdateText(slider.value);
    }

    public void UpdateText(float value)
    {
        valueText.text = value.ToString("0.00");
    }
}
