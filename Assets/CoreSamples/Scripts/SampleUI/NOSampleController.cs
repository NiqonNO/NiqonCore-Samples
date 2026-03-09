using System.Collections.Generic;
using NiqonNO.UI.MVVM;
using Unity.Properties;
using UnityEngine;

namespace NiqonNO.Samples
{
	public class NOSampleController : NODocumentController
	{
		[SerializeField, DontCreateProperty] private NOSampleData Model;

		private NOPropertyObserver<Vector3> TernaryObserver;
		private NOPropertyObserver<float> SliderAObserver;
		private NOPropertyObserver<float> SliderBObserver;
		
		private NOPropertyObserver<int> CollectionSelectionAObserver;
		private NOCollectionObserver<NOSampleModel, INOBindingContext> CollectionAObserver;
		
		private NOPropertyObserver<int> CollectionSelectionBObserver;
		private NOCollectionObserver<NOSampleModel, INOBindingContext> CollectionBObserver;

		[CreateProperty]
		private Vector3 TernaryValue
		{
			get => TernaryObserver.Validate(Model.TernaryData.Value);
			set => Model.TernaryData.Value = TernaryObserver.Validate(value);
		}
		
		[CreateProperty]
		private float SliderAValue
		{
			get => SliderAObserver.Validate(Model.SliderDataA.Value);
			set => Model.SliderDataA.Value = SliderAObserver.Validate(value);
		}
		
		[CreateProperty]
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
			TernaryObserver = new NOPropertyObserver<Vector3>(Model.TernaryData.Value);
			SliderAObserver = new NOPropertyObserver<float>(Model.SliderDataA.Value);
			SliderBObserver = new NOPropertyObserver<float>(Model.SliderDataB.Value);
			
			CollectionSelectionAObserver = new NOPropertyObserver<int>(Model.SelectorDataA.SelectedItem.Value);
			CollectionAObserver = new NOCollectionObserver<NOSampleModel, INOBindingContext>(Model.SelectorDataA.DataList);
			
			CollectionSelectionBObserver = new NOPropertyObserver<int>(Model.SelectorDataB.SelectedItem.Value);
			CollectionBObserver = new NOCollectionObserver<NOSampleModel, INOBindingContext>(Model.SelectorDataB.DataList);
			
			base.SetupViewModel();
		}
	}
}