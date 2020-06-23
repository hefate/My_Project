using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SPF_A : MonoBehaviour
{
	public Transform firePos;

	/// <summary>
	/// 沙发UI选项
	/// </summary>
	public GameObject UI_Sofa;
	/// <summary>
	/// 沙发选项A的物体
	/// </summary>
	public GameObject ArticlesSofa_A;
	/// <summary>
	/// 沙发选项B的物体
	/// </summary>
	public GameObject ArticlesSofa_B;
	/// <summary>
	/// 沙发选项C的物体
	/// </summary>
	public GameObject ArticlesSofa_C;
	/// <summary>
	/// 沙发选项D的物体
	/// </summary>
	public GameObject ArticlesSofa_D;



	/// <summary>
	/// 地毯UI选项
	/// </summary>
	public GameObject UI_Carpet;
	/// <summary>
	/// 地毯选项A的物体
	/// </summary>
	public GameObject ArticlesCarpet_A;
	/// <summary>
	/// 地毯选项B的物体
	/// </summary>
	public GameObject ArticlesCarpet_B;
	/// <summary>
	/// 地毯选项C的物体
	/// </summary>
	public GameObject ArticlesCarpet_C;
	/// <summary>
	/// 地毯选项D的物体
	/// </summary>
	public GameObject ArticlesCarpet_D;

	/// <summary>
	/// 茶几UI选项
	/// </summary>
	public GameObject UI_TeaTable;
	/// <summary>
	/// 茶几选项A的物体
	/// </summary>
	public GameObject ArticlesTeaTable_A;
	/// <summary>
	/// 茶几选项B的物体
	/// </summary>
	public GameObject ArticlesTeaTable_B;
	/// <summary>
	/// 茶几选项C的物体
	/// </summary>
	public GameObject ArticlesTeaTable_C;
	/// <summary>
	/// 茶几选项D的物体
	/// </summary>
	public GameObject ArticlesTeaTable_D;

	/// <summary>
	/// 电视柜UI选项
	/// </summary>
	public GameObject UI_TVCabinet;
	/// <summary>
	/// 电视柜选项A的物体
	/// </summary>
	public GameObject ArticlesTVCabinet_A;
	/// <summary>
	/// 电视柜选项B的物体
	/// </summary>
	public GameObject ArticlesTVCabinet_B;
	/// <summary>
	/// 电视柜选项C的物体
	/// </summary>
	public GameObject ArticlesTVCabinet_C;
	/// <summary>
	/// 电视柜选项D的物体
	/// </summary>
	public GameObject ArticlesTVCabinet_D;


	//手柄      
	SteamVR_TrackedObject trackdeObjec;
	void Awake()
	{
		//获取手柄上的这个组件      
		trackdeObjec = GetComponent<SteamVR_TrackedObject>();
	}

	// Use this for initialization
	void Start()
	{

	}

	void FixedUpdate()
	{   //获取手柄输入      
		var device = SteamVR_Controller.Input((int)trackdeObjec.index);

		Debug.DrawRay(firePos.position, firePos.forward * 100.0f, Color.green);
		// Update is called once per frame
		if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger))
		{

			//Debug.Log("轻按了扳机键");
			var deviceIndex2 = SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Rightmost);
			device.TriggerHapticPulse(1200);

			RaycastHit hit;
			if (Physics.Raycast(firePos.position, firePos.forward, out hit, 100.0f))
			{

				//沙发
				if (hit.collider.tag == "UI_Sofa")
				{
					UI_Sofa.SetActive(true);
				}
				if (UI_Sofa == true)
				{
					if (hit.collider.tag == "Sofa_A")
					{
						ArticlesSofa_A.SetActive(true);
						ArticlesSofa_B.SetActive(false);
						ArticlesSofa_C.SetActive(false);
						//ArticlesSofa_D.SetActive(false);
						UI_Sofa.SetActive(false);

					}
					else if (hit.collider.tag == "Sofa_B")
					{
						ArticlesSofa_A.SetActive(false);
						ArticlesSofa_B.SetActive(true);
						ArticlesSofa_C.SetActive(false);
						//ArticlesSofa_D.SetActive(false);
						UI_Sofa.SetActive(false);

					}
					else if (hit.collider.tag == "Sofa_C")
					{
						ArticlesSofa_A.SetActive(false);
						ArticlesSofa_B.SetActive(false);
						ArticlesSofa_C.SetActive(true);
						//ArticlesSofa_D.SetActive(false);
						UI_Sofa.SetActive(false);

					}
					else if (hit.collider.tag == "Sofa_D")
					{
						ArticlesSofa_A.SetActive(false);
						ArticlesSofa_B.SetActive(false);
						ArticlesSofa_C.SetActive(false);
						//ArticlesSofa_D.SetActive(true);
						UI_Sofa.SetActive(false);

					}

				}

				//地毯
				if (hit.collider.tag == "UI_Carpet")
				{
					UI_Carpet.SetActive(true);
				}
				if (UI_Carpet == true)
				{
					if (hit.collider.tag == "Carpet_A")
					{
						ArticlesCarpet_A.SetActive(true);
						ArticlesCarpet_B.SetActive(false);
						ArticlesCarpet_C.SetActive(false);
						//ArticlesCarpet_D.SetActive(false);
						UI_Carpet.SetActive(false);

					}
					else if (hit.collider.tag == "Carpet_B")
					{
						ArticlesCarpet_A.SetActive(false);
						ArticlesCarpet_B.SetActive(true);
						ArticlesCarpet_C.SetActive(false);
						//ArticlesCarpet_D.SetActive(false);
						UI_Carpet.SetActive(false);

					}
					else if (hit.collider.tag == "Carpet_C")
					{
						ArticlesCarpet_A.SetActive(false);
						ArticlesCarpet_B.SetActive(false);
						ArticlesCarpet_C.SetActive(true);
						//ArticlesCarpet_D.SetActive(false);
						UI_Carpet.SetActive(false);

					}
					else if (hit.collider.tag == "Carpet_D")
					{
						ArticlesCarpet_A.SetActive(false);
						ArticlesCarpet_B.SetActive(false);
						ArticlesCarpet_C.SetActive(false);
						//ArticlesCarpet_D.SetActive(true);
						UI_Carpet.SetActive(false);

					}

				}

				//茶几
				if (hit.collider.tag == "UI_TeaTable")
				{
					UI_TeaTable.SetActive(true);
					
				}
				if (UI_TeaTable == true)
				{
					if (hit.collider.tag == "TeaTable_A")
					{
						ArticlesTeaTable_A.SetActive(true);
						ArticlesTeaTable_B.SetActive(false);
						ArticlesTeaTable_C.SetActive(false);
						//ArticlesTeaTable_D.SetActive(false);
						UI_TeaTable.SetActive(false);

					}
					else if (hit.collider.tag == "TeaTable_B")
					{
						ArticlesTeaTable_A.SetActive(false);
						ArticlesTeaTable_B.SetActive(true);
						ArticlesTeaTable_C.SetActive(false);
						//ArticlesTeaTable_D.SetActive(false);
						UI_TeaTable.SetActive(false);

					}
					else if (hit.collider.tag == "TeaTable_C")
					{
						ArticlesTeaTable_A.SetActive(false);
						ArticlesTeaTable_B.SetActive(false);
						ArticlesTeaTable_C.SetActive(true);
						//ArticlesTeaTable_D.SetActive(false);
						UI_TeaTable.SetActive(false);

					}
					else if (hit.collider.tag == "TeaTable_D")
					{
						ArticlesTeaTable_A.SetActive(false);
						ArticlesTeaTable_B.SetActive(false);
						ArticlesTeaTable_C.SetActive(false);
						//ArticlesTeaTable_D.SetActive(true);
						UI_TeaTable.SetActive(false);

					}

				}




				//电视柜
				if (hit.collider.tag == "UI_TVCabinet")
				{
					UI_TVCabinet.SetActive(true);

				}
				if (UI_TVCabinet == true)
				{
					if (hit.collider.tag == "TVCabinet_A")
					{
						Debug.Log("选择了 TVCabinet_A");
						ArticlesTVCabinet_A.SetActive(true);
						ArticlesTVCabinet_B.SetActive(false);
						ArticlesTVCabinet_C.SetActive(false);
						//ArticlesTVCabinet_D.SetActive(false);
						UI_TVCabinet.SetActive(false);

					}
					else if (hit.collider.tag == "TVCabinet_B")
					{
						Debug.Log("选择了 TVCabinet_B");
						ArticlesTVCabinet_A.SetActive(false);
						ArticlesTVCabinet_B.SetActive(true);
						ArticlesTVCabinet_C.SetActive(false);
						//ArticlesTVCabinet_D.SetActive(false);
						UI_TVCabinet.SetActive(false);

					}
					else if (hit.collider.tag == "TVCabinet_C")
					{
						ArticlesTVCabinet_A.SetActive(false);
						ArticlesTVCabinet_B.SetActive(false);
						ArticlesTVCabinet_C.SetActive(true);
						//ArticlesTVCabinet_D.SetActive(false);
						UI_TVCabinet.SetActive(false);

					}
					else if (hit.collider.tag == "TVCabinet_D")
					{
						ArticlesTVCabinet_A.SetActive(false);
						ArticlesTVCabinet_B.SetActive(false);
						ArticlesTVCabinet_C.SetActive(false);
						//ArticlesTVCabinet_D.SetActive(true);
						UI_TVCabinet.SetActive(false);

					}
				}
				
			}

		}
	}

}