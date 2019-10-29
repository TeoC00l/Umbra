//Maya ASCII 2019 scene
//Name: trashcan.ma
//Last modified: Tue, Oct 29, 2019 05:48:16 PM
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
createNode transform -n "TrashCan1";
	rename -uid "6FADDD40-4F74-EE89-527E-838D127B3F8B";
	setAttr ".rp" -type "double3" 0.049515724182128906 0.66960370931720847 0 ;
	setAttr ".sp" -type "double3" 0.049515724182128906 0.66960370931720847 0 ;
createNode mesh -n "TrashCan1Shape" -p "TrashCan1";
	rename -uid "964D2256-41F1-84BF-8BB8-98828C549C0C";
	setAttr -k off ".v";
	setAttr ".iog[0].og[0].gcl" -type "componentList" 1 "f[0:60]";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 83 ".uvst[0].uvsp[0:82]" -type "float2" 0.59742022 0.03408879
		 0.46523106 0.0039175153 0.3592236 0.088455707 0.35922363 0.22404438 0.46523112 0.30858248
		 0.59742028 0.27841115 0.65625 0.15625 0.375 0.3125 0.4107143 0.3125 0.4464286 0.3125
		 0.4821429 0.3125 0.51785719 0.3125 0.55357146 0.3125 0.58928573 0.3125 0.625 0.3125
		 0.375 0.68843985 0.4107143 0.68843985 0.4464286 0.68843985 0.4821429 0.68843985 0.51785719
		 0.68843985 0.55357146 0.68843985 0.58928573 0.68843985 0.625 0.68843985 0.59742022
		 0.72158879 0.46523106 0.69141752 0.3592236 0.77595568 0.35922363 0.91154438 0.46523112
		 0.99608248 0.59742028 0.96591115 0.65625 0.84375 0.5 0.15000001 0.5 0.83749998 0.59742028
		 0.96591115 0.46523112 0.99608248 0.35922363 0.91154438 0.3592236 0.77595568 0.46523106
		 0.69141752 0.59742022 0.72158879 0.65625 0.84375 0.59742028 0.96591115 0.46523112
		 0.99608248 0.35922363 0.91154438 0.3592236 0.77595568 0.46523106 0.69141752 0.59742022
		 0.72158879 0.65625 0.84375 0.5625 0.25 0.5625 0 0.625 0 0.625 0.25 0.5625 0.5 0.625
		 0.5 0.5625 0.75 0.625 0.75 0.5625 1 0.5625 0.75 0.625 0.75 0.625 1 0.875 0 0.875
		 0.25 0.125 0 0.375 0 0.375 0.25 0.125 0.25 0.375 0.75 0.4375 0.75 0.4375 1 0.375
		 1 0.375 0.5 0.4375 0.5 0.4375 0.75 0.375 0.75 0.4375 0.25 0.4375 0 0.4375 1 0.49999994
		 0.75 0.49999994 1 0.49999994 0.5 0.49999994 0.25 0.49999994 0 0.5625 1 0.625 1 0.375
		 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 58 ".vt[0:57]"  0.69096726 -1 -0.87374479 -0.25450188 -1 -1.089542031
		 -1.012709618 -1 -0.48489189 -1.012709618 -1 0.48489177 -0.25450188 -1 1.089542031
		 0.69096726 -1 0.8737449 1.11174059 -1 0 0.82226276 1.74495518 -1.052587271 -0.31672955 1.74495518 -1.31255484
		 -1.23013067 1.74495518 -0.58414197 -1.23013067 1.74495518 0.58414185 -0.31673002 1.74495518 1.31255484
		 0.82226276 1.74495518 1.05258739 1.32916212 1.74495518 0 0 -1 0 0.91053826 1.74495518 -1.17283034
		 -0.35856795 1.74495518 -1.46249557 -1.37631249 1.74495518 -0.65087193 -1.37631249 1.74495518 0.65087181
		 -0.3585684 1.74495518 1.46249557 0.91053826 1.74495518 1.17283046 1.47534394 1.74495518 0
		 0.88871807 1.96810329 -1.14310825 -0.34822622 1.96810329 -1.4254328 -0.020803362 2.15088892 -3.38171e-09
		 -1.34017885 1.96810329 -0.63437736 -1.34017885 1.96810329 0.6343773 -0.3482267 1.96810329 1.4254328
		 0.88871807 1.96810329 1.14310837 1.4392103 1.96810329 -1.2185636e-08 -0.48891565 2.17509341 0.079014443
		 0.41755316 2.17509341 0.079014443 -0.48891565 2.28333545 0.079014443 0.41755316 2.28333545 0.079014443
		 -0.48891565 2.28333545 -0.079014443 0.41755316 2.28333545 -0.079014443 -0.48891565 2.17509341 -0.079014443
		 0.41755316 2.17509341 -0.079014443 -0.36678094 2.19934058 0.079014428 -0.36678094 2.19934058 -0.079014428
		 -0.36678094 2.30758262 -0.079014428 -0.36678094 2.30758262 0.079014428 -0.035681576 2.23096538 0.079014428
		 -0.035681576 2.23096538 -0.079014428 -0.035681576 2.33920741 -0.079014428 -0.035681576 2.33920741 0.079014428
		 0.29541823 2.19934058 0.079014428 0.29541823 2.19934058 -0.079014428 0.29541823 2.30758262 -0.079014428
		 0.29541823 2.30758262 0.079014428 0.29541823 1.99950898 0.079014428 0.29541823 1.99950898 -0.079014428
		 0.41755316 1.99950898 -0.079014443 0.41755316 1.99950898 0.079014443 -0.48891565 1.99950898 -0.079014443
		 -0.36678094 1.99950898 -0.079014428 -0.36678094 1.99950898 0.079014428 -0.48891565 1.99950898 0.079014443;
	setAttr -s 115 ".ed[0:114]"  0 1 0 1 2 0 2 3 0 3 4 0 4 5 0 5 6 0 6 0 0
		 7 8 0 8 9 0 9 10 0 10 11 0 11 12 0 12 13 0 13 7 0 0 7 0 1 8 0 2 9 0 3 10 0 4 11 0
		 5 12 0 6 13 0 14 0 1 14 1 1 14 2 1 14 3 1 14 4 1 14 5 1 14 6 1 7 15 0 8 16 0 15 16 0
		 9 17 0 16 17 0 10 18 0 17 18 0 11 19 0 18 19 0 12 20 0 19 20 0 13 21 0 20 21 0 21 15 0
		 15 22 0 16 23 0 22 23 0 23 24 1 22 24 1 17 25 0 23 25 0 25 24 1 18 26 0 25 26 0 26 24 1
		 19 27 0 26 27 0 27 24 1 20 28 0 27 28 0 28 24 1 21 29 0 28 29 0 29 24 1 29 22 0 30 38 0
		 32 41 0 34 40 0 36 39 0 30 32 0 31 33 0 32 34 0 33 35 0 34 36 0 35 37 0 36 30 0 37 31 0
		 38 42 0 39 43 0 40 44 0 41 45 0 38 39 0 39 40 1 40 41 1 41 38 1 42 46 0 43 47 0 44 48 0
		 45 49 0 42 43 1 43 44 1 44 45 1 45 42 1 46 31 0 47 37 0 48 35 0 49 33 0 46 47 0 47 48 1
		 48 49 1 49 46 1 46 50 0 47 51 0 50 51 0 37 52 0 51 52 0 31 53 0 52 53 0 50 53 0 36 54 0
		 39 55 0 54 55 0 38 56 0 56 55 0 30 57 0 57 56 0 54 57 0;
	setAttr -s 61 -ch 230 ".fc[0:60]" -type "polyFaces" 
		f 4 0 15 -8 -15
		mu 0 4 7 8 16 15
		f 4 1 16 -9 -16
		mu 0 4 8 9 17 16
		f 4 2 17 -10 -17
		mu 0 4 9 10 18 17
		f 4 3 18 -11 -18
		mu 0 4 10 11 19 18
		f 4 4 19 -12 -19
		mu 0 4 11 12 20 19
		f 4 5 20 -13 -20
		mu 0 4 12 13 21 20
		f 4 6 14 -14 -21
		mu 0 4 13 14 22 21
		f 3 -1 -22 22
		mu 0 3 1 0 30
		f 3 -2 -23 23
		mu 0 3 2 1 30
		f 3 -3 -24 24
		mu 0 3 3 2 30
		f 3 -4 -25 25
		mu 0 3 4 3 30
		f 3 -5 -26 26
		mu 0 3 5 4 30
		f 3 -6 -27 27
		mu 0 3 6 5 30
		f 3 -7 -28 21
		mu 0 3 0 6 30
		f 3 44 45 -47
		mu 0 3 39 40 31
		f 3 48 49 -46
		mu 0 3 40 41 31
		f 3 51 52 -50
		mu 0 3 41 42 31
		f 3 54 55 -53
		mu 0 3 42 43 31
		f 3 57 58 -56
		mu 0 3 43 44 31
		f 3 60 61 -59
		mu 0 3 44 45 31
		f 3 62 46 -62
		mu 0 3 45 39 31
		f 4 7 29 -31 -29
		mu 0 4 28 27 33 32
		f 4 8 31 -33 -30
		mu 0 4 27 26 34 33
		f 4 9 33 -35 -32
		mu 0 4 26 25 35 34
		f 4 10 35 -37 -34
		mu 0 4 25 24 36 35
		f 4 11 37 -39 -36
		mu 0 4 24 23 37 36
		f 4 12 39 -41 -38
		mu 0 4 23 29 38 37
		f 4 13 28 -42 -40
		mu 0 4 29 28 32 38
		f 4 30 43 -45 -43
		mu 0 4 32 33 40 39
		f 4 32 47 -49 -44
		mu 0 4 33 34 41 40
		f 4 34 50 -52 -48
		mu 0 4 34 35 42 41
		f 4 36 53 -55 -51
		mu 0 4 35 36 43 42
		f 4 38 56 -58 -54
		mu 0 4 36 37 44 43
		f 4 40 59 -61 -57
		mu 0 4 37 38 45 44
		f 4 41 42 -63 -60
		mu 0 4 38 32 39 45
		f 4 98 91 68 -95
		mu 0 4 46 47 48 49
		f 4 97 94 70 -94
		mu 0 4 50 46 49 51
		f 4 96 93 72 -93
		mu 0 4 52 50 51 53
		f 4 101 103 105 -107
		mu 0 4 54 55 56 57
		f 4 -75 -73 -71 -69
		mu 0 4 48 58 59 49
		f 4 73 67 69 71
		mu 0 4 60 61 62 63
		f 4 109 -112 -114 -115
		mu 0 4 64 65 66 67
		f 4 65 -81 -67 -72
		mu 0 4 68 69 70 71
		f 4 64 -82 -66 -70
		mu 0 4 62 72 69 68
		f 4 63 -83 -65 -68
		mu 0 4 61 73 72 62
		f 4 79 76 -88 -76
		mu 0 4 74 70 75 76
		f 4 80 77 -89 -77
		mu 0 4 70 69 77 75
		f 4 81 78 -90 -78
		mu 0 4 69 72 78 77
		f 4 82 75 -91 -79
		mu 0 4 72 73 79 78
		f 4 87 84 -96 -84
		mu 0 4 76 75 52 80
		f 4 88 85 -97 -85
		mu 0 4 75 77 50 52
		f 4 89 86 -98 -86
		mu 0 4 77 78 46 50
		f 4 90 83 -99 -87
		mu 0 4 78 79 47 46
		f 4 95 100 -102 -100
		mu 0 4 80 52 55 54
		f 4 92 102 -104 -101
		mu 0 4 52 53 56 55
		f 4 74 104 -106 -103
		mu 0 4 53 81 57 56
		f 4 -92 99 106 -105
		mu 0 4 81 80 54 57
		f 4 66 108 -110 -108
		mu 0 4 71 70 65 64
		f 4 -80 110 111 -109
		mu 0 4 70 74 66 65
		f 4 -64 112 113 -111
		mu 0 4 74 82 67 66
		f 4 -74 107 114 -113
		mu 0 4 82 71 64 67;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode groupId -n "groupId74";
	rename -uid "0B88EB54-49FE-A1A9-8A10-CE8A1C2CF5F6";
	setAttr ".ihi" 0;
