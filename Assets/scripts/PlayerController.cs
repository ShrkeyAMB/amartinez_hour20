using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameControl control;
    private Animation anim;
    public float strafeSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") + Time.deltaTime * strafeSpeed;
        transform.Translate(xMove, 0f, 0f);
        if (transform.position.x > 3)
        {
            transform.Translate(3f, 0, 0);
        }else if (transform.position.x < -3)
        {
            transform.Translate(-3f, 0, 0);
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PowerUp(clone)")
        {
            control.PowerUpCollected();
        }else if(other.gameObject.name == "obstacle(clone)") { control.SlowWorldDown(); }
        Destroy(other.gameObject);
    }


}
