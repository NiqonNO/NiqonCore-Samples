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
		private NOCollectionState ToggleSelectorState { get; set; }

		/*[CreateProperty]
		private IReadOnlyList<NOSampleModel> ToggleSelectorList
		{
			get => SampleData.Items;
			//set => SampleData.Items = value;
		}
		[CreateProperty]
		private int ToggleSelectorSelection
		{
			get => SampleData.SelectedIndex;
			set => SampleData.SelectedIndex = value;
		}*/

		public NOSampleViewModel(
			NOVector3Variable vector3Value,
			NOFloatVariable floatValue,
			NOSampleModelList sampleData)
		{
			Vector3Value = vector3Value;
			FloatValue = floatValue;
			SampleData = sampleData;

			ToggleSelectorState = NOCollectionState.Create<NOSampleModel>(SampleData.Items, SampleData.SelectedIndex);
		}

		public override void Bind(VisualElement context)
		{
			context.dataSource = this;
		}

		public override void Unbind()
		{
		}
	}
}