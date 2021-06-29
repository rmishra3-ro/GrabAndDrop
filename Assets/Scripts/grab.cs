using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grab : MonoBehaviour
{
    public GameObject grabObj;
    
    public GameObject tempParent;
    public Transform guide;
    // Start is called before the first frame update
    void Start()
    {
        // grabObj.GetComponent<Rigidbody>().useGravity = true;

    }

    // Update is called once per frame
    void Update()
    {
    
    }
    // void OnMouseDown(){
    //     grabObj.GetComponent<Rigidbody>().useGravity = false;
    //     grabObj.GetComponent<Rigidbody>().isKinematic = true;
    //     grabObj.transform.position = guide.transform.position;
    //     grabObj.transform.rotation = guide.transform.rotation;
    //     grabObj.transform.parent = tempParent.transform;

    // }
    // private void OnMouseUp(){
    //     grabObj.GetComponent<Rigidbody>().useGravity = true;
    //     grabObj.GetComponent<Rigidbody>().isKinematic = false;
    //     grabObj.transform.parent = null;
    //     grabObj.transform.position = guide.transform.position;
    // }


}
