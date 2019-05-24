using System.Reflection;
using System.Runtime.InteropServices;
using Rhino.PlugIns;

[assembly: PlugInDescription(DescriptionType.Address, "3670 Woodland Park Avenue North\r\nSeattle, WA 98103")]
[assembly: PlugInDescription(DescriptionType.Country, "United States")]
[assembly: PlugInDescription(DescriptionType.Email, "devsupport@mcneel.com")]
[assembly: PlugInDescription(DescriptionType.Phone, "206-545-6877")]
[assembly: PlugInDescription(DescriptionType.Fax, "206-545-7321")]
[assembly: PlugInDescription(DescriptionType.Organization, "Robert McNeel & Associates")]
[assembly: PlugInDescription(DescriptionType.UpdateUrl, "https://github.com/mcneel/RhinoPbrMaterial")]
[assembly: PlugInDescription(DescriptionType.WebSite, "http://www.rhino3d.com/")]
// Icons should be Windows .ico files and contain 32-bit images in the following sizes: 16, 24, 32, 48, and 256.
// This is a Rhino 6-only description.
[assembly: PlugInDescription(DescriptionType.Icon, "RhinoPbrMaterial.EmbeddedResources.plugin-utility.ico")]

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("RhinoPbrMaterial")]

// This will be used also for the plug-in description.
[assembly: AssemblyDescription("RhinoPbrMaterial - reference PBR material implementation.")]

[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Robert McNeel & Associates")]
[assembly: AssemblyProduct("RhinoPbrMaterial")]
[assembly: AssemblyCopyright("Copyright ©  2019, Robert McNeel & Associates")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("adeb6492-9e4c-4a21-9f46-eccbb6dc1ee4")] // This will also be the Guid of the Rhino plug-in

// Make compatible with Rhino Installer Engine
[assembly: AssemblyInformationalVersion("2")]

[assembly: AssemblyVersion("1.1.1")]
[assembly: AssemblyFileVersion("1.1.1")]

