using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;

    // Start is called before the first frame update
    void Start()
    {
        //Unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < this.unitychan.transform.position.z - 10)
        {
            Destroy(this.gameObject);
        }
    }
}
