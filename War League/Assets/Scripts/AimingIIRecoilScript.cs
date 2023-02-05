using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingIIRecoilScript : MonoBehaviour
{
    public GameObject Gun;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Gun.GetComponent<Animator>().Play("Aim");
        }

        if (Input.GetMouseButtonUp(1))
        {
            Gun.GetComponent<Animator>().Play("New State");
        }

        if (Input.GetMouseButton(0))
        {
            StartCoroutine(StartRecoil());
        }

        IEnumerator StartRecoil()
        {
            Gun.GetComponent<Animator>().Play("Recoil");
            yield return new WaitForSeconds(0.20f);
            Gun.GetComponent<Animator>().Play("New State");
        }

    }
}
