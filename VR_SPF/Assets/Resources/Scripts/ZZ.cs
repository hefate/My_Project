using UnityEngine;
using System.Collections;

public class ZZ : MonoBehaviour
{


	public float Speed = 5f;
	public GameObject XZ_Sofa_A;
	public GameObject XZ_Sofa_B;
	public GameObject XZ_Sofa_C;

	public GameObject XZ_TeaTable_A;
	public GameObject XZ_TeaTable_B;
	public GameObject XZ_TeaTable_C;

	public GameObject XZ_TVCabinet_A;
	public GameObject XZ_TVCabinet_B;
	public GameObject XZ_TVCabinet_C; 
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		XZ_Sofa_A.transform.Rotate(Vector3.down * Speed, Space.Self);
		XZ_Sofa_B.transform.Rotate(Vector3.down * Speed, Space.Self);
		XZ_Sofa_C.transform.Rotate(Vector3.down * Speed, Space.Self);

		XZ_TeaTable_A.transform.Rotate(Vector3.forward * Speed, Space.Self);
		XZ_TeaTable_B.transform.Rotate(Vector3.forward * Speed, Space.Self);
		XZ_TeaTable_C.transform.Rotate(Vector3.forward * Speed, Space.Self);

		XZ_TVCabinet_A.transform.Rotate(Vector3.forward * Speed, Space.Self);
		XZ_TVCabinet_B.transform.Rotate(Vector3.forward * Speed, Space.Self);
		XZ_TVCabinet_C.transform.Rotate(Vector3.forward * Speed, Space.Self);


	}
}

