using System;
using NiqonNO.UI.MVVM;
using UnityEngine;

namespace NiqonNO.Samples
{
	[Serializable]
	public class NOSampleData : NOBindingData
	{
		[SerializeField]
		public NOTernaryData TernaryData;
		[SerializeField] 
		public NOSliderData SliderDataA;
		[SerializeField] 
		public NOSliderData SliderDataB;
		[SerializeField] 
		public NOSelectorData<NOSampleModel> SelectorDataA;
		[SerializeField] 
		public NOSelectorData<NOSampleModel> SelectorDataB;
	}
}