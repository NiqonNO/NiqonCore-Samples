using System.Collections.Generic;
using NiqonNO.Core;
using UnityEngine;

namespace NiqonNO.Samples
{
	public class NOSampleModelList : NOScriptableObject
	{
		[field: SerializeField]
		public List<NOSampleModel> Items { get; set; }
		
		[field: SerializeField]
		public int SelectedIndex { get; set;  }

		public NOSampleModel Selected => Items[SelectedIndex];
	}
}