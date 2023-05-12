using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private GameControl control;

    // Start is called before the first frame update
    void Start()
    {
        control = GameObject.FindObjectOfType<GameControl>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, control.startSpeed);
    }
}
