//Maya ASCII 2019 scene
//Name: sign2.ma
//Last modified: Fri, Nov 01, 2019 12:57:25 AM
//Codeset: 1252
requires maya "2019";
requires -nodeType "type" -nodeType "shellDeformer" -nodeType "vectorAdjust" -nodeType "typeExtrude"
		 "Type" "2.0a";
requires "mtoa" "3.1.2";
requires "stereoCamera" "10.0";
requires "mtoa" "3.1.2";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2019";
fileInfo "version" "2019";
fileInfo "cutIdentifier" "201812112215-434d8d9c04";
fileInfo "osv" "Microsoft Windows 7 Home Premium Edition, 64-bit Windows 7 Service Pack 1 (Build 7601)\n";
fileInfo "license" "student";
createNode transform -n "typeMesh1";
	rename -uid "0AF79476-4F59-900F-DFB1-66BFDE145852";
	setAttr ".t" -type "double3" -13 0 0 ;
	setAttr ".s" -type "double3" 0.27450391592785506 0.27450391592785506 0.27450391592785506 ;
createNode mesh -n "typeMeshShape1" -p "typeMesh1";
	rename -uid "9F0FA3C6-4FBE-F309-6A72-69BB6BDAD2B0";
	setAttr -k off ".v";
	setAttr -s 6 ".iog[0].og";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.50000002246815711 0.48919664736604318 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode shellDeformer -n "shellDeformer1";
	rename -uid "D0EF084F-4171-5D94-7099-F5AE4102C042";
	addAttr -s false -ci true -h true -sn "typeMessage" -ln "typeMessage" -at "message";
	setAttr ".positionInPP" -type "vectorArray" 0 ;
	setAttr ".scaleInPP" -type "vectorArray" 0 ;
	setAttr ".rotationInPP" -type "vectorArray" 0 ;
createNode objectSet -n "shellDeformer1Set";
	rename -uid "0DECCE8C-45A2-7D9A-8D9D-3B85DE6E2863";
	setAttr ".ihi" 0;
	setAttr ".vo" yes;
createNode groupId -n "shellDeformer1GroupId";
	rename -uid "D62DED5A-4045-2F7D-0895-C8AAA3EB0E87";
	setAttr ".ihi" 0;
createNode groupParts -n "shellDeformer1GroupParts";
	rename -uid "EB99B089-4287-5E09-7E47-5888ADDFAF3F";
	setAttr ".ihi" 0;
	setAttr ".ic" -type "componentList" 1 "vtx[*]";
createNode polyAutoProj -n "polyAutoProj1";
	rename -uid "66A68287-4BF7-798E-B1F6-64B363A188B4";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "f[*]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1;
	setAttr ".ps" 0.20000000298023224;
	setAttr ".dl" yes;
createNode polyRemesh -n "polyRemesh1";
	rename -uid "33D23146-4855-1D76-ACE7-9B93B2FCB2AE";
	addAttr -s false -ci true -h true -sn "typeMessage" -ln "typeMessage" -at "message";
	setAttr ".nds" 1;
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1;
	setAttr ".tsb" no;
	setAttr ".ipt" 0;
createNode polySoftEdge -n "polySoftEdge1";
	rename -uid "6FA91634-4A2F-7EED-2D84-0AA95F6DEF38";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[*]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1;
createNode vectorAdjust -n "vectorAdjust1";
	rename -uid "B32A2636-41E1-8F34-2DAA-0F89B4C69311";
	setAttr ".extrudeDistanceScalePP" -type "doubleArray" 0 ;
	setAttr ".boundingBoxes" -type "vectorArray" 28 -0.12803278863430023 -0.12000001221895218
		 0 -0.12803278861564957 -0.12000001220756971 2.4999999999999998e-12 18.476720809936523
		 -4.0662298202514648 0 18.476720809947224 -4.0662298202419551 2.4999999999999998e-12 29.13245964050293
		 0 0 29.132459640512646 7.9324588775634768e-12 2.4999999999999998e-12 38.492294311523438
		 0 0 38.492294311530912 8.6529512405395512e-12 2.4999999999999998e-12 45.621639251708984
		 0 0 45.621639251719323 5.4431152343749997e-12 2.4999999999999998e-12 55.773605346679688
		 0 0 55.773605346689187 7.3962297439575197e-12 2.4999999999999998e-12 65.150001525878906
		 0 0 65.150001525885102 1.0638033866882324e-11 2.4999999999999998e-12 70.943275451660156
		 -0.12803278863430023 0 70.943275451674154 -0.12803278862872908 2.4999999999999998e-12 80.787704467773438
		 0 0 80.787704467784096 5.4431152343749997e-12 2.4999999999999998e-12 91.427543640136719
		 0 0 91.427543640146439 7.9324588775634768e-12 2.4999999999999998e-12 0.5442623496055603
		 -20.440164566040039 0 0.54426234962300224 -20.440164566028336 2.4999999999999998e-12 15.265573501586914
		 -20 0 15.265573501598336 -19.99999999999033 2.4999999999999998e-12 26.353115081787109
		 -20.128032684326172 0 26.3531150818011 -20.128032684320601 2.4999999999999998e-12 34.668689727783203
		 -23.081640243530273 0 34.66868972779524 -23.081640243519811 2.4999999999999998e-12 ;
