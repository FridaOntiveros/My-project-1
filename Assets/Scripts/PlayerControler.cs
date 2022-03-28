using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    // PROPIEDADES
    // [HideInInspector] //No permite modificar en unity
    [Range(0,20)] //rango de valores en el siguiente dato
    [SerializeField] //Permite modificar aunque sea privado
    [Tooltip("Velocidad del auto")] //Comentario en unity
    private float speed = 5f;

    public float turnSpeed = 45f;

    public float horizontalInput, verticalInput;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        // Debug.Log("MOVIMIETO HORIZONTAL: " + horizontalInput); //mensaje 
        verticalInput = Input.GetAxis("Vertical");

        //Mover el vehiculo hacia delante, eje z
        //this.transform.Translate(0,0,1);
        // this.transform.Translate(Vector3.forward);
        // S = s0 + velocidad * tiempo * direccion
        transform.Translate(speed * Time.deltaTime * Vector3.forward * verticalInput);
        transform.Rotate(turnSpeed * Time.deltaTime * Vector3.up * horizontalInput);


    }
}
