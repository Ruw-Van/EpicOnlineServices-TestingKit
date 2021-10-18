// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.TitleStorage
{
	/// <summary>
	/// Input data for the <see cref="TitleStorageInterface.QueryFileList" /> function
	/// </summary>
	public class QueryFileListOptions
	{
		/// <summary>
		/// Product User ID of the local user who requested file metadata (optional)
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// List of tags to use for lookup.
		/// </summary>
		public string[] ListOfTags { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct QueryFileListOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_ListOfTags;
		private uint m_ListOfTagsCount;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public string[] ListOfTags
		{
			set
			{
				Helper.TryMarshalSet(ref m_ListOfTags, value, out m_ListOfTagsCount);
			}
		}

		public void Set(QueryFileListOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = TitleStorageInterface.QueryfilelistoptionsApiLatest;
				LocalUserId = other.LocalUserId;
				ListOfTags = other.ListOfTags;
			}
		}

		public void Set(object other)
		{
			Set(other as QueryFileListOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_ListOfTags);
		}
	}
}