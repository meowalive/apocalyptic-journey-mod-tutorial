using System;
using UnityEditor;
using UnityEngine;

// Token: 0x02000027 RID: 39
[CustomEditor(typeof(DOTweenCurvedTracker))]
public class DOTweenCurvedTrackerEditor : Editor
{
	// Token: 0x060000F7 RID: 247 RVA: 0x00008B8C File Offset: 0x00006D8C
	public override void OnInspectorGUI()
	{
		base.DrawDefaultInspector();
		DOTweenCurvedTracker tracker = (DOTweenCurvedTracker)base.target;
		GUILayout.Space(10f);
		this.showPerformanceSettings = EditorGUILayout.Foldout(this.showPerformanceSettings, "性能优化设置");
		bool flag = this.showPerformanceSettings;
		if (flag)
		{
			EditorGUILayout.HelpBox("• PathResolution: 路径点数量，影响路径平滑度和性能\n• CircleSegments: 预览圆圈分段数，影响Gizmos绘制性能\n• 编辑器更新频率已限制为10FPS以提升性能", 1);
		}
		GUILayout.Space(5f);
		GUILayout.Label("预览控制", EditorStyles.boldLabel, Array.Empty<GUILayoutOption>());
		bool isPlaying = Application.isPlaying;
		if (isPlaying)
		{
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			bool flag2 = GUILayout.Button("重新开始运动", Array.Empty<GUILayoutOption>());
			if (flag2)
			{
				tracker.RestartMovement();
			}
			bool flag3 = GUILayout.Button("停止运动", Array.Empty<GUILayoutOption>());
			if (flag3)
			{
				tracker.StopMovement();
			}
			GUILayout.EndHorizontal();
		}
		else
		{
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			bool flag4 = GUILayout.Button("开始预览动画", Array.Empty<GUILayoutOption>());
			if (flag4)
			{
				tracker.StartPreviewAnimation();
			}
			bool flag5 = GUILayout.Button("停止并复位", Array.Empty<GUILayoutOption>());
			if (flag5)
			{
				tracker.ResetToOriginalPosition();
			}
			GUILayout.EndHorizontal();
			GUILayout.Space(5f);
			bool flag6 = GUILayout.Button("强制刷新路径", Array.Empty<GUILayoutOption>());
			if (flag6)
			{
				tracker.ForceUpdatePath();
				SceneView.RepaintAll();
			}
			GUILayout.Space(5f);
			EditorGUILayout.HelpBox("编辑器模式下路径会实时更新预览。运行时路径在开始执行后不会改变。", 1);
		}
		bool flag7 = !Application.isPlaying;
		if (flag7)
		{
			EditorGUILayout.HelpBox("运行时路径在Start()时确定，执行过程中不会改变，确保性能和稳定性。", 0);
		}
	}

	// Token: 0x04000093 RID: 147
	private bool showPerformanceSettings = false;
}
