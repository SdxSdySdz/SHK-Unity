﻿using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour
{
    public float spEed;
    public bool timer;
    public float time;

    private void Update(){
        if (timer)
        {
            time -= Time.deltaTime;
            if(time < 0)
   {
                timer = false;
                spEed /= 2;
            }
        }

        GameObject[] result = GameObject.FindGameObjectsWithTag("Enemy");

        if(result.Length == 0)
        {
            GameController.controller.End();
            enabled = false;
        }

        if (Input.GetKey(KeyCode.W))
            transform.Translate(0, spEed * Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(0, -spEed * Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.A))
            transform.Translate(-spEed * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(spEed * Time.deltaTime, 0, 0);
    }

    public void SendMessage(GameObject b)
    {
        if(b.name == "enemy")
        {
            Destroy(b);
        }
        if(b.name == "speed")
        {
            spEed *= 2;
            timer = true;
            time = 2;
        }
    }
}
