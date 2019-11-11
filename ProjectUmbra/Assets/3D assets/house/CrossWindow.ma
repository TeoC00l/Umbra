//Maya ASCII 2019 scene
//Name: CrossWindow.ma
//Last modified: Thu, Oct 31, 2019 03:32:01 PM
//Codeset: 1252
requires maya "2019";
requires "mtoa" "3.1.2";
requires "mtoa" "3.1.2";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2019";
fileInfo "version" "2019";
fileInfo "cutIdentifier" "201812112215-434d8d9c04";
fileInfo "osv" "Microsoft Windows 7 Home Premium Edition, 64-bit Windows 7 Service Pack 1 (Build 7601)\n";
fileInfo "license" "student";
createNode transform -n "CrossWindow";
	rename -uid "E4144102-4980-C595-4CFA-71B3A0849574";
createNode mesh -n "CrossWindowShape" -p "CrossWindow";
	rename -uid "6F9218C8-4E28-6A40-954B-31A2E61ED7F1";
	setAttr -k off ".v";
	setAttr -s 4 ".iog[0].og";
	setAttr ".iog[0].og[4].gcl" -type "componentList" 4 "f[1:9]" "f[11:13]" "f[15]" "f[17:40]";
	setAttr ".iog[0].og[5].gcl" -type "componentList" 4 "f[0]" "f[10]" "f[14]" "f[16]";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr -s 2 ".ciog[0].cog";
	setAttr ".pv" -type "double2" 0.5 0.125 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 56 ".uvst[0].uvsp[0:55]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25 0.375 0 0.625 0 0.625 0.25 0.375 0.25 0.625 0.083333246
		 0.375 0.083333246 0.625 0.16666663 0.375 0.16666663 0.45833325 0 0.45833325 1 0.45833325
		 0.75 0.45833325 0.5 0.45833325 0.25 0.45833325 0.25 0.45833325 0.16666663 0.45833325
		 0.083333246 0.45833325 0 0.54166663 0 0.54166663 1 0.54166663 0.75 0.54166663 0.5
		 0.54166663 0.25 0.54166663 0.25 0.54166663 0.16666663 0.54166663 0.083333246 0.54166663
		 0 0.54166663 0.083333246 0.54166663 0 0.625 0 0.625 0.083333246 0.54166663 0.25 0.54166663
		 0.16666663 0.625 0.16666663 0.625 0.25 0.375 0.16666663 0.45833325 0.16666663 0.45833325
		 0.25 0.375 0.25 0.375 0 0.45833325 0 0.45833325 0.083333246 0.375 0.083333246;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 48 ".pt[0:47]" -type "float3"  -0.81044638 -1.7907292 -0.15447107 
		0.81044632 -1.7907292 -0.15447107 -0.81044638 1.7907283 -0.15447107 0.81044632 1.7907283 
		-0.15447107 -0.81044632 1.7907283 0.15447107 0.81044632 1.7907283 0.15447107 -0.81044632 
		-1.7907292 0.15447107 0.81044632 -1.7907292 0.15447107 -0.68865246 -1.6318313 -0.15447107 
		0.68865246 -1.6318313 -0.15447107 0.68865246 1.6318305 -0.15447107 -0.68865246 1.6318305 
		-0.15447107 0.68865246 -0.062397294 -0.15447107 -0.68865246 -0.062397294 -0.15447107 
		0.68865246 0.062395588 -0.15447107 -0.68865246 0.062395588 -0.15447107 -0.07527025 
		-1.7907289 -0.15447107 -0.07527025 -1.7907289 0.15447107 -0.07527025 1.7907283 0.15447107 
		-0.07527025 1.7907283 -0.15447107 -0.063958734 1.6318305 -0.15447107 -0.063958734 
		0.062395588 -0.15447107 -0.063958734 -0.062397294 -0.15447107 -0.063958734 -1.6318313 
		-0.15447107 0.075269453 -1.7907289 -0.15447107 0.075269453 -1.7907289 0.15447107 
		0.075269453 1.7907283 0.15447107 0.075269453 1.7907283 -0.15447107 0.063958004 1.6318305 
		-0.15447107 0.063957967 0.062395588 -0.15447107 0.063957967 -0.062397294 -0.15447107 
		0.063958004 -1.6318313 -0.15447107 0.063957967 -0.062397294 0.13011594 0.063958004 
		-1.6318313 0.13011594 0.68865246 -1.6318313 0.13011594 0.68865246 -0.062397294 0.13011594 
		0.063958004 1.6318305 0.13011594 0.063957967 0.062395588 0.13011594 0.68865246 0.062395588 
		0.13011594 0.68865246 1.6318305 0.13011594 -0.063958734 0.062395588 0.13011594 -0.68865246 
		0.062395588 0.13011594 -0.063958734 1.6318305 0.13011594 -0.68865246 1.6318305 0.13011594 
		-0.68865246 -1.6318313 0.13011594 -0.063958734 -1.6318313 0.13011594 -0.063958734 
		-0.062397294 0.13011594 -0.68865246 -0.062397294 0.13011594;
	setAttr -av ".pt[11].px";
	setAttr -av ".pt[11].py";
	setAttr -av ".pt[11].pz";
	setAttr -s 48 ".vt[0:47]"  -0.5 -0.50000012 0.5 0.5 -0.50000012 0.5
		 -0.5 0.49999988 0.5 0.5 0.49999988 0.5 -0.5 0.49999988 -0.5 0.5 0.49999988 -0.5 -0.5 -0.50000012 -0.5
		 0.5 -0.50000012 -0.5 -0.42485997 -0.45563328 0.5 0.42485997 -0.45563328 0.5 0.42485997 0.45563304 0.5
		 -0.42485997 0.45563304 0.5 0.42485997 -0.017422318 0.5 -0.42485997 -0.017422318 0.5
		 0.42485997 0.017421842 0.5 -0.42485997 0.017421842 0.5 -0.046437528 -0.50000006 0.5
		 -0.046437528 -0.50000006 -0.5 -0.046437528 0.49999988 -0.5 -0.046437528 0.49999988 0.5
		 -0.039458957 0.45563304 0.5 -0.039458957 0.017421842 0.5 -0.039458957 -0.017422318 0.5
		 -0.039458957 -0.45563328 0.5 0.046437036 -0.50000006 0.5 0.046437036 -0.50000006 -0.5
		 0.046437036 0.49999988 -0.5 0.046437036 0.49999988 0.5 0.039458506 0.45563304 0.5
		 0.039458483 0.017421842 0.5 0.039458483 -0.017422318 0.5 0.039458506 -0.45563328 0.5
		 0.039458483 -0.017422318 0.031919885 0.039458506 -0.45563328 0.031919885 0.42485997 -0.45563328 0.031919885
		 0.42485997 -0.017422318 0.031919885 0.039458506 0.45563304 0.031919885 0.039458483 0.017421842 0.031919885
		 0.42485997 0.017421842 0.031919885 0.42485997 0.45563304 0.031919885 -0.039458957 0.017421842 0.031919885
		 -0.42485997 0.017421842 0.031919885 -0.039458957 0.45563304 0.031919885 -0.42485997 0.45563304 0.031919885
		 -0.42485997 -0.45563328 0.031919885 -0.039458957 -0.45563328 0.031919885 -0.039458957 -0.017422318 0.031919885
		 -0.42485997 -0.017422318 0.031919885;
	setAttr -s 88 ".ed[0:87]"  0 16 0 2 19 0 4 18 0 6 17 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0 0 8 0 1 9 0 8 23 0 3 10 0 9 12 0 2 11 0 11 20 0 8 13 0
		 12 14 0 13 15 0 12 30 0 14 10 0 15 11 0 14 29 0 16 24 0 17 25 0 18 26 0 19 27 0 20 28 0
		 21 15 0 22 13 0 23 31 0 16 17 1 18 19 1 19 20 1 20 21 0 21 22 1 22 23 0 23 16 1 24 1 0
		 25 7 0 26 5 0 27 3 0 28 10 0 29 21 1 30 22 1 31 9 0 24 25 1 26 27 1 27 28 1 28 29 0
		 29 30 1 30 31 0 31 24 1 30 32 0 31 33 0 32 33 0 9 34 0 33 34 0 12 35 0 34 35 0 35 32 0
		 28 36 0 29 37 0 36 37 0 14 38 0 38 37 0 10 39 0 38 39 0 36 39 0 21 40 0 15 41 0 40 41 0
		 20 42 0 42 40 0 11 43 0 43 42 0 41 43 0 8 44 0 23 45 0 44 45 0 22 46 0 46 45 0 13 47 0
		 46 47 0 44 47 0;
	setAttr -s 41 -ch 168 ".fc[0:40]" -type "polyFaces" 
		f 4 58 60 62 63
		mu 0 4 40 41 42 43
		f 4 50 44 7 -44
		mu 0 4 34 35 3 5
		f 4 49 42 11 -42
		mu 0 4 32 33 7 9
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13
		f 4 55 41 13 -49
		mu 0 4 39 31 1 15
		f 6 5 15 -24 -21 -17 -14
		mu 0 6 1 3 16 20 18 15
		f 4 -45 51 45 -16
		mu 0 4 3 35 36 16
		f 6 -5 12 19 21 24 -18
		mu 0 6 2 0 14 19 21 17
		f 4 53 -23 20 25
		mu 0 4 37 38 18 20
		f 4 66 -69 70 -72
		mu 0 4 44 45 46 47
		f 4 3 -35 -1 -11
		mu 0 4 6 24 23 8
		f 4 1 -36 -3 -7
		mu 0 4 2 26 25 4
		f 4 -37 -2 17 18
		mu 0 4 27 26 2 17
		f 4 -75 -77 -79 -80
		mu 0 4 48 49 50 51
		f 4 -33 -39 31 -22
		mu 0 4 19 29 28 21
		f 4 82 -85 86 -88
		mu 0 4 52 53 54 55
		f 4 0 -41 -15 -13
		mu 0 4 0 22 30 14
		f 4 34 27 -50 -27
		mu 0 4 23 24 33 32
		f 4 35 29 -51 -29
		mu 0 4 25 26 35 34
		f 4 -52 -30 36 30
		mu 0 4 36 35 26 27
		f 4 37 -47 -53 -31
		mu 0 4 27 28 37 36
		f 4 38 -48 -54 46
		mu 0 4 28 29 38 37
		f 4 39 33 -55 47
		mu 0 4 29 30 39 38
		f 4 40 26 -56 -34
		mu 0 4 30 22 31 39
		f 4 54 57 -59 -57
		mu 0 4 38 39 41 40
		f 4 48 59 -61 -58
		mu 0 4 39 15 42 41
		f 4 16 61 -63 -60
		mu 0 4 15 18 43 42
		f 4 22 56 -64 -62
		mu 0 4 18 38 40 43
		f 4 52 65 -67 -65
		mu 0 4 36 37 45 44
		f 4 -26 67 68 -66
		mu 0 4 37 20 46 45
		f 4 23 69 -71 -68
		mu 0 4 20 16 47 46
		f 4 -46 64 71 -70
		mu 0 4 16 36 44 47
		f 4 -32 72 74 -74
		mu 0 4 21 28 49 48
		f 4 -38 75 76 -73
		mu 0 4 28 27 50 49
		f 4 -19 77 78 -76
		mu 0 4 27 17 51 50
		f 4 -25 73 79 -78
		mu 0 4 17 21 48 51
		f 4 14 81 -83 -81
		mu 0 4 14 30 53 52
		f 4 -40 83 84 -82
		mu 0 4 30 29 54 53
		f 4 32 85 -87 -84
		mu 0 4 29 19 55 54
		f 4 -20 80 87 -86
		mu 0 4 19 14 52 55;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode groupId -n "groupId103";
	rename -uid "4D0116A3-498A-1678-3609-5DAE075068D7";
	setAttr ".ihi" 0;
