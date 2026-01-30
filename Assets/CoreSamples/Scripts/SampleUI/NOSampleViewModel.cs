using System.Collections.Generic;
using NiqonNO.Core;
using NiqonNO.UI;
using NiqonNO.UI.MVVM;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UIElements;

namespace NiqonNO.Samples
{
	public class NOSampleViewModel : NOViewModel
	{
		private readonly NOVector3Variable Vector3Value;
		private readonly NOFloatVariable FloatValue;
		private readonly NOSampleModelList SampleData;
		
		private NOBindingContextCollection<NOSampleModel> SampleDataItems;
		
		[CreateProperty]
		private Vector3 TernaryValue
		{
			get => Vector3Value.Value;
			set => Vector3Value.Value = value;
		}
		[CreateProperty]
		private float SliderValue
		{
			get => FloatValue.Value;
			set => FloatValue.Value = value;
		}
		[CreateProperty]
		private List<INOBindingContext> Items
		{
			get => SampleDataItems.Data;
			set => SampleDataItems.Data = value;
		}		
		[CreateProperty]
		private int SelectedItem
		{
			get => SampleData.SelectedIndex;
			set => SampleData.SelectedIndex = value;
		}

		public NOSampleViewModel(
			NOVector3Variable vector3Value,
			NOFloatVariable floatValue,
			NOSampleModelList sampleData)
		{
			Vector3Value = vector3Value;
			FloatValue = floatValue;
			SampleData = sampleData;

			SampleDataItems = new NOBindingContextCollection<NOSampleModel>(SampleData.Items);
		}

		public override void Bind(VisualElement context)
		{
			context.dataSource = this;
		}
	}
}