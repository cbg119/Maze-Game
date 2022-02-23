using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1;
    private float translationFWD;
    private float translationSIDE;

    void Start()
    {
        
    }

    void Update()
    {
        translationFWD = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        translationSIDE = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(translationSIDE, 0, translationFWD);
    }
}
