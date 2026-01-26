using NiqonNO.Core;
using UnityEngine;

namespace NiqonNO.Samples
{
	public class NOSampleModel : NOScriptableObject
	{
		[field: SerializeField] public string DisplayName { get; set; }

		[field: SerializeField] public string DisplayDescription { get; set; }

		[field: SerializeField] public Color DisplayColor { get; set; }

		[field: SerializeField] public Sprite DisplaySprite { get; set; }
	}
}