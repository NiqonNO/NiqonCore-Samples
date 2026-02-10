using NiqonNO.UI.MVVM;
using Unity.Properties;

namespace NiqonNO.Samples
{
	public class NOSampleDataCollectionViewModel : NOCollectionViewModel<INOBindingDataCollection<NOSampleModel>, NOSampleModel>
	{	
		[CreateProperty]
		private int SelectedItem
		{
			get => DataProvider.SelectedIndex;
			set => DataProvider.SelectedIndex = value;
		}
		
		public NOSampleDataCollectionViewModel(INOBindingDataCollection<NOSampleModel> dataProvider) : base(dataProvider) { }
	}
}