createNode objectSet -n "vectorAdjust1Set";
	rename -uid "65C98C8C-43A5-3386-CD40-9BA40327BBFA";
	setAttr ".ihi" 0;
	setAttr ".vo" yes;
createNode groupId -n "vectorAdjust1GroupId";
	rename -uid "D0E6F5A5-492F-50A9-47BB-25BD36245646";
	setAttr ".ihi" 0;
createNode groupParts -n "vectorAdjust1GroupParts";
	rename -uid "7D151181-4AC9-FFCA-934A-F7B1E4F0BE32";
	setAttr ".ihi" 0;
	setAttr ".ic" -type "componentList" 1 "vtx[*]";
createNode tweak -n "tweak1";
	rename -uid "CBFCD841-47B2-3275-E020-A3A501257E6D";
createNode objectSet -n "tweakSet1";
	rename -uid "1D675034-4644-8A1E-F5D2-D19957E95747";
	setAttr ".ihi" 0;
	setAttr ".vo" yes;
createNode groupId -n "groupId191";
	rename -uid "C2898653-46F0-E3C1-DACF-BE83291DC665";
	setAttr ".ihi" 0;
createNode groupParts -n "groupParts2";
	rename -uid "C53493F2-402C-0A84-D8BE-39B3917AD7E6";
	setAttr ".ihi" 0;
	setAttr ".ic" -type "componentList" 1 "vtx[*]";
createNode typeExtrude -n "typeExtrude1";
	rename -uid "2D6EBF7B-4CE3-6C4B-107D-78B6593616D5";
	addAttr -s false -ci true -h true -sn "typeMessage" -ln "typeMessage" -at "message";
	setAttr ".exdv" 1;
	setAttr -s 4 ".exc[0:3]"  0 0.5 0.333 0.5 0.66600001 0.5 1 0.5;
	setAttr -s 4 ".fbc[0:3]"  0 1 0.5 1 1 0.5 1 0;
	setAttr -s 4 ".bbc[0:3]"  0 1 0.5 1 1 0.5 1 0;
	setAttr -s 14 ".charGroupId";
	setAttr ".capComponents" -type "componentList" 16 "f[0]" "f[57:58]" "f[96:97]" "f[136:137]" "f[160:161]" "f[189:190]" "f[220:221]" "f[235:236]" "f[253:254]" "f[286:287]" "f[312:313]" "f[352:353]" "f[408:409]" "f[436:437]" "f[469:470]" "f[502]";
	setAttr ".bevelComponents" -type "componentList" 0;
	setAttr ".extrusionComponents" -type "componentList" 15 "f[1:56]" "f[59:95]" "f[98:135]" "f[138:159]" "f[162:188]" "f[191:219]" "f[222:234]" "f[237:252]" "f[255:285]" "f[288:311]" "f[314:351]" "f[354:407]" "f[410:435]" "f[438:468]" "f[471:501]";
