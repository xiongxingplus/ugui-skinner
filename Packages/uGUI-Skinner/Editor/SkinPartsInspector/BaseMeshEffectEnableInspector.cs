using UnityEditor;
using UnityEngine.UI;

namespace Pspkurara.UI.Skinner
{

	[SkinPartsInspector(typeof(BaseMeshEffectEnable))]
	internal sealed class BaseMeshEffectEnableInspector : SkinPartsOnArrayInspector<BaseMeshEffect>
	{

		protected override void CleanupFieldsOtherThanObjectReference(EditorSkinPartsPropertryWithoutObjectReference property)
		{
			SkinnerEditorUtility.CleanArray(property.boolValues, BaseMeshEffectEnable.BoolLength);
			SkinnerEditorUtility.CleanArray(property.colorValues);
			SkinnerEditorUtility.CleanArray(property.floatValues);
			SkinnerEditorUtility.CleanArray(property.intValues);
			SkinnerEditorUtility.CleanArray(property.vector4Values);
			SkinnerEditorUtility.CleanArray(property.stringValues);
		}

		protected override void ResetArrayOtherThanObjectReference(EditorSkinPartsPropertryWithoutObjectReference property)
		{
			SkinnerEditorUtility.ResetArray(property.boolValues, BaseMeshEffectEnable.BoolLength);
		}

		protected override void DrawOptionProperty(EditorSkinPartsPropertry property)
		{
			EditorGUILayout.PropertyField(property.boolValues.GetArrayElementAtIndex(BaseMeshEffectEnable.BoolIndex), SkinContent.Enabled);
		}

	}

}
