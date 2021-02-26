using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tankhealth : MonoBehaviour {

    public int hp = 100;
    public GameObject tankExplosion;
    public AudioClip tankexplosionAudio;
    public Slider hpslider;
    private int hpTotal;

	void Start () 
    {
        hpTotal = hp;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void TakeDamage() 
    {
        if (hp <= 0) 
        return;
        hp -= Random.Range(10, 20);
        hpslider.value = (float)hp / hpTotal;
        if(hp<=0)
        {
            AudioSource.PlayClipAtPoint(tankexplosionAudio, transform.position);
            GameObject.Instantiate(tankExplosion, transform.position + Vector3.up, transform.rotation);
            GameObject.Destroy(this.gameObject);
        }
    }
}