createNode type -n "type1";
	rename -uid "02414020-41B7-3017-660F-4BBF66098712";
	setAttr ".solidsPerCharacter" -type "doubleArray" 14 1 1 1 1 1 1 2 1 1 1 1 1
		 1 1 ;
	setAttr ".solidsPerWord" -type "doubleArray" 2 11 4 ;
	setAttr ".solidsPerLine" -type "doubleArray" 2 11 4 ;
	setAttr ".vertsPerChar" -type "doubleArray" 14 56 93 131 153 180 209 238 269
		 293 331 385 411 442 473 ;
	setAttr ".characterBoundingBoxesMax" -type "vectorArray" 14 18.52262403144211
		 11.262459676773821 0 29.17868942510886 5.443115234375 0 38.849836255683272 7.9324590964395485
		 0 45.968524745253262 8.6529509747614615 0 55.96327922383292 5.443115234375 0 65.274918352971312
		 7.3962296032514727 0 71.345409956134731 10.638033757444287 0 84.935246451956317 5.443115234375
		 0 91.441640384861671 5.443115234375 0 101.14491822289638 7.9324590964395485 0 17.986230068519465
		 -8.7375403232261775 0 26.687869712954662 -10.330491613169185 0 40.345082517530095
		 -14.556884765624998 0 46.707541669001344 -12.619835900478675 0 ;
	setAttr ".characterBoundingBoxesMin" -type "vectorArray" 14 -0.12803278985570687
		 -0.12000000867687287 0 18.47672130729331 -4.0662296482774076 0 29.132459012211346
		 0 0 38.492295077589688 0 0 45.621639333787506 0 0 55.773606554406584 0 0 65.149999993746391
		 0 0 70.943278680082216 -0.12803278985570687 0 80.787704916762522 0 0 91.42754097942445
		 0 0 0.54426232322317647 -20.440163964130839 0 15.265573751730996 -20 0 26.353114745655997
		 -20.128032789855705 0 34.668688383258754 -23.081639399293991 0 ;
	setAttr ".manipulatorPivots" -type "vectorArray" 14 -0.12803278985570687 -0.12000000867687287
		 0 18.47672130729331 -4.0662296482774076 0 29.132459012211346 0 0 38.492295077589688
		 0 0 45.621639333787506 0 0 55.773606554406584 0 0 65.149999993746391 0 0 70.943278680082216
		 -0.12803278985570687 0 80.787704916762522 0 0 91.42754097942445 0 0 0.54426232322317647
		 -20.440163964130839 0 15.265573751730996 -20 0 26.353114745655997 -20.128032789855705
		 0 34.668688383258754 -23.081639399293991 0 ;
	setAttr ".holeInfo" -type "Int32Array" 9 1 7 86 8 9
		 260 13 9 433 ;
	setAttr ".numberOfShells" 15;
	setAttr ".textInput" -type "string" "4D 79 73 74 65 72 69 6F 75 73 0A 53 68 6F 70";
	setAttr ".currentFont" -type "string" "Magneto";
	setAttr ".currentStyle" -type "string" "Regular";
	setAttr ".manipulatorPositionsPP" -type "vectorArray" 44 0 0 0 0 0 0 0 0 0 0
		 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0
		 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0
		 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 ;
	setAttr ".manipulatorWordPositionsPP" -type "vectorArray" 2 0 0 0 0 0 0 ;
	setAttr ".manipulatorLinePositionsPP" -type "vectorArray" 2 0 0 0 0 0 0 ;
	setAttr ".manipulatorRotationsPP" -type "vectorArray" 44 0 0 0 0 0 0 0 0 0 0
		 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0
		 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0
		 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 ;
	setAttr ".manipulatorWordRotationsPP" -type "vectorArray" 2 0 0 0 0 0 0 ;
	setAttr ".manipulatorLineRotationsPP" -type "vectorArray" 2 0 0 0 0 0 0 ;
	setAttr ".manipulatorScalesPP" -type "vectorArray" 44 0 0 0 0 0 0 0 0 0 0 0 0 0
		 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0
		 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0
		 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 ;
	setAttr ".manipulatorWordScalesPP" -type "vectorArray" 2 0 0 0 0 0 0 ;
	setAttr ".manipulatorLineScalesPP" -type "vectorArray" 2 0 0 0 0 0 0 ;
	setAttr ".alignmentAdjustments" -type "doubleArray" 2 0 0 ;
	setAttr ".manipulatorMode" 0;
	setAttr ".curveResolution" 2;
createNode groupId -n "groupid1";
	rename -uid "AA61FC59-4339-0357-9FE8-FCB37A716D72";
createNode groupId -n "groupid2";
	rename -uid "6BDD0434-444F-54A6-9B14-B09C4CF674F7";
createNode groupId -n "groupid3";
	rename -uid "2E8E6843-41AA-79CC-0BE1-E09A22E4EED1";
createNode groupId -n "groupId192";
	rename -uid "3E83D093-45CC-F666-BEEC-62A22583F87B";
createNode groupId -n "groupId193";
	rename -uid "0C0808D2-4B72-8CA2-8D46-B6B8EB0A58A5";
createNode groupId -n "groupId194";
	rename -uid "1D16039A-49EC-A269-4C72-9CADD32E4F61";
