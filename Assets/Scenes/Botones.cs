using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
    public GameObject botonArcadeVerde, botonArcade;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseOver()
    {
        botonArcade.SetActive(false);
        botonArcadeVerde.SetActive(true);
        print("entra1");
    }
    private void OnMouseExit()
    {
        botonArcade.SetActive(true);
        botonArcadeVerde.SetActive(false);
        print("entra2");
    }
}
