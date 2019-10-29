//Maya ASCII 2019 scene
//Name: RoofCorner.ma
//Last modified: Tue, Oct 29, 2019 05:39:38 PM
//Codeset: 1252
requires maya "2019";
requires "mtoa" "3.1.2";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2019";
fileInfo "version" "2019";
fileInfo "cutIdentifier" "201812112215-434d8d9c04";
fileInfo "osv" "Microsoft Windows 7 Home Premium Edition, 64-bit Windows 7 Service Pack 1 (Build 7601)\n";
fileInfo "license" "student";
createNode transform -n "Roofcorner3";
	rename -uid "0FF883CB-48DA-7BB3-C60E-88BD0F3FA455";
	setAttr ".rp" -type "double3" -2.384185791015625e-07 0 -1 ;
	setAttr ".sp" -type "double3" -2.384185791015625e-07 0 -1 ;
createNode mesh -n "Roofcorner3Shape" -p "Roofcorner3";
	rename -uid "5FF4C479-4ABF-C75E-0A91-12BCB229CE60";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.25 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 40 ".uvst[0].uvsp[0:39]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25 0.375 0.25 0.625 0.25 0.625 0.5 0.375 0.5 0.375 0.25
		 0.625 0.25 0.625 0.5 0.375 0.5 0.625 0.025 0.625 0.72499996 0.875 0.025000006 0.125
		 0.025000006 0.375 0.72499996 0.37499997 0.025 0.625 0.70249999 0.875 0.047500011
		 0.625 0.047499999 0.37499997 0.047499999 0.125 0.047500011 0.375 0.70249999 0.625
		 0.68224996 0.875 0.067750014 0.625 0.067749999 0.37499997 0.067749999 0.125 0.067750014
		 0.375 0.68224996;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 28 ".pt[0:27]" -type "float3"  10 -2.00157 2.9802322e-08 
		1 -2.00157 2.9802322e-08 10 -10.640762 0.33303192 1.6705505 -10.640762 0.33303192 
		10 -10.640762 1.4808029e-07 1.6705505 -10.640762 1.4808029e-07 10 -2.00157 1.4808029e-07 
		1 -2.00157 1.4808029e-07 10 -10.640762 0.78683788 2.0478742 -10.640762 0.78683788 
		2.0478742 -10.640762 0.26103649 10 -10.640762 0.26103649 10 -13.382227 0.786838 2.0478742 
		-13.382227 0.786838 2.0478742 -13.382227 0.26103649 10 -13.382227 0.26103649 1 -2.8121216 
		8.9406967e-08 1 -2.8121216 1.4808029e-07 10 -2.8121216 1.4808029e-07 10 -2.8121216 
		8.9406967e-08 1.2907786 -3.5416181 1.4808029e-07 1.2907786 -3.5416179 0.29077864 
		10 -3.5416179 0.29077864 10 -3.5416181 1.4808029e-07 1.2907785 -4.1981649 1.4808029e-07 
		1.2907785 -4.1981649 0.29077864 10 -4.1981649 0.29077864 10 -4.1981649 1.4808029e-07;
	setAttr -s 28 ".vt[0:27]"  -10 1.5258789e-05 4.4703484e-08 0 1.5258789e-05 4.4703484e-08
		 -10 10.000007629395 4.4703484e-08 0 10.000007629395 4.4703484e-08 -10 10.000007629395 -1
		 0 10.000007629395 -1 -10 1.5258789e-05 -1 0 1.5258789e-05 -1 -10 10.000007629395 0.26103655
		 0 10.000007629395 0.26103655 0 10.000007629395 -1.26103652 -10 10.000007629395 -1.26103652
		 -10 13.38222694 0.26103655 0 13.38222694 0.26103655 0 13.38222694 -1.26103652 -10 13.38222694 -1.26103652
		 0 1.000014543533 4.470348e-08 0 1.000014662743 -1 -10 1.000014662743 -1 -10 1.000014543533 4.470348e-08
		 0 1.90001416 -1 0 1.90001392 4.470348e-08 -10 1.90001392 4.470348e-08 -10 1.90001416 -1
		 0 2.71001363 -1 0 2.71001339 4.470348e-08 -10 2.71001339 4.470348e-08 -10 2.71001363 -1;
	setAttr -s 52 ".ed[0:51]"  0 1 0 2 3 0 4 5 0 6 7 0 1 16 0 2 4 0 3 5 0
		 6 0 0 7 1 0 0 19 0 5 24 0 4 27 0 2 8 0 3 9 0 8 9 0 5 10 0 9 10 0 4 11 0 11 10 0 8 11 0
		 8 12 0 9 13 0 12 13 0 10 14 0 13 14 0 11 15 0 15 14 0 12 15 0 16 21 0 17 7 0 18 6 0
		 19 22 0 16 17 1 17 18 1 18 19 1 19 16 1 20 17 0 21 25 0 22 26 0 23 18 0 20 21 1 21 22 1
		 22 23 1 23 20 1 24 20 0 25 3 0 26 2 0 27 23 0 24 25 1 25 26 1 26 27 1 27 24 1;
	setAttr -s 26 -ch 104 ".fc[0:25]" -type "polyFaces" 
		f 4 41 -32 35 28
		mu 0 4 30 31 27 22
		f 4 22 24 -27 -28
		mu 0 4 18 19 20 21
		f 4 43 36 33 -40
		mu 0 4 33 28 23 26
		f 4 3 8 -1 -8
		mu 0 4 6 7 9 8
		f 4 40 -29 32 -37
		mu 0 4 29 30 22 24
		f 4 34 31 42 39
		mu 0 4 25 27 31 32
		f 4 1 13 -15 -13
		mu 0 4 2 3 15 14
		f 4 6 15 -17 -14
		mu 0 4 3 5 16 15
		f 4 -3 17 18 -16
		mu 0 4 5 4 17 16
		f 4 -6 12 19 -18
		mu 0 4 4 2 14 17
		f 4 14 21 -23 -21
		mu 0 4 14 15 19 18
		f 4 16 23 -25 -22
		mu 0 4 15 16 20 19
		f 4 -19 25 26 -24
		mu 0 4 16 17 21 20
		f 4 -20 20 27 -26
		mu 0 4 17 14 18 21
		f 4 -33 -5 -9 -30
		mu 0 4 24 22 1 10
		f 4 -34 29 -4 -31
		mu 0 4 26 23 7 6
		f 4 9 -35 30 7
		mu 0 4 0 27 25 12
		f 4 -36 -10 0 4
		mu 0 4 22 27 0 1
		f 4 48 -38 -41 -45
		mu 0 4 35 36 30 29
		f 4 49 -39 -42 37
		mu 0 4 36 37 31 30
		f 4 -43 38 50 47
		mu 0 4 32 31 37 38
		f 4 51 44 -44 -48
		mu 0 4 39 34 28 33
		f 4 -7 -46 -49 -11
		mu 0 4 11 3 36 35
		f 4 -2 -47 -50 45
		mu 0 4 3 2 37 36
		f 4 -51 46 5 11
		mu 0 4 38 37 2 13
		f 4 2 10 -52 -12
		mu 0 4 4 5 34 39;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode mesh -n "polySurfaceShape1" -p "Roofcorner3";
	rename -uid "552B6323-4D8F-4816-1E61-E4B1857E42D8";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.375 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 9 ".pt[0:8]" -type "float3"  -5 5 -0.50000006 -5 5 -0.50000006 
		-5 5 -0.50000006 -5 5 -0.50000006 -5 5 -0.5 -5 5 -0.5 -5 5 -0.5 -5 5 -0.5 0 0 0;
	setAttr -s 8 ".vt[0:7]"  -5 -5 0.5 5 -5 0.5 -5 5 0.5 5 5 0.5 -5 5 -0.5
		 5 5 -0.5 -5 -5 -0.5 5 -5 -0.5;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 1 3 0 2 4 0 3 5 0
		 6 0 0 7 1 0 0 2 0 5 7 0 4 6 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 -2 -10 0 4
		mu 0 4 3 2 0 1
		f 4 1 6 -3 -6
		mu 0 4 2 3 5 4
		f 4 2 10 -4 -12
		mu 0 4 4 5 7 6
		f 4 3 8 -1 -8
		mu 0 4 6 7 9 8
		f 4 -7 -5 -9 -11
		mu 0 4 11 3 1 10
		f 4 9 5 11 7
		mu 0 4 0 2 13 12;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode materialInfo -n "materialInfo1";
	rename -uid "ACF16D33-433C-0F57-B281-E9A1C21E5FC4";
