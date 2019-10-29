//Maya ASCII 2019 scene
//Name: roofFront.ma
//Last modified: Tue, Oct 29, 2019 05:58:06 PM
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
createNode transform -n "roofPieceFront3";
	rename -uid "58F43902-4665-37BB-0A83-61B74187D554";
	setAttr ".rp" -type "double3" 0 0 -0.99999999999999989 ;
	setAttr ".sp" -type "double3" 0 8.4703294725430034e-22 -0.99999999999999989 ;
createNode mesh -n "roofPieceFront3Shape" -p "roofPieceFront3";
	rename -uid "841669EA-44A5-13EB-ED1C-D38F56060034";
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
	setAttr -s 28 ".pt[0:27]" -type "float3"  8.8130655 -1.5520031e-05 
		-5.9604645e-08 8.8130655 -1.5520031e-05 -5.9604645e-08 8.8130655 -8.6392078 0.33303177 
		8.8130655 -8.6392078 0.33303177 8.8130655 -8.6392078 -5.7742e-08 8.8130655 -8.6392078 
		-5.7742e-08 8.8130655 -1.5520031e-05 -7.2643161e-08 8.8130655 -1.5520031e-05 -7.2643161e-08 
		8.8130655 -8.6392078 0.7868377 8.8130655 -8.6392078 0.7868377 8.8130655 -8.6392078 
		0.26103646 8.8130655 -8.6392078 0.26103646 8.8130655 -11.380672 0.7868377 8.8130655 
		-11.380672 0.7868377 8.8130655 -11.380672 0.26103646 8.8130655 -11.380672 0.26103646 
		8.8130655 -0.81056702 -5.9604645e-08 8.8130655 -0.81056714 -7.2643161e-08 8.8130655 
		-0.81056714 -7.2643161e-08 8.8130655 -0.81056702 -5.9604645e-08 8.8130655 -1.5400636 
		-7.2643161e-08 8.8130655 -1.5400635 0.29077852 8.8130655 -1.5400635 0.29077852 8.8130655 
		-1.5400636 -7.2643161e-08 8.8130655 -2.1966105 -7.2643161e-08 8.8130655 -2.1966102 
		0.29077852 8.8130655 -2.1966102 0.29077852 8.8130655 -2.1966105 -7.2643161e-08;
	setAttr -s 28 ".vt[0:27]"  -10 1.5258789e-05 1.0430813e-07 0 1.5258789e-05 1.0430813e-07
		 -10 10.000007629395 1.0430813e-07 0 10.000007629395 1.0430813e-07 -10 10.000007629395 -1
		 0 10.000007629395 -1 -10 1.5258789e-05 -1 0 1.5258789e-05 -1 -10 10.000007629395 0.26103666
		 0 10.000007629395 0.26103666 0 10.000007629395 -1.26103652 -10 10.000007629395 -1.26103652
		 -10 13.38222694 0.26103666 0 13.38222694 0.26103666 0 13.38222694 -1.26103652 -10 13.38222694 -1.26103652
		 0 1.000014543533 1.0430812e-07 0 1.000014662743 -1 -10 1.000014662743 -1 -10 1.000014543533 1.0430812e-07
		 0 1.90001416 -1 0 1.90001392 1.0430811e-07 -10 1.90001392 1.0430811e-07 -10 1.90001416 -1
		 0 2.71001363 -1 0 2.71001339 1.0430811e-07 -10 2.71001339 1.0430811e-07 -10 2.71001363 -1;
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
createNode transform -n "wall4" -p "roofPieceFront3";
	rename -uid "7F02A329-4C61-AF56-68F1-69B33BCA8FE6";
	setAttr ".rp" -type "double3" 8.0073257386652177 -0.42925571313916344 -0.69313913164790264 ;
	setAttr ".sp" -type "double3" 8.0073257386652177 -0.42925571313916344 -0.69313913164790264 ;
