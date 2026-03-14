using System;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.VFX;
using Witch.UI;
using Witch.UI.Window;

// Token: 0x020000E7 RID: 231
public class AnimationManager
{
	// Token: 0x060007E1 RID: 2017 RVA: 0x0003EEFC File Offset: 0x0003D0FC
	public void AnimationPlay(GameObject obj)
	{
		obj.transform.SetAsLastSibling();
		this.Tailing(obj.transform);
	}

	// Token: 0x060007E2 RID: 2018 RVA: 0x0003EF18 File Offset: 0x0003D118
	public void Tailing(Transform obj)
	{
		bool flag = UIManager.Instance.GetUI<TopBarUI>("TopBarUI") != null;
		Vector3 target;
		if (flag)
		{
			target = UIManager.Instance.GetUI<TopBarUI>("TopBarUI").transform.Find("Content/Buttons/CardBack").position;
		}
		else
		{
			target = Singleton<TempDataManager>.Instance.UIWorldPosMap["Backpack"];
		}
		Vector3 direction = target - obj.position;
		float angle = Mathf.Atan2(direction.y, direction.x) * 57.29578f;
		obj.DORotateQuaternion(Quaternion.Euler(new Vector3(0f, 0f, angle)), 0.1f);
		obj.transform.DOScale(Vector3.zero, 0.1f);
		GameObject targetObj = UIManager.Instance.GetUI<TopBarUI>("TopBarUI").transform.Find("Content/Buttons/CardBack").gameObject;
		GameObject trail = UnityEngine.Object.Instantiate(ResourceLoader.Load("UI/Trail"), obj.parent) as GameObject;
		Transform vfx = trail.transform.Find("geometryBursts");
		foreach (object obj2 in vfx.transform)
		{
			Transform child = (Transform)obj2;
			VisualEffect subVfx = child.GetComponent<VisualEffect>();
			subVfx.SetInt("count", 0);
		}
		obj.DOMove(target, 1f, false).OnStart(delegate
		{
			foreach (object obj3 in vfx.transform)
			{
				Transform child2 = (Transform)obj3;
				VisualEffect subVfx2 = child2.GetComponent<VisualEffect>();
				subVfx2.SetInt("count", 1);
			}
		}).OnUpdate(delegate
		{
			Vector3 pos = PositionUtility.CameraSpaceToZeroPlane(obj.GetComponent<RectTransform>(), null);
			foreach (object obj3 in vfx.transform)
			{
				Transform child2 = (Transform)obj3;
				VisualEffect subVfx2 = child2.GetComponent<VisualEffect>();
				subVfx2.SetVector3("startPos", pos);
				subVfx2.SetFloat("direction", obj.rotation.eulerAngles.z * 0.017453292f);
			}
		}).OnComplete(delegate
		{
			foreach (object obj3 in vfx.transform)
			{
				Transform child2 = (Transform)obj3;
				VisualEffect subVfx2 = child2.GetComponent<VisualEffect>();
				subVfx2.SetInt("count", 0);
			}
			UnityEngine.Object.Destroy(trail, 5f);
			UnityEngine.Object.Destroy(obj.gameObject);
		}).OnKill(delegate
		{
			foreach (object obj3 in vfx.transform)
			{
				Transform child2 = (Transform)obj3;
				VisualEffect subVfx2 = child2.GetComponent<VisualEffect>();
				subVfx2.SetInt("count", 0);
			}
			UnityEngine.Object.Destroy(trail, 5f);
			bool flag2 = obj != null;
			if (flag2)
			{
				UnityEngine.Object.Destroy(obj.gameObject);
			}
		}).SetDelay(0.1f);
	}

	// Token: 0x04000B58 RID: 2904
	public static AnimationManager Instance = new AnimationManager();
}
