using UnityEngine;

/// <summary>
/// Detecta si el pino ha sido derribado.
/// </summary>
public class Pin : MonoBehaviour
{
    // Umbral de inclinación para considerar el pino como caído
    [SerializeField] private float umbralCaida = 5f;

    /// <summary>
    /// Determina si el pino está caído basándose en su inclinación respecto al eje vertical.
    /// </summary>
    public bool EstaCaido()
    {
        // Calcular ángulo entre la orientación del pino y el eje vertical
        float angulo = Vector3.Angle(transform.up, Vector3.up);

        // Retornar true si el ángulo supera el umbral de caída
        return angulo > umbralCaida;
    }
}