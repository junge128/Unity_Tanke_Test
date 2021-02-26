using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour {
    public GameObject shellPrefab;  //子弹
    private Transform firePosition;  //位置
    public KeyCode fireKey = KeyCode.Space; //按键
    public float shellSpeed = 10;
    public AudioClip shootAudio;
	void Start () 
    {
        firePosition = transform.Find("FirePosition");  //找到位置
	}
	void Update () {
        if (Input.GetKeyDown(fireKey))
        {
            AudioSource.PlayClipAtPoint(shootAudio, transform.position);
            GameObject go = GameObject.Instantiate(shellPrefab, firePosition.position, firePosition.rotation); //子弹实例化
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellSpeed;
        }
	}
}
