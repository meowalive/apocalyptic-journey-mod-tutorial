using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x020000B7 RID: 183
public class AudioManager : MonoBehaviour
{
	// Token: 0x170000BC RID: 188
	// (get) Token: 0x060005C5 RID: 1477 RVA: 0x000340B4 File Offset: 0x000322B4
	[Header("BGM音频源")]
	public AudioSource bgmSource
	{
		get
		{
			bool flag = this._bgmSource == null;
			if (flag)
			{
				this._bgmSource = base.gameObject.AddComponent<AudioSource>();
				bool flag2 = this.bgmGroup != null;
				if (flag2)
				{
					this._bgmSource.outputAudioMixerGroup = this.bgmGroup;
				}
			}
			return this._bgmSource;
		}
	}

	// Token: 0x060005C6 RID: 1478 RVA: 0x00034114 File Offset: 0x00032314
	private void Awake()
	{
		AudioManager.Instance = this;
		this.effectSource = base.gameObject.AddComponent<AudioSource>();
		bool flag = this.effectGroup != null;
		if (flag)
		{
			this.effectSource.outputAudioMixerGroup = this.effectGroup;
		}
	}

	// Token: 0x060005C7 RID: 1479 RVA: 0x0003415C File Offset: 0x0003235C
	private static float LinearToDb(float linear)
	{
		return (linear <= 0.0001f) ? -80f : (20f * Mathf.Log10(linear));
	}

