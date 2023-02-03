using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Unit_Spawn_Button : MonoBehaviour
{
	public GameObject SpawnUnit;
	public GameObject Wid;
	public Sprite img;


	public void ClickEvent() //Ŭ���� ���� ����
	{
		if (GameManager.instance.BlueCost >= SpawnUnit.GetComponent<Unit>().needCost) //�ڽ�Ʈ �Ҹ� ���� �߰�
		{
			GameManager.instance.BlueCost -= SpawnUnit.GetComponent<Unit>().needCost;
			Instantiate(SpawnUnit, SpawnUnit.transform.position, Quaternion.identity);
		}
	}

	public void ClickWidEvent() //������ Ȱ��ȭ
	{
		if (GameManager.instance.BlueCost >= Wid.GetComponent<Unit>().needCost)
		{
			GameManager.instance.BlueCost -= Wid.GetComponent<Unit>().needCost;
			transform.GetChild(0).GetComponent<Image>().sprite = img; //������ ���� �̹��� �߰�
			Wid.SetActive(true);
			Destroy(transform.GetChild(1).gameObject);
			Destroy(this); // �������� ��� �ѹ� ��ȯ�ϸ� ��� ������ �Ǽ� ��ũ��Ʈ�� ��Ȱ��ȭ ���ش�.
		}
	}
}
