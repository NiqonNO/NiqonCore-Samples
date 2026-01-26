using NiqonNO.Core;
using UnityEngine;

namespace NiqonNO.Samples
{
	public class NOSampleController : MonoBehaviour
	{
		[SerializeField] [Header("View")] 
		private NOSampleView DocumentView;
		
		[SerializeField] [Header("Model")] 
		NOVector3Variable Vector3Value;
		[SerializeField] 
		NOFloatVariable FloatValue;
		[SerializeField] 
		NOSampleModelList SampleData;

		private void OnEnable()
		{
			DocumentView.Init(new NOSampleViewModel(
				Vector3Value,
				FloatValue,
				SampleData
			));
		}
	}
}