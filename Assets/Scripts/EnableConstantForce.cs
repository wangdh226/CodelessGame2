using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableConstantForce : MonoBehaviour
{
    public GameObject parent;
    public UnityEngine.UI.Button buttonCCW;
    public UnityEngine.UI.Button buttonCW;
    public UnityEngine.UI.Button buttonFreeze;

    // Start is called before the first frame update
    void Start()
    {
        buttonFreeze.onClick.AddListener(delegate { SwitchButtonHandler(0); });
        buttonCW.onClick.AddListener(delegate { SwitchButtonHandler(1); });
        buttonCCW.onClick.AddListener(delegate { SwitchButtonHandler(2); });
    }

    // Update is called once per frame
    void Update(){}

    void SwitchButtonHandler(int index)
    {
        switch (index)
        {
            case 0:
                (parent.GetComponent("Rigidbody") as Rigidbody).isKinematic = true;
                (parent.GetComponent("ConstantForce") as ConstantForce).enabled = false;
                Debug.Log("freeze");
                break;
            case 1:
                (parent.GetComponent("Rigidbody") as Rigidbody).isKinematic = false;
                (parent.GetComponent("ConstantForce") as ConstantForce).enabled = true;
                (parent.GetComponent("ConstantForce") as ConstantForce).relativeTorque = new Vector3(0.0f, 0.0f, 1.0f);
                Debug.Log("CW");
                break;
            case 2:
                (parent.GetComponent("Rigidbody") as Rigidbody).isKinematic = false;
                (parent.GetComponent("ConstantForce") as ConstantForce).enabled = true;
                (parent.GetComponent("ConstantForce") as ConstantForce).relativeTorque = new Vector3(0.0f, 0.0f, -1.0f);
                Debug.Log("CCW");
                break;
        }
    }

}
