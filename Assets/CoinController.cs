using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;

    // Use this for initialization
    void Start()
    {
        //��]���J�n����p�x��ݒ�
        this.transform.Rotate(0, Random.Range(0, 360), 0);

        //Unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        //��]
        this.transform.Rotate(0, 3, 0);

        if (this.transform.position.z < this.unitychan.transform.position.z - 10)
        {
            Destroy(this.gameObject);
        }
    }
}