createNode mesh -n "wall4Shape" -p "|roofPieceFront3|wall4";
	rename -uid "32A0B57F-4ACA-B8DD-6E1D-2C820D4FEF4E";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.375 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 32 ".uvst[0].uvsp[0:31]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25 0.625 0.025 0.625 0.72499996 0.875 0.025000006 0.125
		 0.025000006 0.375 0.72499996 0.37499997 0.025 0.625 0.70249999 0.875 0.047500011
		 0.625 0.047499999 0.37499997 0.047499999 0.125 0.047500011 0.375 0.70249999 0.625
		 0.68224996 0.875 0.067750014 0.625 0.067749999 0.37499997 0.067749999 0.125 0.067750014
		 0.375 0.68224996;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 20 ".pt[0:19]" -type "float3"  17.44268 -0.42926887 0.19747758 
		8.0073261 -0.42926887 0.19747758 17.44268 -5.7510357 0.88554615 -13.481911 -5.7510357 
		0.88554615 17.44268 -5.7510357 0.42722148 -13.481911 -5.7510357 0.42722148 17.44268 
		-0.42926887 0.30686098 8.0073261 -0.42926887 0.30686098 8.0073261 -1.2398204 0.56219608 
		8.0073261 -1.2398205 0.30686098 17.44268 -1.2398205 0.30686098 17.44268 -1.2398204 
		0.56219608 8.0073261 -1.969317 0.30686098 8.0073261 -1.9693168 0.63384771 17.44268 
		-1.9693168 0.63384771 17.44268 -1.969317 0.30686098 8.0073261 -2.6258638 0.30686098 
		8.0073261 -2.6258636 0.63384771 17.44268 -2.6258636 0.63384771 17.44268 -2.6258638 
		0.30686098;
	setAttr -s 20 ".vt[0:19]"  -10 1.5258789e-05 -0.21912694 -4.7019774e-38 1.5258789e-05 -0.21912694
		 -10 7.18299389 5.5879354e-08 21.46555328 7.18299389 5.5879354e-08 -10 7.18299389 -1
		 21.46555328 7.18299389 -1 -10 1.5258789e-05 -1 -1.880791e-37 1.5258789e-05 -1 -4.7019774e-38 1.000014543533 -0.21912694
		 -1.880791e-37 1.000014662743 -1 -10 1.000014662743 -1 -10 1.000014543533 -0.21912694
		 -1.880791e-37 1.90001416 -1 1.4693679e-39 1.90001392 5.5879351e-08 -10 1.90001392 5.5879351e-08
		 -10 1.90001416 -1 -1.880791e-37 2.71001363 -1 1.4693679e-39 2.71001339 5.5879351e-08
		 -10 2.71001339 5.5879351e-08 -10 2.71001363 -1;
	setAttr -s 36 ".ed[0:35]"  0 1 0 2 3 0 4 5 0 6 7 0 1 8 0 2 4 0 3 5 0
		 6 0 0 7 1 0 0 11 0 5 16 0 4 19 0 8 13 0 9 7 0 10 6 0 11 14 0 8 9 1 9 10 1 10 11 1
		 11 8 1 12 9 0 13 17 0 14 18 0 15 10 0 12 13 1 13 14 1 14 15 1 15 12 1 16 12 0 17 3 0
		 18 2 0 19 15 0 16 17 1 17 18 1 18 19 1 19 16 1;
	setAttr -s 17 -ch 68 ".fc[0:16]" -type "polyFaces" 
		f 4 25 -16 19 12
		mu 0 4 22 23 19 14
		f 4 27 20 17 -24
		mu 0 4 25 20 15 18
		f 4 3 8 -1 -8
		mu 0 4 6 7 9 8
		f 4 24 -13 16 -21
		mu 0 4 21 22 14 16
		f 4 18 15 26 23
		mu 0 4 17 19 23 24
		f 4 -17 -5 -9 -14
		mu 0 4 16 14 1 10
		f 4 -18 13 -4 -15
		mu 0 4 18 15 7 6
		f 4 9 -19 14 7
		mu 0 4 0 19 17 12
		f 4 -20 -10 0 4
		mu 0 4 14 19 0 1
		f 4 32 -22 -25 -29
		mu 0 4 27 28 22 21
		f 4 33 -23 -26 21
		mu 0 4 28 29 23 22
		f 4 -27 22 34 31
		mu 0 4 24 23 29 30
		f 4 35 28 -28 -32
		mu 0 4 31 26 20 25
		f 4 -7 -30 -33 -11
		mu 0 4 11 3 28 27
		f 4 -2 -31 -34 29
		mu 0 4 3 2 29 28
		f 4 -35 30 5 11
		mu 0 4 30 29 2 13
		f 4 2 10 -36 -12
		mu 0 4 4 5 26 31;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode mesh -n "polySurfaceShape1" -p "|roofPieceFront3|wall4";
	rename -uid "843F1ADC-49F9-87C2-988F-43ADBF1CED11";
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
	setAttr -s 9 ".pt[0:8]" -type "float3"  -5 5 -0.50000012 -5 5 -0.50000012 
		-5 5 -0.50000012 -5 5 -0.50000012 -5 5 -0.50000012 -5 5 -0.50000012 -5 5 -0.50000012 
		-5 5 -0.50000012 0 0 0;
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
createNode transform -n "wall5" -p "roofPieceFront3";
	rename -uid "6241F184-4124-F1E0-D835-8785958FF42E";
	setAttr ".rp" -type "double3" 8.0073257386652177 -0.42925571313916344 -0.69313913164790264 ;
	setAttr ".sp" -type "double3" 8.0073257386652177 -0.42925571313916344 -0.69313913164790264 ;
