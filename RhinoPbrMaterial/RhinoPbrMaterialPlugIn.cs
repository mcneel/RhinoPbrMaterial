using Rhino.PlugIns;

namespace RhinoPbrMaterial
{
	///<summary>
	/// Plug-in providing PBR-style material for Rhino 6 and newer.
	///</summary>
	public class RhinoPbrMaterialPlugIn : Rhino.PlugIns.PlugIn

	{
		public RhinoPbrMaterialPlugIn()
		{
			Instance = this;
		}

		///<summary>Gets the only instance of the RhinoPbrMaterialPlugIn plug-in.</summary>
		public static RhinoPbrMaterialPlugIn Instance
		{
			get; private set;
		}

		public override PlugInLoadTime LoadTime => PlugInLoadTime.AtStartup;
	}
}
