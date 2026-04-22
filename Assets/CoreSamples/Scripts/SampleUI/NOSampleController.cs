using System.Collections.Generic;
using NiqonNO.UI.MVVM;
using NiqonNO.UI.View;
using Unity.Properties;
using UnityEngine;

namespace NiqonNO.Samples
{
	public class NOSampleController : NODocumentController
	{
		[SerializeField, DontCreateProperty] private NOSampleData Model;

		private NOPropertyObserver<Vector3> TernaryObserver;
		private NOPropertyObserver<Vector4> QuaternaryObserver;
		private NOPropertyObserver<Color> ColorPickerObserver;
		private NOPropertyObserver<float> SliderAObserver;
		private NOPropertyObserver<float> SliderBObserver;
		
		private NOPropertyObserver<int> CollectionSelectionAObserver;
		private NOCollectionObserver<NOSampleModel, INOBindingContext> CollectionAObserver;
		
		private NOPropertyObserver<int> CollectionSelectionBObserver;
		private NOCollectionObserver<NOSampleModel, INOBindingContext> CollectionBObserver;
		
		[NOMVVMBind]
		private Vector3 TernaryValue
		{
			get => TernaryObserver.Validate(Model.TernaryData.Value);
			set => Model.TernaryData.Value = TernaryObserver.Validate(value);
		}
		
		[NOMVVMBind]
		private Vector4 QuaternaryValue
		{
			get => QuaternaryObserver.Validate(Model.QuaternaryData.Value);
			set => Model.QuaternaryData.Value = QuaternaryObserver.Validate(value);
		}
		
		[NOMVVMBind]
		private Color ColorPickerValue
		{
			get => ColorPickerObserver.Validate(Model.ColorPickerData.Value);
			set => Model.ColorPickerData.Value = ColorPickerObserver.Validate(value);
		}
		
		[NOMVVMBind]
		private float SliderAValue
		{
			get => SliderAObserver.Validate(Model.SliderDataA.Value);
			set => Model.SliderDataA.Value = SliderAObserver.Validate(value);
		}
		
		[NOMVVMBind]
		private float SliderBValue
		{
			get => SliderBObserver.Validate(Model.SliderDataB.Value);
			set => Model.SliderDataB.Value = SliderBObserver.Validate(value);
		}
		
		[CreateProperty]
		private int CollectionSelectionAValue
		{
			get => CollectionSelectionAObserver.Validate(Model.SelectorDataA.SelectedItem.Value);
			set => Model.SelectorDataA.SelectedItem.Value = CollectionSelectionAObserver.Validate(value);
		}
		[CreateProperty]
		private IReadOnlyList<INOBindingContext> CollectionAValue
		{
			get => CollectionAObserver.Validate(Model.SelectorDataA.DataList);
			set => Model.SelectorDataA.DataList = CollectionAObserver.Validate(value);
		}
		
		[CreateProperty]
		private int CollectionSelectionBValue
		{
			get => CollectionSelectionBObserver.Validate(Model.SelectorDataB.SelectedItem.Value);
			set => Model.SelectorDataB.SelectedItem.Value = CollectionSelectionBObserver.Validate(value);
		}
		[CreateProperty]
		private IReadOnlyList<INOBindingContext> CollectionBValue
		{
			get => CollectionBObserver.Validate(Model.SelectorDataB.DataList);
			set => Model.SelectorDataB.DataList = CollectionBObserver.Validate(value);
		}
		
		protected override void SetupViewModel()
		{
			TernaryObserver = new NOPropertyObserver<Vector3>(Model.TernaryData.Value, DebugValue);
			QuaternaryObserver = new NOPropertyObserver<Vector4>(Model.QuaternaryData.Value, DebugValue);
			ColorPickerObserver = new NOPropertyObserver<Color>(Model.ColorPickerData.Value, DebugValue);
			SliderAObserver = new NOPropertyObserver<float>(Model.SliderDataA.Value, DebugValue);
			SliderBObserver = new NOPropertyObserver<float>(Model.SliderDataB.Value, DebugValue);
			
			CollectionSelectionAObserver = new NOPropertyObserver<int>(Model.SelectorDataA.SelectedItem.Value, DebugValue);
			CollectionAObserver = new NOCollectionObserver<NOSampleModel, INOBindingContext>(Model.SelectorDataA.DataList, DebugValue);
			
			CollectionSelectionBObserver = new NOPropertyObserver<int>(Model.SelectorDataB.SelectedItem.Value, DebugValue);
			CollectionBObserver = new NOCollectionObserver<NOSampleModel, INOBindingContext>(Model.SelectorDataB.DataList, DebugValue);
			
			base.SetupViewModel();
		}

		private void DebugValue<T>(T value)
		{
			Debug.Log($"Updated: {value}");
		}
	}
}