Rhino PBR-style material
========================

This repository contains the reference PBR material implementation that shows
how to implement a custom RenderMaterial built on top of the textured content
field and GetParameter() API to ensure it works with Raytraced (v6) and in the
'near' future in v7 (also Rendered mode).

The Rhino.Render.PhysicallyBasedMaterial.ParameterNames class contains the
names of the PBR parameters Rhino supports and understands. Any one wishing
to create PBR materials should use these.

The reference material plug-in can be installed using `_TestPackageManager`.
The name of the packages is `rhinopbrmaterial`.

Note that Rhino 6.12 or newer is needed.