createNode shadingEngine -n "lambert2SG";
	rename -uid "392CDEE6-47C6-9899-F7B6-1BAE0852BE90";
	setAttr ".ihi" 0;
	setAttr -s 35 ".dsm";
	setAttr ".ro" yes;
	setAttr -s 18 ".gn";
createNode lambert -n "whitebrick";
	rename -uid "C7CC844F-43B9-7F56-6F46-7186561B7952";
	setAttr ".c" -type "float3" 1 1 1 ;
createNode lightLinker -s -n "lightLinker1";
	rename -uid "5C8618AE-4BD3-A58B-8951-ADBA6DD1DBAC";
	setAttr -s 9 ".lnk";
	setAttr -s 9 ".slnk";
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 9 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 11 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderUtilityList1;
select -ne :defaultRenderingList1;
select -ne :defaultTextureList1;
select -ne :lambert1;
	setAttr ".c" -type "float3" 0.5 0.141 0.141 ;
select -ne :initialShadingGroup;
	setAttr -s 22 ".dsm";
	setAttr ".ro" yes;
	setAttr -s 4 ".gn";
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultRenderGlobals;
	setAttr ".ren" -type "string" "arnold";
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
select -ne :ikSystem;
	setAttr -s 4 ".sol";
connectAttr "lambert2SG.msg" "materialInfo1.sg";
connectAttr "whitebrick.msg" "materialInfo1.m";
connectAttr "whitebrick.oc" "lambert2SG.ss";
connectAttr "corner7Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "windowtop1Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "windowtop5Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "pCylinder3Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "pCylinder4Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "pCylinder5Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "pCylinder6Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "pCylinder7Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "pCylinder8Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "pCylinder9Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "pCylinder10Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "pCube26Shape.iog.og[1]" "lambert2SG.dsm" -na;
connectAttr "roofPieceFrontShape.iog" "lambert2SG.dsm" -na;
connectAttr "starless_fireShape.iog.og[1]" "lambert2SG.dsm" -na;
connectAttr "|wall4Shape.iog" "lambert2SG.dsm" -na;
connectAttr "|wall5Shape.iog" "lambert2SG.dsm" -na;
connectAttr "|wall6Shape.iog" "lambert2SG.dsm" -na;
connectAttr "roofPiece1Shape.iog" "lambert2SG.dsm" -na;
connectAttr "|wall4Shape.iog" "lambert2SG.dsm" -na;
connectAttr "|wall5Shape.iog" "lambert2SG.dsm" -na;
connectAttr "|wall6Shape.iog" "lambert2SG.dsm" -na;
connectAttr "RoofcornerShape.iog" "lambert2SG.dsm" -na;
connectAttr "roofPieceSideShape.iog" "lambert2SG.dsm" -na;
connectAttr "|wall4Shape.iog" "lambert2SG.dsm" -na;
connectAttr "|wall5Shape.iog" "lambert2SG.dsm" -na;
connectAttr "|wall6Shape.iog" "lambert2SG.dsm" -na;
connectAttr "pCylinder2Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "windowtop7Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "windowPanel3Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "stairSideShape.iog" "lambert2SG.dsm" -na;
connectAttr "stairSide1Shape.iog" "lambert2SG.dsm" -na;
connectAttr "StariShape.iog" "lambert2SG.dsm" -na;
connectAttr "doorFrame2Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "Roofcorner3Shape.iog" "lambert2SG.dsm" -na;
connectAttr "doorFrameShape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "groupId1.msg" "lambert2SG.gn" -na;
connectAttr "groupId2.msg" "lambert2SG.gn" -na;
connectAttr "groupId5.msg" "lambert2SG.gn" -na;
connectAttr "groupId14.msg" "lambert2SG.gn" -na;
connectAttr "groupId15.msg" "lambert2SG.gn" -na;
connectAttr "groupId16.msg" "lambert2SG.gn" -na;
connectAttr "groupId17.msg" "lambert2SG.gn" -na;
connectAttr "groupId18.msg" "lambert2SG.gn" -na;
connectAttr "groupId19.msg" "lambert2SG.gn" -na;
connectAttr "groupId20.msg" "lambert2SG.gn" -na;
connectAttr "groupId21.msg" "lambert2SG.gn" -na;
connectAttr "groupId23.msg" "lambert2SG.gn" -na;
connectAttr "groupId26.msg" "lambert2SG.gn" -na;
connectAttr "groupId58.msg" "lambert2SG.gn" -na;
connectAttr "groupId59.msg" "lambert2SG.gn" -na;
connectAttr "groupId63.msg" "lambert2SG.gn" -na;
connectAttr "groupId65.msg" "lambert2SG.gn" -na;
connectAttr "groupId67.msg" "lambert2SG.gn" -na;
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "lambert2SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "lambert2SG.message" ":defaultLightSet.message";
connectAttr "lambert2SG.pa" ":renderPartition.st" -na;
connectAttr "whitebrick.msg" ":defaultShaderList1.s" -na;
// End of RoofCorner.ma
