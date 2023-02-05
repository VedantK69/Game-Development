using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{

    [SerializeField] GameObject _weaponParent;
    [SerializeField] GameObject _weapon;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("2"))
        {
            
            _weapon.SetActive(false);
        }
        else if (Input.GetKeyDown("3"))
        {
            _weapon.SetActive(true);

           
        }
        
    }

}
