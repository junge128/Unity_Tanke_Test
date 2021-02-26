using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour {

    public GameObject shellExplosionPrefab;
    public AudioClip audioo;
	void Start () 
    {

	}

	void Update () {
		
	}
    public void OnTriggerEnter(Collider collider)
    {
        AudioSource.PlayClipAtPoint(audioo, transform.position);
        GameObject.Instantiate(shellExplosionPrefab,transform.position,transform.rotation);
        GameObject.Destroy(this.gameObject);
        if (collider.tag == "Tank")
            collider.SendMessage("TakeDamage");

    }
}
  