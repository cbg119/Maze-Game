using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider colliderComponent) {
        if (colliderComponent.gameObject.name == "Player") {
            SceneManager.LoadSceneAsync("Winning Screen");
            Debug.Log("Player touched winning block");

        }
    }
}
