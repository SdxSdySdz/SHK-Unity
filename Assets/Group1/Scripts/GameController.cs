using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController controller;

    public GameObject go;
    public GameObject a;
    public GameObject[] B;

    private void Start()
    {
        controller = this;
    }

    private void Update(){
        foreach (var b in B)
        {
            if (b == null)
                continue;

                if (Vector3.Distance(a.gameObject.GetComponent<Transform>().position, b.gameObject.gameObject.transform.position) < 0.2f)
                {
                    a.SendMessage("SendMEssage", b);
                }

        }
    }
    
    public void End()
    {
        go.SetActive(true);
    }
}