	// Token: 0x060005C8 RID: 1480 RVA: 0x0003418C File Offset: 0x0003238C
	public void ChangeMasterVolume(float volume)
	{
		this.masterVolume = Mathf.Clamp01(volume);
		bool flag = this.audioMixer != null && !string.IsNullOrEmpty(this.masterVolumeParam);
		if (flag)
		{
			this.audioMixer.SetFloat(this.masterVolumeParam, AudioManager.LinearToDb(this.masterVolume));
		}
		else
		{
			this.ChangeBgmVolume(this.bgmVolume);
		}
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x000341F8 File Offset: 0x000323F8
	public void ChangeBgmVolume(float volume)
	{
		this.bgmVolume = volume;
		float v = volume * this.totalVolume * 0.7f * this.masterVolume;
		bool flag = this.audioMixer == null || !this.audioMixer.SetFloat(this.bgmVolumeParam, AudioManager.LinearToDb(v));
		if (flag)
		{
			this.bgmSource.volume = v;
		}
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x00034260 File Offset: 0x00032460
	public void ChangeEffectVolume(float volume)
	{
		this.EffectVolume = volume;
		bool flag = this.audioMixer != null && !string.IsNullOrEmpty(this.effectVolumeParam);
		if (flag)
		{
			this.audioMixer.SetFloat(this.effectVolumeParam, AudioManager.LinearToDb(volume));
		}
	}

	/// <summary>
	/// 播放BGM列表
	/// </summary>
	/// <param name="name">BGM列表名</param>
	/// <param name="next">是否下一首才播放</param>
	// Token: 0x060005CB RID: 1483 RVA: 0x000342B0 File Offset: 0x000324B0
	public void PlayBGMList(string name, bool next = false)
	{
		bool flag = name == this.NowBGMName && this.bgmSource.isPlaying;
		if (!flag)
		{
			BGMList bgmList = ResourceLoader.Load<BGMList>("Configs/Musics/" + name, true);
			this.NowBGMName = name;
			this.RandomPlayList(bgmList.list);
			this.PlayGameBgmList(next);
		}
	}

	/// <summary>
	/// 播放BGM列表
	/// </summary>
	/// <param name="bgmList">BGM列表</param>
	/// <param name="next">是否下一首才播放</param>
	// Token: 0x060005CC RID: 1484 RVA: 0x00034310 File Offset: 0x00032510
	public void PlayBGMList(BGMList bgmList, bool next = false)
	{
		bool flag = bgmList == null || bgmList.list.Count == 0;
		if (!flag)
		{
			bool flag2 = bgmList.name == this.NowBGMName && this.bgmSource.isPlaying;
			if (!flag2)
			{
				this.NowBGMName = bgmList.name;
				this.RandomPlayList(bgmList.list);
				this.PlayGameBgmList(next);
			}
		}
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x00034388 File Offset: 0x00032588
	public void PlayBGMList(List<AudioClip> bgmList, string bgmListName, bool next = false)
	{
		bool flag = bgmList == null || bgmList.Count == 0;
		if (!flag)
		{
			bool flag2 = bgmListName == this.NowBGMName && this.bgmSource.isPlaying;
			if (!flag2)
			{
				this.NowBGMName = bgmListName;
				this.RandomPlayList(bgmList);
				this.PlayGameBgmList(next);
			}
		}
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x000343E8 File Offset: 0x000325E8
	private void PlayGameBgmList(bool next)
	{
		base.StopAllCoroutines();
		bool flag = this.PlayList.Count == 0;
		if (!flag)
		{
			if (next)
			{
				bool flag2 = this.bgmSource.clip != null && this.bgmSource.isPlaying;
				if (flag2)
				{
					return;
				}
			}
			bool flag3 = this.bgmIndex < 0;
			if (flag3)
			{
				this.bgmIndex = 0;
			}
			bool flag4 = this.bgmIndex >= this.PlayList.Count;
			if (flag4)
			{
				this.bgmIndex = 0;
			}
			bool flag5 = this.bgmIndex >= this.PlayList.Count;
			if (!flag5)
			{
				AudioClip clip = this.PlayList[this.bgmIndex];
				this.bgmSource.clip = clip;
				this.bgmSource.Play();
				this.bgmIndex++;
			}
		}
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x000344DC File Offset: 0x000326DC
	private void Update()
	{
		bool flag = this.bgmSource == null;
		if (!flag)
		{
			bool flag2 = !this.bgmSource.isPlaying;
			if (flag2)
			{
				this.PlayGameBgmList(FightManager.Instance != null && FightManager.Instance.fightType == FightType.None);
			}
		}
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x00034534 File Offset: 0x00032734
	public void PlayEffect(string name)
	{
		AudioClip clip = ResourceLoader.Load<AudioClip>("Sounds/" + name, true);
		this.PlayEffect(clip);
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x0003455C File Offset: 0x0003275C
	private AudioSource GetAvailableEffectSource()
	{
		return this.effectSource;
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x00034574 File Offset: 0x00032774
	public void PlayEffect(AudioClip clip)
	{
		bool flag = clip == null;
		if (!flag)
		{
			float lastTime;
			bool flag2 = this.lastPlayedTimes.TryGetValue(clip, out lastTime) && Time.time - lastTime < 0.1f;
			if (!flag2)
			{
				this.lastPlayedTimes[clip] = Time.time;
				AudioSource source = this.GetAvailableEffectSource();
				bool flag3 = source == null;
				if (!flag3)
				{
					source.PlayOneShot(clip, (this.audioMixer != null) ? this.EffectVolume : (this.EffectVolume * this.masterVolume));
				}
			}
		}
	}

	/// <summary> 播放角色语音，同一角色同时只播一条，新语音会打断该角色当前语音。避让请在 Audio Mixer 里用 Sidechain 做。roleId 如 Status.InstanceId </summary>
	// Token: 0x060005D3 RID: 1491 RVA: 0x0003460C File Offset: 0x0003280C
	public void PlayVocal(string roleId, AudioClip clip)
	{
		bool flag = clip == null || string.IsNullOrEmpty(roleId);
		if (!flag)
		{
			AudioSource source;
			bool flag2 = !this._vocalSources.TryGetValue(roleId, out source);
			if (flag2)
			{
				source = base.gameObject.AddComponent<AudioSource>();
				bool flag3 = this.vocalGroup != null;
				if (flag3)
				{
					source.outputAudioMixerGroup = this.vocalGroup;
				}
				this._vocalSources[roleId] = source;
			}
			source.Stop();
			source.clip = clip;
			source.volume = ((this.audioMixer != null) ? this.EffectVolume : (this.EffectVolume * this.masterVolume));
			source.Play();
		}
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x000346C4 File Offset: 0x000328C4
	private void RandomPlayList(List<AudioClip> BGMList)
	{
		this.PlayList = new List<AudioClip>(BGMList.ToArray());
		for (int i = 0; i < this.PlayList.Count; i++)
		{
			AudioClip temp = this.PlayList[i];
			int randomIndex = UnityEngine.Random.Range(i, this.PlayList.Count);
			this.PlayList[i] = this.PlayList[randomIndex];
			this.PlayList[randomIndex] = temp;
		}
		this.bgmIndex = 0;
	}

	// Token: 0x04000A56 RID: 2646
	[Header("AudioMixer（可选）")]
	[SerializeField]
	private AudioMixer audioMixer;

	// Token: 0x04000A57 RID: 2647
	[SerializeField]
	private AudioMixerGroup bgmGroup;

	// Token: 0x04000A58 RID: 2648
	[SerializeField]
	private AudioMixerGroup effectGroup;

	// Token: 0x04000A59 RID: 2649
	[SerializeField]
	private AudioMixerGroup vocalGroup;

	// Token: 0x04000A5A RID: 2650
	[Header("Mixer 暴露参数名（与 Mixer 里 Exposed Parameters 一致）")]
	[SerializeField]
	private string masterVolumeParam = "MasterVolume";

	// Token: 0x04000A5B RID: 2651
	[SerializeField]
	private string bgmVolumeParam = "BGMVolume";

	// Token: 0x04000A5C RID: 2652
	[SerializeField]
	private string effectVolumeParam = "EffectVolume";

	// Token: 0x04000A5D RID: 2653
	[SerializeField]
	private string vocalVolumeParam = "VocalVolume";

	// Token: 0x04000A5E RID: 2654
	private AudioSource _bgmSource;

	// Token: 0x04000A5F RID: 2655
	private List<AudioClip> PlayList = new List<AudioClip>();

	// Token: 0x04000A60 RID: 2656
	private int bgmIndex = 0;

	// Token: 0x04000A61 RID: 2657
	public static AudioManager Instance;

	// Token: 0x04000A62 RID: 2658
	public float EffectVolume = 1f;

	// Token: 0x04000A63 RID: 2659
	private float totalVolume = 0.7f;

	// Token: 0x04000A64 RID: 2660
	public float bgmVolume = 1f;

	// Token: 0x04000A65 RID: 2661
	public string NowBGMName = "";

	// Token: 0x04000A66 RID: 2662
	private AudioSource effectSource;

	// Token: 0x04000A67 RID: 2663
	private Dictionary<object, float> lastPlayedTimes = new Dictionary<object, float>();

	// Token: 0x04000A68 RID: 2664
	private Dictionary<string, AudioSource> _vocalSources = new Dictionary<string, AudioSource>();

	// Token: 0x04000A69 RID: 2665
	public float masterVolume = 1f;
}
