using Rhino.Render;
using System;
using RhinoCyclesCore;
using System.Runtime.InteropServices;
using Rhino.Display;
using static RhinoCyclesCore.Utilities;
using Pbr = Rhino.Render.PhysicallyBasedMaterial.ParametersNames;

namespace RaytracedMaterials
{
	/*** if you copy this code CHANGE THIS GUID **/
	[Guid("91D8EB8E-EEF1-4B89-87AD-B7B24776B7AB")]
	public class PbrMaterial : RenderMaterial
	{

		public PbrMaterial()
		{
			TexturedSlot(this, Pbr.BaseColor, Color4f.White, "Base Color");

			TexturedSlot(this, Pbr.Subsurface, 0.0f, "Subsurface");
			TexturedSlot(this, Pbr.SubsurfaceScatteringColor, Color4f.White, "Subsurface Color");
			TexturedSlot(this, Pbr.SubsurfaceScatteringRadius, Color4f.White, "Subsurface Radius");

			TexturedSlot(this, Pbr.Metallic, 0.0f, "Metallic");

			TexturedSlot(this, Pbr.Specular, 0.0f, "Specular");
			TexturedSlot(this, Pbr.SpecularTint, 0.0f, "Specular Tint");
			
			TexturedSlot(this, Pbr.Roughness, 0.0f, "Roughness");
			
			TexturedSlot(this, Pbr.Anisotropic, 0.0f, "Anisotropic");
			TexturedSlot(this, Pbr.AnisotropicRotation, 0.0f, "Anisotropic Rotation");
			
			TexturedSlot(this, Pbr.Sheen, 0.0f, "Sheen");
			TexturedSlot(this, Pbr.SheenTint, 0.0f, "Sheen Tint");
			
			TexturedSlot(this, Pbr.Clearcoat, 0.0f, "Clearcoat");
			TexturedSlot(this, Pbr.ClearcoatRoughness, 0.0f, "Clearcoat Roughness");
			
			TexturedSlot(this, Pbr.OpacityIor, 1.45f, "IOR");
			TexturedSlot(this, Pbr.Opacity, 0.0f, "Transmission");
			TexturedSlot(this, Pbr.OpacityRoughness, 0.0f, "Transmission Roughness");
			
			TexturedSlot(this, Pbr.Emission, Color4f.Black, "Emission");
			TexturedSlot(this, Pbr.AmbientOcclusion, 0.0f, "AmbientOcclusion");
			TexturedSlot(this, Pbr.Smudge, 0.0f, "Smudge");
			
			TexturedSlot(this, Pbr.Normal, Color4f.Black, "Normal");
			TexturedSlot(this, Pbr.Bump, Color4f.Black, "Bump");
			TexturedSlot(this, Pbr.Displacement, Color4f.Black, "Displacement");

			ModifyRenderContentStyles(RenderContentStyles.None, RenderContentStyles.TextureSummary);
		}

		public override string TypeName => "Rhino PBR-style material";

		public override string TypeDescription => "Rhino PBR-style material";

		/*****/

		public TexturedColor Base = new TexturedColor(Pbr.BaseColor, Color4f.White, false, 0.0f);
		public CyclesTextureImage BaseTexture = new CyclesTextureImage();

		/*****/

		public TexturedFloat Metallic = new TexturedFloat(Pbr.Metallic, 0.0f, false, 0.0f);
		public CyclesTextureImage MetallicTexture = new CyclesTextureImage();

		/*****/

		public TexturedFloat Subsurface = new TexturedFloat(Pbr.Subsurface, 0.0f, false, 0.0f);
		public CyclesTextureImage SubsurfaceTexture = new CyclesTextureImage();

		/*****/

		public TexturedColor SubsurfaceColor = new TexturedColor(Pbr.SubsurfaceScatteringColor, Color4f.White, false, 0.0f);
		public CyclesTextureImage SubsurfaceColorTexture = new CyclesTextureImage();

		/*****/

		public TexturedColor SubsurfaceRadius = new TexturedColor(Pbr.SubsurfaceScatteringRadius, Color4f.White, false, 0.0f);
		public CyclesTextureImage SubsurfaceRadiusTexture = new CyclesTextureImage();

		/*****/

		public TexturedFloat Specular = new TexturedFloat(Pbr.Specular, 0.0f, false, 0.0f);
		public CyclesTextureImage SpecularTexture = new CyclesTextureImage();

		/*****/

		public TexturedFloat SpecularTint = new TexturedFloat(Pbr.SpecularTint, 0.0f, false, 0.0f);
		public CyclesTextureImage SpecularTintTexture = new CyclesTextureImage();

		/*****/

		public TexturedFloat Roughness = new TexturedFloat(Pbr.Roughness, 0.0f, false, 1.0f);
		public CyclesTextureImage RoughnessTexture = new CyclesTextureImage();

		/*****/

		public TexturedFloat Anisotropic = new TexturedFloat(Pbr.Anisotropic, 0.0f, false, 0.0f);
		public CyclesTextureImage AnisotropicTexture = new CyclesTextureImage();

		/*****/

		public TexturedFloat AnisotropicRotation = new TexturedFloat(Pbr.AnisotropicRotation, 0.0f, false, 0.0f);
		public CyclesTextureImage AnisotropicRotationTexture = new CyclesTextureImage();

