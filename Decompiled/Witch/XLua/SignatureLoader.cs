using System;
using System.Security.Cryptography;

namespace XLua
{
	// Token: 0x0200017F RID: 383
	public class SignatureLoader
	{
		// Token: 0x06000B6C RID: 2924 RVA: 0x0005AAB2 File Offset: 0x00058CB2
		public SignatureLoader(string publicKey, LuaEnv.CustomLoader loader)
		{
			this.rsa = new RSACryptoServiceProvider();
			this.rsa.ImportCspBlob(Convert.FromBase64String(publicKey));
			this.sha = new SHA1CryptoServiceProvider();
			this.userLoader = loader;
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0005AAEC File Offset: 0x00058CEC
		private byte[] load_and_verify(ref string filepath)
		{
			byte[] data = this.userLoader(ref filepath);
			bool flag = data == null;
			byte[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				bool flag2 = data.Length < 128;
				if (flag2)
				{
					throw new InvalidProgramException(filepath + " length less than 128!");
				}
				byte[] sig = new byte[128];
				byte[] filecontent = new byte[data.Length - 128];
				Array.Copy(data, sig, 128);
				Array.Copy(data, 128, filecontent, 0, filecontent.Length);
				bool flag3 = !this.rsa.VerifyData(filecontent, this.sha, sig);
				if (flag3)
				{
					throw new InvalidProgramException(filepath + " has invalid signature!");
				}
				result = filecontent;
			}
			return result;
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0005ABAC File Offset: 0x00058DAC
		public static implicit operator LuaEnv.CustomLoader(SignatureLoader signatureLoader)
		{
			return new LuaEnv.CustomLoader(signatureLoader.load_and_verify);
		}

		// Token: 0x04000DA3 RID: 3491
		private LuaEnv.CustomLoader userLoader;

		// Token: 0x04000DA4 RID: 3492
		private RSACryptoServiceProvider rsa;

		// Token: 0x04000DA5 RID: 3493
		private SHA1 sha;
	}
}
