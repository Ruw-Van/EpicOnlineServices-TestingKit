// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Input parameters for the <see cref="Transaction.GetEntitlementsCount" /> function.
	/// </summary>
	public class TransactionGetEntitlementsCountOptions
	{
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct TransactionGetEntitlementsCountOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;

		public void Set(TransactionGetEntitlementsCountOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = Transaction.TransactionGetentitlementscountApiLatest;
			}
		}

		public void Set(object other)
		{
			Set(other as TransactionGetEntitlementsCountOptions);
		}

		public void Dispose()
		{
		}
	}
}