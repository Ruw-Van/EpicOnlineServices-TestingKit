// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Contains information about a request to purchase a single offer. This structure is set as part
	/// of the <see cref="CheckoutOptions" /> structure.
	/// </summary>
	public class CheckoutEntry : ISettable
	{
		/// <summary>
		/// The ID of the offer to purchase
		/// </summary>
		public string OfferId { get; set; }

		internal void Set(CheckoutEntryInternal? other)
		{
			if (other != null)
			{
				OfferId = other.Value.OfferId;
			}
		}

		public void Set(object other)
		{
			Set(other as CheckoutEntryInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct CheckoutEntryInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_OfferId;

		public string OfferId
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_OfferId, out value);
				return value;
			}

			set
			{
				Helper.TryMarshalSet(ref m_OfferId, value);
			}
		}

		public void Set(CheckoutEntry other)
		{
			if (other != null)
			{
				m_ApiVersion = EcomInterface.CheckoutentryApiLatest;
				OfferId = other.OfferId;
			}
		}

		public void Set(object other)
		{
			Set(other as CheckoutEntry);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_OfferId);
		}
	}
}