createNode shadingEngine -n "lambert3SG";
	rename -uid "CDE61583-4AA1-38E2-DA31-F19D0C0A8C18";
	setAttr ".ihi" 0;
	setAttr -s 10 ".dsm";
	setAttr ".ro" yes;
	setAttr -s 10 ".gn";
createNode materialInfo -n "materialInfo2";
	rename -uid "2AA448D8-41C9-36A6-A200-2386DEC94B62";
createNode lambert -n "frame";
	rename -uid "8524A2C0-4185-A75F-A92B-68A0B68208FA";
	setAttr ".c" -type "float3" 0.02 0.02 0.02 ;
createNode groupId -n "groupId104";
	rename -uid "1221565E-4EC4-76EA-3EEC-C385222EE189";
	setAttr ".ihi" 0;
createNode shadingEngine -n "lambert4SG";
	rename -uid "451D8C29-409A-1BA2-81A3-2E8D246918A8";
	setAttr ".ihi" 0;
	setAttr -s 8 ".dsm";
	setAttr ".ro" yes;
	setAttr -s 8 ".gn";
createNode materialInfo -n "materialInfo3";
	rename -uid "67BDAE14-4A97-A013-DB73-5AB13527918A";
createNode lambert -n "glass";
	rename -uid "4E659471-4543-FAED-B406-EB8D9E77DEBE";
