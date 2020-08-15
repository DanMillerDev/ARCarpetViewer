using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class CarpetController : MonoBehaviour
{
    [SerializeField]
    Slider m_UVSlider;

    [SerializeField]
    Material m_CarpetMat;

    [SerializeField]
    Texture[] m_CarpetTextures;

    [SerializeField]
    ARPlaneManager m_PlaneManager;

    Material[] m_PlaneMaterials;

    Vector2 m_NewUVs;
    
    void OnEnable()
    {
        m_UVSlider.onValueChanged.AddListener(delegate { UpdateUV();});
        m_CarpetMat.mainTextureScale = new Vector2(m_UVSlider.value, m_UVSlider.value);
    }

    void UpdateUV()
    {
        m_NewUVs =  new Vector2(m_UVSlider.value, m_UVSlider.value);

        m_CarpetMat.mainTextureScale = m_NewUVs;

        foreach (ARPlane plane in m_PlaneManager.trackables)
        {
            plane.GetComponent<MeshRenderer>().sharedMaterial.mainTextureScale = m_NewUVs;
        }
    }

    public void SetCarpet(int arrayIndex)
    {
        m_CarpetMat.mainTexture = m_CarpetTextures[arrayIndex];
        
        foreach (ARPlane plane in m_PlaneManager.trackables)
        {
            plane.GetComponent<MeshRenderer>().sharedMaterial.mainTexture = m_CarpetTextures[arrayIndex];
        }
    }
    
}
