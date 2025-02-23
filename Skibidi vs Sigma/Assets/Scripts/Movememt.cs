using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movememt : MonoBehaviour
{
    public float velocidad = 5f;

    // Update is called once per frame
    void Update()
    {
        // Obtener los valores de movimiento en el eje X y Z
        float movimientoX = Input.GetAxis("Horizontal"); // A/D o flechas izquierda/derecha
        float movimientoZ = Input.GetAxis("Vertical"); // W/S o flechas arriba/abajo

        // Crear un vector de movimiento
        Vector3 movimiento = new Vector3(movimientoX, 0, movimientoZ);

        // Mover el objeto
        transform.Translate(movimiento * velocidad * Time.deltaTime);
    }
}
