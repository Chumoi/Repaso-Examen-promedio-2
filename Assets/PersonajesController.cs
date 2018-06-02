using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajesController : MonoBehaviour {

    public string nombreCompleto;
    public int edad;
    public string físico;

    public PersonajesController(string nombreCompleto, int edad, string físico)
    {
        this.nombreCompleto = nombreCompleto;
        this.edad = edad;
        this.físico= físico;
    }

    public PersonajesController()
    {

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
