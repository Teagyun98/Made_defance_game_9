using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;
	public GameObject Camera;
	public string mod;
	public GameObject ArrowBlue;
	public GameObject ArrowRed;
	public ParticleSystem MasicBlue;
	public ParticleSystem MasicRed;
	public GameObject UpgradeBW;
	public GameObject UpgradeBS;
	public GameObject UpgradeBA;
	public GameObject UpgradeBG;


	private int MaxCost = 10;
	public int BlueCost=0;
	public int RedCost=0;

	bool AbleGetCost = true;

	private void Awake()
	{
		instance = this;
	}

	private void Update()
	{
		if(AbleGetCost)
			StartCoroutine(GetCost());
		CheckUpgrade();
	}

	IEnumerator GetCost() // 2초에 1씩 cost회복
	{
		AbleGetCost = false;
		if (MaxCost > BlueCost)
			BlueCost++;
		if (MaxCost > RedCost)
			RedCost++;
		yield return new WaitForSeconds(2f);
		AbleGetCost = true;
	}

	void CheckUpgrade() //코스트가 10이 아니면 엑티브를 false로 설정
	{
		if (BlueCost == 10)
		{
			if (UpgradeBS != null)
				UpgradeBS.SetActive(true);
			if (UpgradeBA != null)
				UpgradeBA.SetActive(true);
			if (UpgradeBW != null)
				UpgradeBW.SetActive(true);
			if (UpgradeBG != null)
				UpgradeBG.SetActive(true);
		}
		if (BlueCost != 10)
		{
			if (UpgradeBS != null)
				UpgradeBS.SetActive(false);
			if (UpgradeBA != null)
				UpgradeBA.SetActive(false);
			if (UpgradeBW != null)
				UpgradeBW.SetActive(false);
			if (UpgradeBG != null)
				UpgradeBG.SetActive(false);
		}
	}
}
