﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ingresso : MonoBehaviour
{
    public GameObject prefab;
    public int id;
    public GameObject sezione;

    // Use this for initialization
    void Start()
    {
        //InvokeRepeating("CreateCar", 0.0f, 2f);
        CreateCar();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateCar()
    {
        GameObject temp = (GameObject)Instantiate(prefab,this.transform.position,Quaternion.identity);
        //Debug.Log(this.transform.parent.gameObject.name);
        temp.GetComponent<CarMove>().sezione = sezione;
    }
}