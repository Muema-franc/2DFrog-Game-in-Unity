using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour

{
    GameObject frog;
    // Start is called before the first frame update
    void Start()
    {
        frog =  GameObject.Find("frog");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScaleDown()
    {
    	frog.gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.0f);
    }
}