		/*****/

		public TexturedFloat Sheen = new TexturedFloat(Pbr.Sheen, 0.0f, false, 0.0f);
		public CyclesTextureImage SheenTexture = new CyclesTextureImage();

		/*****/

		public TexturedFloat SheenTint = new TexturedFloat(Pbr.SheenTint, 0.0f, false, 0.0f);
		public CyclesTextureImage SheenTintTexture = new CyclesTextureImage();

		/*****/

		public TexturedFloat Clearcoat = new TexturedFloat(Pbr.Clearcoat, 0.0f, false, 0.0f);
		public CyclesTextureImage ClearcoatTexture = new CyclesTextureImage();

		/*****/

		public TexturedFloat ClearcoatRoughness = new TexturedFloat(Pbr.ClearcoatRoughness, 0.0f, false, 0.0f);
		public CyclesTextureImage ClearcoatRoughnessTexture = new CyclesTextureImage();

		/*****/

		public TexturedFloat Ior = new TexturedFloat(Pbr.OpacityIor, 1.0f, false, 0.0f);
		public CyclesTextureImage IorTexture = new CyclesTextureImage();

		/*****/

		public TexturedFloat Transmission = new TexturedFloat(Pbr.Opacity, 0.0f, false, 0.0f);
		public CyclesTextureImage TransmissionTexture = new CyclesTextureImage();

		/*****/

		public TexturedFloat TransmissionRoughness = new TexturedFloat(Pbr.OpacityRoughness, 0.0f, false, 0.0f);
		public CyclesTextureImage TransmissionRoughnessTexture = new CyclesTextureImage();

		/*****/
		public TexturedColor Emission = new TexturedColor(Pbr.Emission, Color4f.Black, false, 1.0f);
		public CyclesTextureImage EmissionTexture = new CyclesTextureImage();

		public TexturedFloat AmbientOcclusion = new TexturedFloat(Pbr.AmbientOcclusion, 0.0f, false, 1.0f);
		public CyclesTextureImage AmbientOcclusionTexture = new CyclesTextureImage();

		public TexturedFloat Smudge = new TexturedFloat(Pbr.Smudge, 0.0f, false, 1.0f);
		public CyclesTextureImage SmudgeTexture = new CyclesTextureImage();

		public TexturedColor Normal = new TexturedColor(Pbr.Normal, Color4f.Black, false, 1.0f);
		public CyclesTextureImage NormalTexture = new CyclesTextureImage();

		public TexturedColor Bump = new TexturedColor(Pbr.Bump, Color4f.Black, false, 1.0f);
		public CyclesTextureImage BumpTexture = new CyclesTextureImage();

		public TexturedColor Displacement = new TexturedColor(Pbr.Displacement, Color4f.Black, false, 1.0f);
		public CyclesTextureImage DisplacementTexture = new CyclesTextureImage();

		protected override void OnAddUserInterfaceSections()
		{
			AddAutomaticUserInterfaceSection("Principled Parameters", 0);
		}

		public override void SimulateMaterial(ref Rhino.DocObjects.Material simulatedMaterial, bool forDataOnly)
		{
			var boolrc = false;
			boolrc = HandleTexturedValue(Pbr.BaseColor, Base);
			HandleRenderTexture(Base.Texture, BaseTexture);
			simulatedMaterial.DiffuseColor = Base.Value.AsSystemColor();
			if (Base.Texture != null && Base.On)
			{
				SimulatedTexture simtex = Base.Texture.SimulatedTexture(RenderTexture.TextureGeneration.Allow);
				simulatedMaterial.SetBitmapTexture(simtex.Texture());
			}

			boolrc = HandleTexturedValue(Pbr.Metallic, Metallic);
			simulatedMaterial.Reflectivity = Metallic.Value;
			if (Metallic.Value > 0.5f)
			{
				simulatedMaterial.DiffuseColor = System.Drawing.Color.Black;
				simulatedMaterial.ReflectionColor = Base.Value.AsSystemColor();
			}

			boolrc = HandleTexturedValue(Pbr.Roughness, Roughness);
			simulatedMaterial.ReflectionGlossiness = 1.0f - Roughness.Value;

			boolrc = HandleTexturedValue(Pbr.Opacity, Transmission);
			simulatedMaterial.Transparency = Transmission.Value;
			if(Transmission.Value > 0.5f) {
				simulatedMaterial.TransparentColor = Base.Value.AsSystemColor();
			}

			boolrc = HandleTexturedValue(Pbr.OpacityRoughness, TransmissionRoughness);
			simulatedMaterial.RefractionGlossiness = 1.0f - TransmissionRoughness.Value;
			boolrc = HandleTexturedValue(Pbr.OpacityIor, Ior);
			simulatedMaterial.IndexOfRefraction = Ior.Value;

			boolrc = HandleTexturedValue(Pbr.Normal, Normal);
			HandleRenderTexture(Normal.Texture, NormalTexture);
			if(Normal.On && Normal.Texture != null) {
				SimulatedTexture simtex = Normal.Texture.SimulatedTexture(RenderTexture.TextureGeneration.Allow);
				simulatedMaterial.SetBumpTexture(simtex.Texture());

			}
		}
	}
}
