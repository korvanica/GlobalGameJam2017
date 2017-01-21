﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FowScript : MonoBehaviour {

    public float _FogRadius = 11.0f;
    public float _FogMaxRadius = 1.0f;
    int signal = -1;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        UpdateMaterial();
        _FogRadius += 0.02f * signal;
        if (_FogRadius < 7) { signal = 1; }
        if (_FogRadius > 9.5) { signal = -1; }
    }

    public void UpdateMaterial()
    {
        var material = GetComponent<Renderer>().sharedMaterial;
        if (material != null)
        {
            material.SetFloat("_FogRadius", _FogRadius);
            material.SetFloat("_FogMaxRadius", _FogMaxRadius);
            material.SetVector("_PlayerPos", GameObject.Find("Player").transform.position);
        }
    }
}
