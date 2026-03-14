using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Mirror;
using UnityEngine;

/// <summary>
/// 非主机时每秒统计 RTT 延迟，断开后输出平均/最高/最低延迟。
/// </summary>
// Token: 0x020000D4 RID: 212
public class LatencyRecorder : MonoBehaviour
{
	// Token: 0x170000CE RID: 206
	// (get) Token: 0x06000716 RID: 1814 RVA: 0x0003AFF0 File Offset: 0x000391F0
	// (set) Token: 0x06000717 RID: 1815 RVA: 0x0003AFF7 File Offset: 0x000391F7
	public static LatencyRecorder Instance { get; private set; }

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x06000718 RID: 1816 RVA: 0x0003AFFF File Offset: 0x000391FF
	// (set) Token: 0x06000719 RID: 1817 RVA: 0x0003B007 File Offset: 0x00039207
	public double AvgMs { get; private set; }

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x0600071A RID: 1818 RVA: 0x0003B010 File Offset: 0x00039210
	// (set) Token: 0x0600071B RID: 1819 RVA: 0x0003B018 File Offset: 0x00039218
	public double MaxMs { get; private set; }

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x0600071C RID: 1820 RVA: 0x0003B021 File Offset: 0x00039221
	// (set) Token: 0x0600071D RID: 1821 RVA: 0x0003B029 File Offset: 0x00039229
	public double MinMs { get; private set; }

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x0600071E RID: 1822 RVA: 0x0003B032 File Offset: 0x00039232
	public int SampleCount
	{
		get
		{
			return this._samples.Count;
		}
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x0003B03F File Offset: 0x0003923F
	private void Awake()
	{
		LatencyRecorder.Instance = this;
	}

	// Token: 0x06000720 RID: 1824 RVA: 0x0003B049 File Offset: 0x00039249
	private void OnDestroy()
	{
		LatencyRecorder.Instance = null;
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x0003B054 File Offset: 0x00039254
	private void Update()
	{
		bool active = NetworkServer.active;
		if (!active)
		{
			bool flag = !NetworkClient.isConnected;
			if (flag)
			{
				bool flag2 = this._sampleRoutine != null;
				if (flag2)
				{
					base.StopCoroutine(this._sampleRoutine);
					this._sampleRoutine = null;
					this.FinalizeStats();
				}
			}
			else
			{
				bool flag3 = this._sampleRoutine == null;
				if (flag3)
				{
					this._samples.Clear();
					this._sampleRoutine = base.StartCoroutine(this.SampleRoutine());
				}
			}
		}
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x0003B0D3 File Offset: 0x000392D3
	private IEnumerator SampleRoutine()
	{
		WaitForSecondsRealtime wait = new WaitForSecondsRealtime(1f);
		while (NetworkClient.isConnected && !NetworkServer.active)
		{
			this._samples.Add(NetworkTime.rtt);
			yield return wait;
		}
		this._sampleRoutine = null;
		this.FinalizeStats();
		yield break;
	}

	// Token: 0x06000723 RID: 1827 RVA: 0x0003B0E4 File Offset: 0x000392E4
	private void FinalizeStats()
	{
		bool flag = this._samples.Count == 0;
		if (!flag)
		{
			this.MinMs = this._samples.Min() * 1000.0;
			this.MaxMs = this._samples.Max() * 1000.0;
			this.AvgMs = this._samples.Average() * 1000.0;
			Debug.Log(string.Format("[LatencyRecorder] 采样数={0}, 平均={1:F1}ms, 最高={2:F1}ms, 最低={3:F1}ms", new object[]
			{
				this._samples.Count,
				this.AvgMs,
				this.MaxMs,
				this.MinMs
			}));
			this.UploadToSupabase().Forget();
			this._samples.Clear();
		}
	}

	// Token: 0x06000724 RID: 1828 RVA: 0x0003B1CC File Offset: 0x000393CC
	[DebuggerStepThrough]
	private UniTaskVoid UploadToSupabase()
	{
		LatencyRecorder.<UploadToSupabase>d__25 <UploadToSupabase>d__ = new LatencyRecorder.<UploadToSupabase>d__25();
		<UploadToSupabase>d__.<>t__builder = AsyncUniTaskVoidMethodBuilder.Create();
		<UploadToSupabase>d__.<>4__this = this;
		<UploadToSupabase>d__.<>1__state = -1;
		<UploadToSupabase>d__.<>t__builder.Start<LatencyRecorder.<UploadToSupabase>d__25>(ref <UploadToSupabase>d__);
		return <UploadToSupabase>d__.<>t__builder.Task;
	}

	/// <summary>断开时由 LobbyManager 调用，确保立即停止并输出统计。</summary>
	// Token: 0x06000725 RID: 1829 RVA: 0x0003B210 File Offset: 0x00039410
	public void StopAndReport()
	{
		bool flag = this._sampleRoutine != null;
		if (flag)
		{
			base.StopCoroutine(this._sampleRoutine);
			this._sampleRoutine = null;
		}
		this.FinalizeStats();
	}

	// Token: 0x04000AF4 RID: 2804
	private readonly List<double> _samples = new List<double>();

	// Token: 0x04000AF5 RID: 2805
	private Coroutine _sampleRoutine;
}
