﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;


public class ObjectSpwaner : MonoBehaviour
{
    public GameObject ucgen, kup, dikdortgen, a, b, c, bir, iki, uc, kedi, kaz, papagan, kus, yilan, yunus;
    private PlacementIndicator placementIndicator;

    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
    }

    public void Ucgen()
    {
        GameObject obj = Instantiate(ucgen, placementIndicator.transform.position, placementIndicator.transform.rotation);
    }

    public void Kup()
    {
        GameObject obj = Instantiate(kup, placementIndicator.transform.position, placementIndicator.transform.rotation);
    }

    public void Dikdortgen()
    {
        GameObject obj = Instantiate(dikdortgen, placementIndicator.transform.position, placementIndicator.transform.rotation);
    }

    public void A()
    {
        GameObject obj = Instantiate(a, placementIndicator.transform.position, placementIndicator.transform.rotation);
    }

    public void B()
    {
        GameObject obj = Instantiate(b, placementIndicator.transform.position, placementIndicator.transform.rotation);
    }

    public void C()
    {
        GameObject obj = Instantiate(c, placementIndicator.transform.position, placementIndicator.transform.rotation);
    }

    public void Bir()
    {
        GameObject obj = Instantiate(bir, placementIndicator.transform.position, placementIndicator.transform.rotation);
    }

    public void İki()
    {
        GameObject obj = Instantiate(iki, placementIndicator.transform.position, placementIndicator.transform.rotation);
    }

    public void Uc()
    {
        GameObject obj = Instantiate(uc, placementIndicator.transform.position, placementIndicator.transform.rotation);
    }

    public void Yilan()
    {
        GameObject obj = Instantiate(yilan, placementIndicator.transform.position, placementIndicator.transform.rotation);
    }
    public void Kedi()
    {
        GameObject obj = Instantiate(kedi, placementIndicator.transform.position, placementIndicator.transform.rotation);
    }
    public void Kaz()
    {
        GameObject obj = Instantiate(kaz, placementIndicator.transform.position, placementIndicator.transform.rotation);
    }
    public void Kus()
    {
        GameObject obj = Instantiate(kus, placementIndicator.transform.position, placementIndicator.transform.rotation);
    }
    public void Yunus()
    {
        GameObject obj = Instantiate(yunus, placementIndicator.transform.position, placementIndicator.transform.rotation);
    }

    public void Papagan()
    {
        GameObject obj = Instantiate(papagan, placementIndicator.transform.position, placementIndicator.transform.rotation);
    }

    //void Update()
    //{
    //    if( Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
    //    {
    //        GameObject obj = Instantiate(objectToSpawn, placementIndicator.transform.position, placementIndicator.transform.rotation);
    //    }
    //}
}