createNode shadingEngine -n "metal1";
	rename -uid "8C7F3E49-43CA-B7C0-F797-1886E3B6A781";
	setAttr ".ihi" 0;
	setAttr -s 8 ".dsm";
	setAttr ".ro" yes;
	setAttr -s 3 ".gn";
createNode materialInfo -n "materialInfo5";
	rename -uid "CF5B863C-4C65-FC32-D76F-5E995A7EB0DD";
createNode lambert -n "metal2";
	rename -uid "CCB0734E-404E-0CDD-C0AA-FB8846BCBAE9";
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
connectAttr "groupId74.id" "TrashCan1Shape.iog.og[0].gid";
connectAttr "metal1.mwc" "TrashCan1Shape.iog.og[0].gco";
connectAttr "metal2.oc" "metal1.ss";
connectAttr "pCubeShape10.iog" "metal1.dsm" -na;
connectAttr "pCubeShape15.iog" "metal1.dsm" -na;
connectAttr "pCubeShape16.iog" "metal1.dsm" -na;
connectAttr "pCubeShape17.iog" "metal1.dsm" -na;
connectAttr "pCubeShape18.iog" "metal1.dsm" -na;
connectAttr "pCube26Shape.iog.og[0]" "metal1.dsm" -na;
connectAttr "starless_fireShape.iog.og[0]" "metal1.dsm" -na;
connectAttr "TrashCan1Shape.iog.og[0]" "metal1.dsm" -na;
connectAttr "groupId22.msg" "metal1.gn" -na;
connectAttr "groupId25.msg" "metal1.gn" -na;
connectAttr "groupId74.msg" "metal1.gn" -na;
connectAttr "metal1.msg" "materialInfo5.sg";
connectAttr "metal2.msg" "materialInfo5.m";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "metal1.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "metal1.message" ":defaultLightSet.message";
connectAttr "metal1.pa" ":renderPartition.st" -na;
connectAttr "metal2.msg" ":defaultShaderList1.s" -na;
// End of trashcan.ma
