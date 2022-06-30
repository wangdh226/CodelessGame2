using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSpaceCollider : MonoBehaviour
{
    public GameObject parent;
    public GameObject player;

    public Canvas play;
    public Canvas win;

    // Start is called before the first frame update
    void Start()
    {
        win.enabled = false;
    }

    // Update is called once per frame
    void Update() { }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided at end");
        (parent.GetComponent("Rigidbody") as Rigidbody).isKinematic = true;
        (parent.GetComponent("ConstantForce") as ConstantForce).enabled = false;
        (player.GetComponent("Rigidbody") as Rigidbody).isKinematic = true;

        play.enabled = false;
        win.enabled = true;
    }
}
