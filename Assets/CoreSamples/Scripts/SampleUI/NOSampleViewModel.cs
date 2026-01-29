using System.Collections.Generic;
using System.Linq;
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
		private List<Object> Items
		{
			get => SampleData.Items.Cast<Object>().ToList();
			set => SampleData.Items = value.Cast<NOSampleModel>().ToList();
		}
		[CreateProperty]
		private int SelectedItem
		{
			get => SampleData.SelectedIndex;
			set => SampleData.SelectedIndex = value;
		}

		/*[CreateProperty] 
		private NOBindingCollectionState ToggleSelectorState { get; set; }*/

		public NOSampleViewModel(
			NOVector3Variable vector3Value,
			NOFloatVariable floatValue,
			NOSampleModelList sampleData)
		{
			Vector3Value = vector3Value;
			FloatValue = floatValue;
			SampleData = sampleData;

			/*ToggleSelectorState = new NOBindingCollectionState()
			{
				DataSource = new NOBindingContextCollection<NOSampleModel>(SampleData.Items),
				SelectedItem = SampleData.SelectedIndex,
			};*/
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