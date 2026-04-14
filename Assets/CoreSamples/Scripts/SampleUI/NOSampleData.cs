using System;
using System.Collections.Generic;
using NiqonNO.Core;
using UnityEngine;

namespace NiqonNO.Samples
{
	[Serializable]
	public class NOSampleData
	{
		[SerializeField]
		public NOValue<Vector3> TernaryData;
		[SerializeField] 
		public NOValue<Vector4> QuaternaryData;
		[SerializeField] 
		public NOValue<Color> ColorPickerData;
		[SerializeField] 
		public NOValue<float> SliderDataA;
		[SerializeField] 
		public NOValue<float> SliderDataB;
		[SerializeField] 
		public NOSampleCollectionData SelectorDataA;
		[SerializeField] 
		public NOSampleCollectionData SelectorDataB;
	}
	
	[Serializable]
	public class NOSampleCollectionData
	{
		[SerializeField] 
		public NOValue<int> SelectedItem;
		[SerializeField] 
		public List<NOSampleModel> DataList;
	}
}