using NiqonNO.UI.MVVM;
using UnityEngine.UIElements;

namespace NiqonNO.Samples
{
	public class NOSampleViewModel : NOViewModel<NOSampleData>
	{
		private readonly NOTernaryViewModel TernaryViewModel;
		private readonly NOSliderViewModel SliderViewModel1;
		private readonly NOSliderViewModel SliderViewModel2;
		private readonly NOSampleDataCollectionViewModel SelectorViewModel1;
		private readonly NOSampleDataCollectionViewModel SelectorViewModel2;
		
		
		public NOSampleViewModel(NOSampleData data) : base(data)
		{
			TernaryViewModel = new NOTernaryViewModel(data.TernaryData);
			SliderViewModel1 = new NOSliderViewModel(data.SliderDataA);
			SliderViewModel2 = new NOSliderViewModel(data.SliderDataB);
			SelectorViewModel1 = new NOSampleDataCollectionViewModel(data.SelectorDataA);
			SelectorViewModel2 = new NOSampleDataCollectionViewModel(data.SelectorDataB);
		}

		public override void Bind(VisualElement context)
		{
			base.Bind(context);
			TernaryViewModel.Bind(context);
			SliderViewModel1.Bind(context);
			SliderViewModel2.Bind(context);
			SelectorViewModel1.Bind(context);
			SelectorViewModel2.Bind(context);
		}
	}
}