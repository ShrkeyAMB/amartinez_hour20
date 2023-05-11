using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float speed = .5f;
    private Renderer groundRenderer;
    // Start is called before the first frame update
    void Start()
    {
        groundRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Time.time + speed % 1; //the %1 keeps the offset between 0 and 1
        groundRenderer.material.mainTextureOffset = new Vector2(0, -offset);
    }
    public void SlowDown()
    {
        speed = speed / 2;
    }
    public void SpeedUp()
    {
        speed = speed * 2;
    }
}
