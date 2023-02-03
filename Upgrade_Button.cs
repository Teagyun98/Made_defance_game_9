using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;// image class를 사용하기 위해서 추가
using UnityEngine;

public class Upgrade_Button : MonoBehaviour
{
    public GameObject UpgradeUnit;
    public GameObject Button;
    public GameObject  UpgradeWid;
    public GameObject Wid;
    public Sprite img;

    public void ClickEvent()
	{
            GameManager.instance.BlueCost -= 10;
            Button.transform.GetChild(0).GetComponent<Image>().sprite = img; //업그레이드된 이미지로 변환
            Button.GetComponent<Unit_Spawn_Button>().SpawnUnit = UpgradeUnit; // 클릭시 아래 버튼의 스폰 오브젝트를 바꿔준다.
            Destroy(gameObject);
	}

    public void UpWid()
	{
        if (Wid.active)
        {
            Button.transform.GetChild(0).GetComponent<Image>().sprite = img;
            GameManager.instance.BlueCost -= 10;
            Wid.SetActive(false); //  기존 마법사를 끄고 업글 마법사를 활성화
            UpgradeWid.SetActive(true);
            Destroy(gameObject);
        }
    }
}