createNode groupId -n "groupId195";
	rename -uid "E39147C9-4FB4-2203-6904-A19D6F653985";
createNode groupId -n "groupId196";
	rename -uid "6FDB8F5D-4B1B-98E8-33B2-E5B83BF49F70";
createNode groupId -n "groupId197";
	rename -uid "B496E8FB-40D6-4DDE-9280-E9B160581EB6";
createNode groupId -n "groupId198";
	rename -uid "0BBA458F-413D-DEEC-3D68-AAA5E26B7E12";
createNode groupId -n "groupId199";
	rename -uid "66505F65-4F48-BA7E-D26D-40972518C3A3";
createNode groupId -n "groupId200";
	rename -uid "A16A5A20-4239-7002-C499-6492D28D5FCC";
createNode groupId -n "groupId201";
	rename -uid "C2B255ED-445B-FD22-C4FC-41A8E4B8FBEF";
createNode groupId -n "groupId202";
	rename -uid "DFC716F4-4878-7CD5-A5AA-1E89C4D628BD";
createNode groupId -n "groupId203";
	rename -uid "D6ACEF71-4777-747F-95C4-738DE654B4CF";
createNode groupId -n "groupId204";
	rename -uid "4063E02D-4EE7-1520-01F2-C58C920F107E";
createNode groupId -n "groupId205";
	rename -uid "ABBA7DDB-4019-ADDF-5810-E5B53BCFF487";
createNode materialInfo -n "materialInfo10";
	rename -uid "C99F0CD6-4523-0B1E-3AA3-809514C61B80";
createNode shadingEngine -n "typeBlinn1SG";
	rename -uid "C8B2E20B-45DD-9F2A-34C2-D7AE3578694D";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode blinn -n "typeBlinn1";
	rename -uid "029780AB-451B-436D-E19B-9AA1A353DDD9";
	setAttr ".c" -type "float3" 1 1 1 ;
createNode lightLinker -s -n "lightLinker1";
	rename -uid "5C8618AE-4BD3-A58B-8951-ADBA6DD1DBAC";
	setAttr -s 12 ".lnk";
	setAttr -s 12 ".slnk";
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
	setAttr -s 12 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 14 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderUtilityList1;
select -ne :defaultRenderingList1;
select -ne :defaultTextureList1;
select -ne :lambert1;
	setAttr ".c" -type "float3" 0.5 0.141 0.141 ;
select -ne :initialShadingGroup;
	setAttr -s 39 ".dsm";
	setAttr ".ro" yes;
	setAttr -s 6 ".gn";
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
	setAttr -s 2 ".dnsm";
select -ne :ikSystem;
	setAttr -s 4 ".sol";
