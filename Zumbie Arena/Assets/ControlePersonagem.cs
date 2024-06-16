using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePersonagem : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    [SerializeField] float runningSpeed = 10.0f; // Velocidade ao correr
    private Animator heroi;

    void Start()
    {
        heroi = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float currentSpeed = speed;

        // Verifica se LeftShift está sendo pressionado
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = runningSpeed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * currentSpeed);
            heroi.SetBool("Correndo", true);
            heroi.SetBool("Parado", false);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * currentSpeed);
            heroi.SetBool("Correndo", true);
            heroi.SetBool("Parado", false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1, 0);
            heroi.SetBool("Correndo", true);
            heroi.SetBool("Parado", false);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1, 0);
            heroi.SetBool("Correndo", true);
            heroi.SetBool("Parado", false);
        }
        else
        {
            heroi.SetBool("Correndo", false);
            heroi.SetBool("Parado", true);
        }
    }
}
