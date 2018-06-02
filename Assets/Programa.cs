using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Programa : MonoBehaviour
{

    public Transform target;

    public GameObject personaje1, personaje2, personaje3, personaje4;
    GameObject imagenBorrar;

    public Text info;

    List<PersonajesController> personaje = new List<PersonajesController>();

    // Use this for initialization
    void Start()
    {
        Debug.Log("Bienvenido, se te presentarán 4 personajes, presiona en el botón para ver más información.");
        personaje.Add(new PersonajesController("Juana Del Arco", 27, "a pesar de ser algo flacucha, es muy buena usando el arco y flecha."));
        personaje.Add(new PersonajesController("Garen Spinner", 22, "en físico es robusto y grande, experto con la espada."));
        personaje.Add(new PersonajesController("Havana Banana", 30, "alguna vez fue una celestial, ahora utiliza las estrellas para ayudar a sus aliados."));
        personaje.Add(new PersonajesController("Khada Jhin", 24, "es un meticuloso criminal que ve el asesinato como arte, a través de su rifle."));

        //

        imagenBorrar = GameObject.FindGameObjectWithTag("PersonajeActual");
    }

    public void Button_Click(GameObject objeto)
    {
        Instantiate(objeto, target);
    }

    // Update is called once per frame
    void Update()
    {
        imagenBorrar = GameObject.FindGameObjectWithTag("PersonajeActual");

        if (target.transform.childCount > 1)
        {
            Destroy(imagenBorrar);
        }
    }

    public void Button_Info()
    {

    }

}
