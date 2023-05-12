using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public float startSpeed = -0.4f;
    public float timeExtension = 1.5f;
    public Ground ground;
    private float timeRemaining = 20;
    private float totalTimeElapsed = 0;
    private bool isOver = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isOver) { return; }
        totalTimeElapsed += Time.deltaTime;
        timeRemaining -=Time.deltaTime;
        if(timeRemaining <= 0) {
            isOver = true;
        }

    }
    public void SlowWorldDown()
    {
        CancelInvoke("speedWorldUp");
        ground.SlowDown();
        Invoke("SpeedWorldUp", 1);
        Time.timeScale = 0.5f;
    }
    public void speedWorldUp()
    {
        Time.timeScale = 1f;
        ground.SpeedUp();
    }
    public void PowerUpCollected()
    {
        timeRemaining += timeExtension;
    }
    private void OnGUI()
    {
        if (isOver)
        {
            Rect boxRect = new Rect(Screen.width / 2 - 50, Screen.height - 100, 100, 50);
            
            GUI.Box(boxRect, "Time Remaining");

            Rect Labelrect = new Rect(Screen.width / 2 - 10, Screen.height - 80, 20, 40);
            GUI.Label(Labelrect, ((int)timeRemaining).ToString());
        }else
        {
            Rect boxRect = new Rect(Screen.width / 2 - 60, Screen.height / 2 - 100, 120, 50);
            GUI.Box(boxRect, "Game Over");
            Rect labelRect = new Rect(Screen.width / 2 - 55, Screen.height / 2 - 80, 90, 40);
            GUI.Label(labelRect, "Total time: " + (int)totalTimeElapsed);
            Time.timeScale = 0;
        }
    }
}
