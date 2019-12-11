﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScanButton : MonoBehaviour, IPointerClickHandler
{
    public static ScanButton instance;

    public GameObject profileTab;
    public Vector3 boxSize; 

    private bool m_HitDetect;
    private GameObject hitTarget;

    private Collider m_Collider;
    private RaycastHit m_Hit;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }
    
    public void OnPointerClick(PointerEventData eventData)
    {
        //m_HitDetect = Physics.BoxCast(m_Collider.bounds.center)
        if (!profileTab.activeSelf)
        {
            profileTab.SetActive(true);
        }
    }
}