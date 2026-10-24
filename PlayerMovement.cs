using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // flechas izquierda/derecha
        float y = Input.GetAxis("Vertical");   // flechas arriba/abajo
        transform.Translate(new Vector3(x, y, 0) * velocidad * Time.deltaTime);
    }
}