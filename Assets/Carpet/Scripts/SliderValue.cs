using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
    [SerializeField]
    Slider m_UVSlider;

    [SerializeField]
    TMP_Text m_SliderDisplayValue;
    
    void OnEnable()
    {
        m_UVSlider.onValueChanged.AddListener(delegate {UpdateValueText();});
        m_SliderDisplayValue.text = m_UVSlider.value.ToString();
    }

    void UpdateValueText()
    {
        m_SliderDisplayValue.text = m_UVSlider.value.ToString();
    }
    
}
