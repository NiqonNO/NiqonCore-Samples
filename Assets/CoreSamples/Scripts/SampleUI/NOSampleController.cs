using UnityEngine;

namespace NiqonNO.Samples
{
	public class NOSampleController : MonoBehaviour
	{
		[SerializeField] [Header("View")] 
		private NOSampleView DocumentView;

		[SerializeField] [Header("Model")] 
		private NOSampleData DataSource;

		private void OnEnable()
		{
			DocumentView.Init(new NOSampleViewModel(DataSource));
		}
	}
}