createNode groupId -n "groupId105";
	rename -uid "B433AAD6-4872-97C7-1684-69B8A0C8B757";
	setAttr ".ihi" 0;
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
	setAttr -s 34 ".dsm";
	setAttr ".ro" yes;
	setAttr -s 5 ".gn";
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultRenderGlobals;
	setAttr ".ren" -type "string" "arnold";
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
select -ne :defaultHideFaceDataSet;
select -ne :ikSystem;
	setAttr -s 4 ".sol";
connectAttr "groupId103.id" "CrossWindowShape.iog.og[4].gid";
connectAttr "lambert3SG.mwc" "CrossWindowShape.iog.og[4].gco";
connectAttr "groupId104.id" "CrossWindowShape.iog.og[5].gid";
connectAttr "lambert4SG.mwc" "CrossWindowShape.iog.og[5].gco";
connectAttr "groupId105.id" "CrossWindowShape.ciog.cog[0].cgid";
connectAttr "frame.oc" "lambert3SG.ss";
connectAttr "windowtop1Shape.iog.og[1]" "lambert3SG.dsm" -na;
connectAttr "windowtop5Shape.iog.og[1]" "lambert3SG.dsm" -na;
connectAttr "windowtop7Shape.iog.og[1]" "lambert3SG.dsm" -na;
connectAttr "windowtop10Shape.iog.og[1]" "lambert3SG.dsm" -na;
connectAttr "windowtop11Shape.iog.og[1]" "lambert3SG.dsm" -na;
connectAttr "CrossWindow_Rounded_topShape.ciog.cog[1]" "lambert3SG.dsm" -na;
connectAttr "CrossWindowShape.iog.og[4]" "lambert3SG.dsm" -na;
connectAttr "CrossWindowShape.ciog.cog[0]" "lambert3SG.dsm" -na;
connectAttr "windwo_Rounded_topShape.iog.og[1]" "lambert3SG.dsm" -na;
connectAttr "CrossWindow_Rounded_topShape.iog.og[4]" "lambert3SG.dsm" -na;
connectAttr "groupId3.msg" "lambert3SG.gn" -na;
connectAttr "groupId6.msg" "lambert3SG.gn" -na;
connectAttr "groupId60.msg" "lambert3SG.gn" -na;
connectAttr "groupId81.msg" "lambert3SG.gn" -na;
connectAttr "groupId85.msg" "lambert3SG.gn" -na;
connectAttr "groupId101.msg" "lambert3SG.gn" -na;
connectAttr "groupId103.msg" "lambert3SG.gn" -na;
connectAttr "groupId105.msg" "lambert3SG.gn" -na;
connectAttr "groupId107.msg" "lambert3SG.gn" -na;
connectAttr "groupId109.msg" "lambert3SG.gn" -na;
connectAttr "lambert3SG.msg" "materialInfo2.sg";
connectAttr "frame.msg" "materialInfo2.m";
connectAttr "glass.oc" "lambert4SG.ss";
connectAttr "groupId4.msg" "lambert4SG.gn" -na;
connectAttr "groupId7.msg" "lambert4SG.gn" -na;
connectAttr "groupId61.msg" "lambert4SG.gn" -na;
connectAttr "groupId82.msg" "lambert4SG.gn" -na;
connectAttr "groupId86.msg" "lambert4SG.gn" -na;
connectAttr "groupId104.msg" "lambert4SG.gn" -na;
connectAttr "groupId108.msg" "lambert4SG.gn" -na;
connectAttr "groupId110.msg" "lambert4SG.gn" -na;
connectAttr "windowtop1Shape.iog.og[2]" "lambert4SG.dsm" -na;
connectAttr "windowtop5Shape.iog.og[2]" "lambert4SG.dsm" -na;
connectAttr "windowtop7Shape.iog.og[2]" "lambert4SG.dsm" -na;
connectAttr "windowtop10Shape.iog.og[2]" "lambert4SG.dsm" -na;
connectAttr "windowtop11Shape.iog.og[2]" "lambert4SG.dsm" -na;
connectAttr "CrossWindowShape.iog.og[5]" "lambert4SG.dsm" -na;
connectAttr "windwo_Rounded_topShape.iog.og[2]" "lambert4SG.dsm" -na;
connectAttr "CrossWindow_Rounded_topShape.iog.og[5]" "lambert4SG.dsm" -na;
connectAttr "lambert4SG.msg" "materialInfo3.sg";
connectAttr "glass.msg" "materialInfo3.m";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "lambert3SG.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "lambert4SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "lambert3SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "lambert4SG.message" ":defaultLightSet.message";
connectAttr "lambert3SG.pa" ":renderPartition.st" -na;
connectAttr "lambert4SG.pa" ":renderPartition.st" -na;
connectAttr "frame.msg" ":defaultShaderList1.s" -na;
connectAttr "glass.msg" ":defaultShaderList1.s" -na;
// End of CrossWindow.ma