createNode mesh -n "wall5Shape" -p "|roofPieceFront3|wall5";
	rename -uid "AB17D35E-4487-3B04-2E29-AE9316D7A14C";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 4 ".uvst[0].uvsp[0:3]" -type "float2" 0.375 0.5 0.625 0.5
		 0.625 0.68224996 0.375 0.68224996;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 7 ".pt";
	setAttr ".pt[0]" -type "float3" 17.44268 -8.3924561 0.33651933 ;
	setAttr ".pt[1]" -type "float3" 8.4030819 -8.3924561 0.33651933 ;
	setAttr ".pt[2]" -type "float3" 8.0073261 -2.6258638 0.30686098 ;
	setAttr ".pt[3]" -type "float3" 17.44268 -2.6258638 0.30686098 ;
	setAttr ".pt[11]" -type "float3" 9.5367432e-07 0 0 ;
	setAttr ".pt[14]" -type "float3" 9.5367432e-07 0 0 ;
	setAttr ".pt[18]" -type "float3" 9.5367432e-07 0 0 ;
	setAttr -s 4 ".vt[0:3]"  -9.99999905 9.82441425 -0.909298 -0.41943932 9.82441425 -0.909298
		 9.5367432e-07 2.71001363 -1 -10 2.71001363 -1;
	setAttr -s 4 ".ed[0:3]"  0 1 0 1 2 0 0 3 0 3 2 1;
	setAttr -ch 4 ".fc[0]" -type "polyFaces" 
		f 4 0 1 -4 -3
		mu 0 4 0 1 2 3;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode mesh -n "polySurfaceShape1" -p "|roofPieceFront3|wall5";
	rename -uid "BFBE95AD-4847-54C3-EACA-F2AB77BD1ADC";
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
	setAttr -s 9 ".pt[0:8]" -type "float3"  -5 5 -0.50000012 -5 5 -0.50000012 
		-5 5 -0.50000012 -5 5 -0.50000012 -5 5 -0.50000012 -5 5 -0.50000012 -5 5 -0.50000012 
		-5 5 -0.50000012 0 0 0;
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
createNode mesh -n "polySurfaceShape2" -p "|roofPieceFront3|wall5";
	rename -uid "B7D438C3-4F70-48C0-588A-D0B345370FAF";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.375 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 36 ".uvst[0].uvsp[0:35]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25 0.375 0.25 0.625 0.25 0.625 0.5 0.375 0.5 0.625 0.025
		 0.625 0.72499996 0.875 0.025000006 0.125 0.025000006 0.375 0.72499996 0.37499997
		 0.025 0.625 0.70249999 0.875 0.047500011 0.625 0.047499999 0.37499997 0.047499999
		 0.125 0.047500011 0.375 0.70249999 0.625 0.68224996 0.875 0.067750014 0.625 0.067749999
		 0.37499997 0.067749999 0.125 0.067750014 0.375 0.68224996;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 24 ".pt[0:23]" -type "float3"  0 -1.3552527e-20 -2.2351742e-08 
		-4.7019774e-38 0 -2.2351742e-08 0 0 1.1175871e-08 1.4693679e-39 0 1.1175871e-08 0 
		0 -4.4703484e-08 -1.880791e-37 0 -4.4703484e-08 0 -2.7105054e-20 -4.4703484e-08 -1.880791e-37 
		0 -4.4703484e-08 0 0 -3.7252903e-09 9.4039548e-38 0 -3.7252903e-09 0 0 -2.9802322e-08 
		0 0 -2.9802322e-08 -4.7019774e-38 0 -2.2351742e-08 -1.880791e-37 0 -4.4703484e-08 
		0 0 -4.4703484e-08 0 0 -2.2351742e-08 -1.880791e-37 0 -4.4703484e-08 1.4693679e-39 
		0 1.1175871e-08 0 0 1.1175871e-08 0 0 -4.4703484e-08 -1.880791e-37 0 -4.4703484e-08 
		1.4693679e-39 0 1.1175871e-08 0 0 1.1175871e-08 0 0 -4.4703484e-08;
	setAttr -s 24 ".vt[0:23]"  -10 1.5258789e-05 -0.21912691 0 1.5258789e-05 -0.21912691
		 -10 7.18299389 4.4703484e-08 0 7.18299389 4.4703484e-08 -10 7.18299389 -1 0 7.18299389 -1
		 -10 1.5258789e-05 -1 0 1.5258789e-05 -1 -10 7.18299389 0.57053757 0 7.18299389 0.57053757
		 0 7.18299389 -1.26103652 -10 7.18299389 -1.26103652 0 1.000014543533 -0.21912691
		 0 1.000014662743 -1 -10 1.000014662743 -1 -10 1.000014543533 -0.21912691 0 1.90001416 -1
		 0 1.90001392 4.470348e-08 -10 1.90001392 4.470348e-08 -10 1.90001416 -1 0 2.71001363 -1
		 0 2.71001339 4.470348e-08 -10 2.71001339 4.470348e-08 -10 2.71001363 -1;
	setAttr -s 42 ".ed[0:41]"  0 1 0 2 3 0 4 5 0 6 7 0 1 12 0 2 4 0 3 5 0
		 6 0 0 7 1 0 0 15 0 5 20 0 4 23 0 2 8 0 3 9 0 5 10 0 9 10 0 4 11 0 8 11 0 12 17 0
		 13 7 0 14 6 0 15 18 0 12 13 1 13 14 1 14 15 1 15 12 1 16 13 0 17 21 0 18 22 0 19 14 0
		 16 17 1 17 18 1 18 19 1 19 16 1 20 16 0 21 3 0 22 2 0 23 19 0 20 21 1 21 22 1 22 23 1
		 23 20 1;
	setAttr -s 19 -ch 76 ".fc[0:18]" -type "polyFaces" 
		f 4 31 -22 25 18
		mu 0 4 26 27 23 18
		f 4 33 26 23 -30
		mu 0 4 29 24 19 22
		f 4 3 8 -1 -8
		mu 0 4 6 7 9 8
		f 4 30 -19 22 -27
		mu 0 4 25 26 18 20
		f 4 24 21 32 29
		mu 0 4 21 23 27 28
		f 4 6 14 -16 -14
		mu 0 4 3 5 16 15
		f 4 -6 12 17 -17
		mu 0 4 4 2 14 17
		f 4 -23 -5 -9 -20
		mu 0 4 20 18 1 10
		f 4 -24 19 -4 -21
		mu 0 4 22 19 7 6
		f 4 9 -25 20 7
		mu 0 4 0 23 21 12
		f 4 -26 -10 0 4
		mu 0 4 18 23 0 1
		f 4 38 -28 -31 -35
		mu 0 4 31 32 26 25
		f 4 39 -29 -32 27
		mu 0 4 32 33 27 26
		f 4 -33 28 40 37
		mu 0 4 28 27 33 34
		f 4 41 34 -34 -38
		mu 0 4 35 30 24 29
		f 4 -7 -36 -39 -11
		mu 0 4 11 3 32 31
		f 4 -2 -37 -40 35
		mu 0 4 3 2 33 32
		f 4 -41 36 5 11
		mu 0 4 34 33 2 13
		f 4 2 10 -42 -12
		mu 0 4 4 5 30 35;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode mesh -n "polySurfaceShape4" -p "|roofPieceFront3|wall5";
	rename -uid "3D875048-4AC1-F775-6210-04A8ACB46A26";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 32 ".uvst[0].uvsp[0:31]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25 0.625 0.025 0.625 0.72499996 0.875 0.025000006 0.125
		 0.025000006 0.375 0.72499996 0.37499997 0.025 0.625 0.70249999 0.875 0.047500011
		 0.625 0.047499999 0.37499997 0.047499999 0.125 0.047500011 0.375 0.70249999 0.625
		 0.68224996 0.875 0.067750014 0.625 0.067749999 0.37499997 0.067749999 0.125 0.067750014
		 0.375 0.68224996;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 20 ".pt[0:19]" -type "float3"  0 1.3552527e-20 -0.27484709 
		0 0 -0.27484709 0 2.6414206 0.18967676 -21.884993 2.6414206 0.18967676 0 2.6414206 
		0.090702012 -21.884993 2.6414206 0.090702012 0 -2.7105054e-20 -4.4703484e-08 -1.880791e-37 
		0 -4.4703484e-08 -4.7019774e-38 0 -2.2351742e-08 -1.880791e-37 0 -4.4703484e-08 0 
		0 -4.4703484e-08 0 0 -2.2351742e-08 -1.880791e-37 0 -4.4703484e-08 1.4693679e-39 
		0 1.1175871e-08 0 0 1.1175871e-08 0 0 -4.4703484e-08 -1.880791e-37 0 -4.4703484e-08 
		1.4693679e-39 0 1.1175871e-08 0 0 1.1175871e-08 0 0 -4.4703484e-08;
	setAttr -s 20 ".vt[0:19]"  -10 1.5258789e-05 -0.21912691 0 1.5258789e-05 -0.21912691
		 -10 7.18299389 4.4703484e-08 21.46555328 7.18299389 4.4703484e-08 -10 7.18299389 -1
		 21.46555328 7.18299389 -1 -10 1.5258789e-05 -1 0 1.5258789e-05 -1 0 1.000014543533 -0.21912691
		 0 1.000014662743 -1 -10 1.000014662743 -1 -10 1.000014543533 -0.21912691 0 1.90001416 -1
		 0 1.90001392 4.470348e-08 -10 1.90001392 4.470348e-08 -10 1.90001416 -1 0 2.71001363 -1
		 0 2.71001339 4.470348e-08 -10 2.71001339 4.470348e-08 -10 2.71001363 -1;
	setAttr -s 36 ".ed[0:35]"  0 1 0 2 3 0 4 5 0 6 7 0 1 8 0 2 4 0 3 5 0
		 6 0 0 7 1 0 0 11 0 5 16 0 4 19 0 8 13 0 9 7 0 10 6 0 11 14 0 8 9 1 9 10 1 10 11 1
		 11 8 1 12 9 0 13 17 0 14 18 0 15 10 0 12 13 1 13 14 1 14 15 1 15 12 1 16 12 0 17 3 0
		 18 2 0 19 15 0 16 17 1 17 18 1 18 19 1 19 16 1;
	setAttr -s 17 -ch 68 ".fc[0:16]" -type "polyFaces" 
		f 4 25 -16 19 12
		mu 0 4 22 23 19 14
		f 4 27 20 17 -24
		mu 0 4 25 20 15 18
		f 4 3 8 -1 -8
		mu 0 4 6 7 9 8
		f 4 24 -13 16 -21
		mu 0 4 21 22 14 16
		f 4 18 15 26 23
		mu 0 4 17 19 23 24
		f 4 -17 -5 -9 -14
		mu 0 4 16 14 1 10
		f 4 -18 13 -4 -15
		mu 0 4 18 15 7 6
		f 4 9 -19 14 7
		mu 0 4 0 19 17 12
		f 4 -20 -10 0 4
		mu 0 4 14 19 0 1
		f 4 32 -22 -25 -29
		mu 0 4 27 28 22 21
		f 4 33 -23 -26 21
		mu 0 4 28 29 23 22
		f 4 -27 22 34 31
		mu 0 4 24 23 29 30
		f 4 35 28 -28 -32
		mu 0 4 31 26 20 25
		f 4 -7 -30 -33 -11
		mu 0 4 11 3 28 27
		f 4 -2 -31 -34 29
		mu 0 4 3 2 29 28
		f 4 -35 30 5 11
		mu 0 4 30 29 2 13
		f 4 2 10 -36 -12
		mu 0 4 4 5 26 31;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "wall6" -p "roofPieceFront3";
	rename -uid "787BBBF8-4954-BC38-9965-D6B41C881F99";
	setAttr ".rp" -type "double3" 3.1935907968421264 -0.42925571313916344 -0.69313913164790264 ;
	setAttr ".sp" -type "double3" 3.1935907968421264 -0.42925571313916344 -0.69313913164790264 ;
