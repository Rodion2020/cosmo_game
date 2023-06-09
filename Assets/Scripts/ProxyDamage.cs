using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProxyDamage : MonoBehaviour
{
    // Start is called before the first frame update
    //Damage per seond
    public float DamageRate = 10f;

    void OnTriggerStay(Collider Col)
    {
        Health H = Col.gameObject.GetComponent<Health>();
        if (H == null)
        {
            return;
        }
        H.HealthPoints -= DamageRate * Time.deltaTime;
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
