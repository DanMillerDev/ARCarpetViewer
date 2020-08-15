using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarpetController : MonoBehaviour
{
    [SerializeField]
    Slider m_UVSlider;

    [SerializeField]
    Material m_CarpetMat;

    [SerializeField]
    Texture[] m_CarpetTextures;

    void OnEnable()
    {
        m_UVSlider.onValueChanged.AddListener(delegate { UpdateUV();});
        m_CarpetMat.mainTextureScale = new Vector2(m_UVSlider.value, m_UVSlider.value);
    }

    void UpdateUV()
    {
        m_CarpetMat.mainTextureScale = new Vector2(m_UVSlider.value, m_UVSlider.value);
    }

    public void SetCarpet(int arrayIndex)
    {
        m_CarpetMat.mainTexture = m_CarpetTextures[arrayIndex];
    }
    
}