createNode mesh -n "wall6Shape" -p "|roofPieceFront3|wall6";
	rename -uid "AFB6F620-4854-D452-C2BE-9098B6130586";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.375 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 32 ".uvst[0].uvsp[0:31]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25 0.625 0.025 0.625 0.72499996 0.875 0.025000006 0.125
		 0.025000006 0.375 0.72499996 0.37499997 0.025 0.625 0.70249999 0.875 0.047500011
		 0.625 0.047499999 0.37499997 0.047499999 0.125 0.047500011 0.375 0.70249999 0.625
		 0.68224996 0.875 0.067750014 0.625 0.067749999 0.37499997 0.067749999 0.125 0.067750014
		 0.375 0.68224996;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 20 ".pt[0:19]" -type "float3"  12.628945 -0.42926887 0.19747767 
		3.1935909 -0.42926887 0.19747767 12.628945 -5.7510357 0.88554621 -18.295645 -5.7510357 
		0.88554621 12.628945 -5.7510357 0.42722136 -18.295645 -5.7510357 0.42722136 12.628945 
		-0.42926887 0.30686092 3.1935909 -0.42926887 0.30686092 3.1935909 -1.2398204 0.56219608 
		3.1935909 -1.2398205 0.30686092 12.628945 -1.2398205 0.30686092 12.628945 -1.2398204 
		0.56219608 3.1935909 -1.969317 0.30686092 3.1935909 -1.9693168 0.63384771 12.628945 
		-1.9693168 0.63384771 12.628945 -1.969317 0.30686092 3.1935909 -2.6258638 0.30686092 
		3.1935909 -2.6258636 0.63384771 12.628945 -2.6258636 0.63384771 12.628945 -2.6258638 
		0.30686092;
	setAttr -s 20 ".vt[0:19]"  -10 1.5258789e-05 -0.21912691 0 1.5258789e-05 -0.21912691
		 -10 7.18299389 4.4703484e-08 21.46555328 7.18299389 4.4703484e-08 -10 7.18299389 -1
		 21.46555328 7.18299389 -1 -10 1.5258789e-05 -1 0 1.5258789e-05 -1 0 1.000014543533 -0.21912691
		 0 1.000014662743 -1 -10 1.000014662743 -1 -10 1.000014543533 -0.21912691 0 1.90001416 -1
		 0 1.90001392 4.470348e-08 -10 1.90001392 4.470348e-08 -10 1.90001416 -1 0 2.71001363 -1
		 0 2.71001339 4.470348e-08 -10 2.71001339 4.470348e-08 -10 2.71001363 -1;
	setAttr -s 36 ".ed[0:35]"  0 1 0 2 3 0 4 5 0 6 7 0 1 8 0 2 4 0 3 5 0
		 6 0 0 7 1 0 0 11 0 5 16 0 4 19 0 8 13 0 9 7 0 10 6 0 11 14 0 8 9 1 9 10 1 10 11 1
		 11 8 1 12 9 0 13 17 0 14 18 0 15 10 0 12 13 1 13 14 1 14 15 1 15 12 1 16 12 0 17 3 0
		 18 2 0 19 15 0 16 17 1 17 18 1 18 19 1 19 16 1;
	setAttr -s 17 -ch 68 ".fc[0:16]" -type "polyFaces" 
		f 4 25 -16 19 12
		mu 0 4 22 23 19 14
		f 4 27 20 17 -24
		mu 0 4 25 20 15 18
		f 4 3 8 -1 -8
		mu 0 4 6 7 9 8
		f 4 24 -13 16 -21
		mu 0 4 21 22 14 16
		f 4 18 15 26 23
		mu 0 4 17 19 23 24
		f 4 -17 -5 -9 -14
		mu 0 4 16 14 1 10
		f 4 -18 13 -4 -15
		mu 0 4 18 15 7 6
		f 4 9 -19 14 7
		mu 0 4 0 19 17 12
		f 4 -20 -10 0 4
		mu 0 4 14 19 0 1
		f 4 32 -22 -25 -29
		mu 0 4 27 28 22 21
		f 4 33 -23 -26 21
		mu 0 4 28 29 23 22
		f 4 -27 22 34 31
		mu 0 4 24 23 29 30
		f 4 35 28 -28 -32
		mu 0 4 31 26 20 25
		f 4 -7 -30 -33 -11
		mu 0 4 11 3 28 27
		f 4 -2 -31 -34 29
		mu 0 4 3 2 29 28
		f 4 -35 30 5 11
		mu 0 4 30 29 2 13
		f 4 2 10 -36 -12
		mu 0 4 4 5 26 31;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode mesh -n "polySurfaceShape1" -p "|roofPieceFront3|wall6";
	rename -uid "47125BF9-44E9-92F8-998C-749CEF2C35A9";
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
	setAttr -s 9 ".pt[0:8]" -type "float3"  -5 5 -0.50000012 -5 5 -0.50000012 
		-5 5 -0.50000012 -5 5 -0.50000012 -5 5 -0.50000012 -5 5 -0.50000012 -5 5 -0.50000012 
		-5 5 -0.50000012 0 0 0;
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
createNode mesh -n "polySurfaceShape2" -p "|roofPieceFront3|wall6";
	rename -uid "6EAA46D7-43A0-8464-492D-209154E01325";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.375 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 36 ".uvst[0].uvsp[0:35]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25 0.375 0.25 0.625 0.25 0.625 0.5 0.375 0.5 0.625 0.025
		 0.625 0.72499996 0.875 0.025000006 0.125 0.025000006 0.375 0.72499996 0.37499997
		 0.025 0.625 0.70249999 0.875 0.047500011 0.625 0.047499999 0.37499997 0.047499999
		 0.125 0.047500011 0.375 0.70249999 0.625 0.68224996 0.875 0.067750014 0.625 0.067749999
		 0.37499997 0.067749999 0.125 0.067750014 0.375 0.68224996;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 24 ".pt[0:23]" -type "float3"  0 0 -2.2351742e-08 0 0 -2.2351742e-08 
		0 0 1.1175871e-08 0 0 1.1175871e-08 0 0 -4.4703484e-08 0 0 -4.4703484e-08 0 5.4210109e-20 
		-4.4703484e-08 0 5.4210109e-20 -4.4703484e-08 0 0 -3.7252903e-09 0 0 -3.7252903e-09 
		0 0 -2.9802322e-08 0 0 -2.9802322e-08 0 0 -2.2351742e-08 0 0 -4.4703484e-08 0 0 -4.4703484e-08 
		0 0 -2.2351742e-08 0 0 -4.4703484e-08 0 0 1.1175871e-08 0 0 1.1175871e-08 0 0 -4.4703484e-08 
		0 0 -4.4703484e-08 0 0 1.1175871e-08 0 0 1.1175871e-08 0 0 -4.4703484e-08;
	setAttr -s 24 ".vt[0:23]"  -10 1.5258789e-05 -0.21912691 0 1.5258789e-05 -0.21912691
		 -10 7.18299389 4.4703484e-08 0 7.18299389 4.4703484e-08 -10 7.18299389 -1 0 7.18299389 -1
		 -10 1.5258789e-05 -1 0 1.5258789e-05 -1 -10 7.18299389 0.57053757 0 7.18299389 0.57053757
		 0 7.18299389 -1.26103652 -10 7.18299389 -1.26103652 0 1.000014543533 -0.21912691
		 0 1.000014662743 -1 -10 1.000014662743 -1 -10 1.000014543533 -0.21912691 0 1.90001416 -1
		 0 1.90001392 4.470348e-08 -10 1.90001392 4.470348e-08 -10 1.90001416 -1 0 2.71001363 -1
		 0 2.71001339 4.470348e-08 -10 2.71001339 4.470348e-08 -10 2.71001363 -1;
	setAttr -s 42 ".ed[0:41]"  0 1 0 2 3 0 4 5 0 6 7 0 1 12 0 2 4 0 3 5 0
		 6 0 0 7 1 0 0 15 0 5 20 0 4 23 0 2 8 0 3 9 0 5 10 0 9 10 0 4 11 0 8 11 0 12 17 0
		 13 7 0 14 6 0 15 18 0 12 13 1 13 14 1 14 15 1 15 12 1 16 13 0 17 21 0 18 22 0 19 14 0
		 16 17 1 17 18 1 18 19 1 19 16 1 20 16 0 21 3 0 22 2 0 23 19 0 20 21 1 21 22 1 22 23 1
		 23 20 1;
	setAttr -s 19 -ch 76 ".fc[0:18]" -type "polyFaces" 
		f 4 31 -22 25 18
		mu 0 4 26 27 23 18
		f 4 33 26 23 -30
		mu 0 4 29 24 19 22
		f 4 3 8 -1 -8
		mu 0 4 6 7 9 8
		f 4 30 -19 22 -27
		mu 0 4 25 26 18 20
		f 4 24 21 32 29
		mu 0 4 21 23 27 28
		f 4 6 14 -16 -14
		mu 0 4 3 5 16 15
		f 4 -6 12 17 -17
		mu 0 4 4 2 14 17
		f 4 -23 -5 -9 -20
		mu 0 4 20 18 1 10
		f 4 -24 19 -4 -21
		mu 0 4 22 19 7 6
		f 4 9 -25 20 7
		mu 0 4 0 23 21 12
		f 4 -26 -10 0 4
		mu 0 4 18 23 0 1
		f 4 38 -28 -31 -35
		mu 0 4 31 32 26 25
		f 4 39 -29 -32 27
		mu 0 4 32 33 27 26
		f 4 -33 28 40 37
		mu 0 4 28 27 33 34
		f 4 41 34 -34 -38
		mu 0 4 35 30 24 29
		f 4 -7 -36 -39 -11
		mu 0 4 11 3 32 31
		f 4 -2 -37 -40 35
		mu 0 4 3 2 33 32
		f 4 -41 36 5 11
		mu 0 4 34 33 2 13
		f 4 2 10 -42 -12
		mu 0 4 4 5 30 35;
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
	setAttr -s 47 ".dsm";
	setAttr ".ro" yes;
	setAttr -s 22 ".gn";
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
connectAttr "roofPieceSide3Shape.iog" "lambert2SG.dsm" -na;
connectAttr "|wall4Shape.iog" "lambert2SG.dsm" -na;
connectAttr "|wall5Shape.iog" "lambert2SG.dsm" -na;
connectAttr "|wall6Shape.iog" "lambert2SG.dsm" -na;
connectAttr "corner8Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "corner9Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "windowPanel4Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "windowtop9Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "roofPieceFront3Shape.iog" "lambert2SG.dsm" -na;
connectAttr "|roofPieceFront3|wall4|wall4Shape.iog" "lambert2SG.dsm" -na;
connectAttr "|roofPieceFront3|wall5|wall5Shape.iog" "lambert2SG.dsm" -na;
connectAttr "|roofPieceFront3|wall6|wall6Shape.iog" "lambert2SG.dsm" -na;
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
connectAttr "groupId68.msg" "lambert2SG.gn" -na;
connectAttr "groupId69.msg" "lambert2SG.gn" -na;
connectAttr "groupId70.msg" "lambert2SG.gn" -na;
connectAttr "groupId71.msg" "lambert2SG.gn" -na;
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "lambert2SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "lambert2SG.message" ":defaultLightSet.message";
connectAttr "lambert2SG.pa" ":renderPartition.st" -na;
connectAttr "whitebrick.msg" ":defaultShaderList1.s" -na;
// End of roofFront.ma
