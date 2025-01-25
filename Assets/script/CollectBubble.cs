using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    [SerializeField] AudioSource coinFX;

    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        this.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        coinFX.Play();
        //Destroy(this.gameObject);
    }

}
