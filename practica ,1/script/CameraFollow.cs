using UnityEngine;
using UnityEngine.Jobs;
/// <summary>
/// Controla el seguimiento de la cámara a la bola.
/// </summary>
public class CameraFollow : MonoBehaviour
{
    // TODO: Referencia al objetivo (bola)

    public Transform objetivo;

    // TODO: Offset o separación entre la cámara y el objetivo
    //transform position   x  y  z
    public Vector3 offset = new Vector3(0f, 3f, -6f);

    // TODO: Variable para activar o desactivar el seguimiento

    private bool seguir = false;
    void LateUpdate()
    {
        // PISTA: Solo seguir si está activado y el objetivo está correctamente referenciado
        if (seguir && objetivo != null)
        {
            // PISTA: Posicionar cámara con offset
            transform.position = objetivo.position + offset;
            transform.LookAt(objetivo);
        }
    }
    // PISTA: Método para iniciar seguimiento
    public void IniciarSeguimiento(Transform nuevoObjetivo)
    {
        // seguir = true;
        objetivo = nuevoObjetivo;
        seguir = true;
    }
    // PISTA: Método para detener seguimiento
    public void DetenerSeguimiento()
    {
        // seguir = false;
        seguir = false;
    }
    // Método alternativo para llamar al controlador de la bola
    public void SeguirBola (Transform bola)
    {
        IniciarSeguimiento(bola);
    }
}