connectAttr "shellDeformer1.og[0]" "typeMeshShape1.i";
connectAttr "vectorAdjust1GroupId.id" "typeMeshShape1.iog.og[0].gid";
connectAttr "vectorAdjust1Set.mwc" "typeMeshShape1.iog.og[0].gco";
connectAttr "groupId191.id" "typeMeshShape1.iog.og[1].gid";
connectAttr "tweakSet1.mwc" "typeMeshShape1.iog.og[1].gco";
connectAttr "shellDeformer1GroupId.id" "typeMeshShape1.iog.og[2].gid";
connectAttr "shellDeformer1Set.mwc" "typeMeshShape1.iog.og[2].gco";
connectAttr "shellDeformer1GroupParts.og" "shellDeformer1.ip[0].ig";
connectAttr "shellDeformer1GroupId.id" "shellDeformer1.ip[0].gi";
connectAttr "type1.vertsPerChar" "shellDeformer1.vertsPerChar";
connectAttr ":time1.o" "shellDeformer1.ti";
connectAttr "type1.grouping" "shellDeformer1.grouping";
connectAttr "type1.animationMessage" "shellDeformer1.typeMessage";
connectAttr "typeExtrude1.vertexGroupIds" "shellDeformer1.vertexGroupIds";
connectAttr "shellDeformer1GroupId.msg" "shellDeformer1Set.gn" -na;
connectAttr "typeMeshShape1.iog.og[2]" "shellDeformer1Set.dsm" -na;
connectAttr "shellDeformer1.msg" "shellDeformer1Set.ub[0]";
connectAttr "polyAutoProj1.out" "shellDeformer1GroupParts.ig";
connectAttr "shellDeformer1GroupId.id" "shellDeformer1GroupParts.gi";
connectAttr "polyRemesh1.out" "polyAutoProj1.ip";
connectAttr "typeMeshShape1.wm" "polyAutoProj1.mp";
connectAttr "polySoftEdge1.out" "polyRemesh1.ip";
connectAttr "typeMeshShape1.wm" "polyRemesh1.mp";
connectAttr "type1.remeshMessage" "polyRemesh1.typeMessage";
connectAttr "typeExtrude1.capComponents" "polyRemesh1.ics";
connectAttr "vectorAdjust1.og[0]" "polySoftEdge1.ip";
connectAttr "typeMeshShape1.wm" "polySoftEdge1.mp";
connectAttr "vectorAdjust1GroupParts.og" "vectorAdjust1.ip[0].ig";
connectAttr "vectorAdjust1GroupId.id" "vectorAdjust1.ip[0].gi";
connectAttr "type1.grouping" "vectorAdjust1.grouping";
connectAttr "type1.manipulatorTransforms" "vectorAdjust1.manipulatorTransforms";
connectAttr "type1.alignmentMode" "vectorAdjust1.alignmentMode";
connectAttr "type1.vertsPerChar" "vectorAdjust1.vertsPerChar";
connectAttr "typeExtrude1.vertexGroupIds" "vectorAdjust1.vertexGroupIds";
connectAttr "vectorAdjust1GroupId.msg" "vectorAdjust1Set.gn" -na;
connectAttr "typeMeshShape1.iog.og[0]" "vectorAdjust1Set.dsm" -na;
connectAttr "vectorAdjust1.msg" "vectorAdjust1Set.ub[0]";
connectAttr "tweak1.og[0]" "vectorAdjust1GroupParts.ig";
connectAttr "vectorAdjust1GroupId.id" "vectorAdjust1GroupParts.gi";
connectAttr "groupParts2.og" "tweak1.ip[0].ig";
connectAttr "groupId191.id" "tweak1.ip[0].gi";
connectAttr "groupId191.msg" "tweakSet1.gn" -na;
connectAttr "typeMeshShape1.iog.og[1]" "tweakSet1.dsm" -na;
connectAttr "tweak1.msg" "tweakSet1.ub[0]";
connectAttr "typeExtrude1.out" "groupParts2.ig";
connectAttr "groupId191.id" "groupParts2.gi";
connectAttr "type1.vertsPerChar" "typeExtrude1.vertsPerChar";
connectAttr "groupid1.id" "typeExtrude1.cid";
connectAttr "groupid2.id" "typeExtrude1.bid";
connectAttr "groupid3.id" "typeExtrude1.eid";
connectAttr "type1.outputMesh" "typeExtrude1.in";
connectAttr "type1.extrudeMessage" "typeExtrude1.typeMessage";
connectAttr "groupId192.id" "typeExtrude1.charGroupId" -na;
connectAttr "groupId193.id" "typeExtrude1.charGroupId" -na;
connectAttr "groupId194.id" "typeExtrude1.charGroupId" -na;
connectAttr "groupId195.id" "typeExtrude1.charGroupId" -na;
connectAttr "groupId196.id" "typeExtrude1.charGroupId" -na;
connectAttr "groupId197.id" "typeExtrude1.charGroupId" -na;
connectAttr "groupId198.id" "typeExtrude1.charGroupId" -na;
connectAttr "groupId199.id" "typeExtrude1.charGroupId" -na;
connectAttr "groupId200.id" "typeExtrude1.charGroupId" -na;
connectAttr "groupId201.id" "typeExtrude1.charGroupId" -na;
connectAttr "groupId202.id" "typeExtrude1.charGroupId" -na;
connectAttr "groupId203.id" "typeExtrude1.charGroupId" -na;
connectAttr "groupId204.id" "typeExtrude1.charGroupId" -na;
connectAttr "groupId205.id" "typeExtrude1.charGroupId" -na;
connectAttr "typeMesh1.msg" "type1.transformMessage";
connectAttr "typeBlinn1SG.msg" "materialInfo10.sg";
connectAttr "typeBlinn1.msg" "materialInfo10.m";
connectAttr "typeBlinn1.oc" "typeBlinn1SG.ss";
connectAttr "typeMeshShape1.iog" "typeBlinn1SG.dsm" -na;
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "typeBlinn1SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "typeBlinn1SG.message" ":defaultLightSet.message";
connectAttr "typeBlinn1SG.pa" ":renderPartition.st" -na;
connectAttr "typeBlinn1.msg" ":defaultShaderList1.s" -na;
// End of sign2.ma
