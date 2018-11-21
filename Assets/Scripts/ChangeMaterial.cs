using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour {

    SkinnedMeshRenderer myRend;
    public Material awake;
    public Material asleep;
    public Material neutral;
	// Use this for initialization
	void Start () {
        myRend = gameObject.GetComponent<SkinnedMeshRenderer>();
        Debug.Log("Name: " + myRend.materials[1].name);
    }
	
	public void ChangeAwake()
    {
        Material[] materials = myRend.materials;
        materials[1] = awake;
        myRend.materials = materials;

    }
    public void ChangeAsleep()
    {
        Material[] materials = myRend.materials;
        materials[1] = asleep;
        myRend.materials = materials;
    }
    public void ChangeNeutral()
    {
        Material[] materials = myRend.materials;
        materials[1] = neutral;
        myRend.materials = materials;
    }

   
}
