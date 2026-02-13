using NiqonNO.Core;
using NiqonNO.UI.MVVM;
using UnityEngine;
using UnityEngine.UIElements;

namespace NiqonNO.Samples
{
	public class NOSampleModel : NOScriptableObject, INOBindingContext
	{
		[field: SerializeField] public string DisplayName { get; set; }

		[field: SerializeField] public string DisplayDescription { get; set; }

		[field: SerializeField] public Color DisplayColor { get; set; }

		[field: SerializeField] public Sprite DisplaySprite { get; set; }
		
		public void Bind(VisualElement context)
		{
			context.dataSource = this;
		}

		public void Unbind()
		{ }
	}
}