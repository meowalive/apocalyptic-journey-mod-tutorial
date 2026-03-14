using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;

namespace Microsoft.CodeAnalysis.Scripting
{
	// Token: 0x0200022E RID: 558
	internal class LockedMetadataResolver : MetadataReferenceResolver, IEquatable<LockedMetadataResolver>
	{
		// Token: 0x060011CD RID: 4557 RVA: 0x0008C3AA File Offset: 0x0008A5AA
		public LockedMetadataResolver(ScriptMetadataResolver innerResolver)
		{
			this._resolver = innerResolver;
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0008C3BB File Offset: 0x0008A5BB
		public ScriptMetadataResolver WithSearchPaths(params string[] searchPaths)
		{
			return this._resolver.WithSearchPaths(searchPaths);
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0008C3C9 File Offset: 0x0008A5C9
		public ScriptMetadataResolver WithSearchPaths(IEnumerable<string> searchPaths)
		{
			return this._resolver.WithSearchPaths(searchPaths);
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0008C3D7 File Offset: 0x0008A5D7
		public ScriptMetadataResolver WithSearchPaths(ImmutableArray<string> searchPaths)
		{
			return this._resolver.WithSearchPaths(searchPaths);
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x0008C3E5 File Offset: 0x0008A5E5
		public ScriptMetadataResolver WithBaseDirectory([Nullable(2)] string baseDirectory)
		{
			return this._resolver.WithBaseDirectory(baseDirectory);
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x0008C3F4 File Offset: 0x0008A5F4
		[return: Nullable(2)]
		public override PortableExecutableReference ResolveMissingAssembly(MetadataReference definition, AssemblyIdentity referenceIdentity)
		{
			object lockObject = LockedMetadataResolver._lockObject;
			PortableExecutableReference result;
			lock (lockObject)
			{
				result = this._resolver.ResolveMissingAssembly(definition, referenceIdentity);
			}
			return result;
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x0008C440 File Offset: 0x0008A640
		[NullableContext(2)]
		public bool Equals(LockedMetadataResolver other)
		{
			return this._resolver.Equals(other);
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x0008C44E File Offset: 0x0008A64E
		[NullableContext(2)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LockedMetadataResolver);
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x0008C45C File Offset: 0x0008A65C
		public override int GetHashCode()
		{
			return this._resolver.GetHashCode();
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x0008C469 File Offset: 0x0008A669
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public override ImmutableArray<PortableExecutableReference> ResolveReference(string reference, string baseFilePath, MetadataReferenceProperties properties)
		{
			return this._resolver.ResolveReference(reference, baseFilePath, properties);
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x0008C479 File Offset: 0x0008A679
		public override bool ResolveMissingAssemblies
		{
			get
			{
				return this._resolver.ResolveMissingAssemblies;
			}
		}

		// Token: 0x04000EF9 RID: 3833
		private static readonly object _lockObject = new object();

		// Token: 0x04000EFA RID: 3834
		private readonly ScriptMetadataResolver _resolver;
	}
}
