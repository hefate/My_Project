using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Lokme : MonoBehaviour {
	public GameObject Robot;
	public GameObject Main;
	public bool LookAt_IO = true;
    
   // public List<GameObject> _List_Object = new List<GameObject>();


    void Start()
	{
		StartCoroutine(DTRDIDRU());
	}

	IEnumerator DTRDIDRU()
	{
		while (LookAt_IO)
		{
			Transform Temp = Main.transform;
			Temp.position = new Vector3(Temp.position.x, Robot.transform.position.y, Temp.position.z);
			Robot.transform.LookAt(Temp);
			yield return new WaitForFixedUpdate();
		}
	}
    //public GameObject _Object_Find(string _Name)
    //{
    //    //GameObject _Temp = null;
    //    foreach (var v in _List_Object)
    //    {
    //        //Debug.Log(v.name + "   " + _Name);
    //        try
    //        {
    //            StartCoroutine(DTRDIDRU());
    //            //if (v.name == _Name)
    //            //{
    //            //    return v;
    //            //}
    //        }
    //        catch { }
    //    }
    //    Debug.Log("Not Found");
    //    return null;
    //}

}
