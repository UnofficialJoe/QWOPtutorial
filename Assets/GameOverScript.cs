using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public bool dead = false;
    public GameObject text;



    // Update is called once per frame
    void Update()
    {
        if (dead)
        {
            text.gameObject.SetActive(true);
        }

        if(Input.GetKey(KeyCode.Space) && dead)
        {
            dead = false;
            text.gameObject.SetActive(false);

            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 9)
        {
            dead = true;
        }
    }
}
