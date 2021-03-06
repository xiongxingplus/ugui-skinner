using System;

namespace Pspkurara.UI.Skinner
{

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public sealed class SkinPartsAttribute : Attribute
	{

		public SkinPartsAttribute(int id, Type rootType, Type logicType)
		{
			Id = id;
			RootType = rootType;
			LogicType = logicType;
		}

		public SkinPartsAttribute(SkinPartsType partsType, Type rootType, Type logicType) : this((int)partsType, rootType, logicType) { }

		public int Id;

		public Type RootType;

		public Type LogicType;

	}

}
