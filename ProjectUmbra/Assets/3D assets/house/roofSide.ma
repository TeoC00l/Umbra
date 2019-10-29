//Maya ASCII 2019 scene
//Name: roofSide.ma
//Last modified: Tue, Oct 29, 2019 06:01:25 PM
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
createNode transform -n "roofPieceSide4";
	rename -uid "053279FE-4EAF-6792-97E1-67B7326A6D8E";
	setAttr ".rp" -type "double3" -5.5511151231257827e-17 0 0 ;
	setAttr ".sp" -type "double3" -5.5511151231257827e-17 0 0 ;
createNode mesh -n "roofPieceSide4Shape" -p "roofPieceSide4";
	rename -uid "19631A6A-4910-7261-2C33-5FACDC5DD988";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.375 ;
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
	setAttr -s 28 ".pt[0:27]" -type "float3"  10 -1.5520031e-05 4.9173832e-07 
		0 -1.5520031e-05 -10 10.67055 -8.6392078 4.7683716e-07 0.67055082 -8.6392078 -10 
		9 -8.6392078 1.0000005 -1 -8.6392078 -9 9 -1.5520031e-05 1.0000005 -1 -1.5520031e-05 
		-9 11.047874 -8.6392078 -0.26103598 1.0478742 -8.6392078 -10.261037 -1 -8.6392078 
		-8.7389631 9 -8.6392078 1.2610371 11.047874 -11.380672 -0.26103598 1.0478742 -11.380672 
		-10.261037 -1 -11.380672 -8.7389631 9 -11.380672 1.2610371 0 -0.81056702 -10 -1 -0.81056714 
		-9 9 -0.81056714 1.0000005 10 -0.81056702 4.9173832e-07 -1 -1.5400636 -9 0.29077852 
		-1.5400635 -10 10.290778 -1.5400635 4.8804441e-07 9 -1.5400636 1.0000005 -1 -2.1966105 
		-9 0.29077852 -2.1966102 -10 10.290778 -2.1966102 4.8804441e-07 9 -2.1966105 1.0000005;
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
createNode mesh -n "polySurfaceShape1" -p "roofPieceSide4";
	rename -uid "E374E3B2-4994-3D54-4EEB-A483303F2B54";
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
	setAttr -s 9 ".pt[0:8]" -type "float3"  -5 5 -0.5 -5 5 -0.5 -5 5 
		-0.5 -5 5 -0.5 -5 5 -0.5 -5 5 -0.5 -5 5 -0.5 -5 5 -0.5 0 0 0;
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
createNode transform -n "wall4" -p "roofPieceSide4";
	rename -uid "3610C41F-44CC-5466-E876-798A93800F7A";
	setAttr ".rp" -type "double3" -0.69313913609019107 -0.42925571313914457 -8.0073255039404927 ;
	setAttr ".sp" -type "double3" -0.69313913609019107 -0.42925571313914457 -8.0073255039404927 ;
createNode mesh -n "wall4Shape" -p "|roofPieceSide4|wall4";
	rename -uid "93FBB400-4D70-2ADE-C578-B4B62C831529";
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
	setAttr -s 20 ".pt[0:19]" -type "float3"  9.9783506 -0.42926887 -7.2235532 
		-0.021649335 -0.42926887 -7.7881985 10.885546 -5.7510357 -7.4426804 -20.580008 -5.7510357 
		-7.9836431 9.4272213 -5.7510357 -6.4426804 -22.038332 -5.7510357 -6.9836426 9.3068609 
		-0.42926887 -6.4426804 -0.69313902 -0.42926887 -7.0073256 0.34306917 -1.2398204 -7.7881985 
		-0.69313902 -1.2398205 -7.0073256 9.3068609 -1.2398205 -6.4426804 10.343069 -1.2398204 
		-7.2235537 -0.69313902 -1.969317 -7.0073256 0.63384771 -1.9693168 -8.0073252 10.633848 
		-1.9693168 -7.4426804 9.3068609 -1.969317 -6.4426804 -0.69313902 -2.6258638 -7.0073256 
		0.63384771 -2.6258636 -8.0073252 10.633848 -2.6258636 -7.4426804 9.3068609 -2.6258638 
		-6.4426804;
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
createNode mesh -n "polySurfaceShape1" -p "|roofPieceSide4|wall4";
	rename -uid "66742703-494C-07D0-3628-8EA66C52B855";
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
	setAttr -s 9 ".pt[0:8]" -type "float3"  -5 5 -0.5 -5 5 -0.5 -5 5 
		-0.5 -5 5 -0.5 -5 5 -0.5 -5 5 -0.5 -5 5 -0.5 -5 5 -0.5 0 0 0;
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
createNode mesh -n "polySurfaceShape2" -p "|roofPieceSide4|wall4";
	rename -uid "BB4D0D5E-4C96-5747-5D35-E1AA4AA1AAE5";
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
createNode transform -n "wall5" -p "roofPieceSide4";
	rename -uid "26980213-4904-8E44-85A0-5DB0916D9B28";
	setAttr ".rp" -type "double3" -0.69313913609019107 -0.42925571313914457 -8.0073255039404927 ;
	setAttr ".sp" -type "double3" -0.69313913609019107 -0.42925571313914457 -8.0073255039404927 ;
createNode mesh -n "wall5Shape" -p "|roofPieceSide4|wall5";
	rename -uid "0D4F2C2B-4B6A-1725-3711-80B90570D19C";
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
	setAttr -s 20 ".pt[0:19]" -type "float3"  9.9783506 -0.42926887 -7.2235532 
		-0.021649335 -0.42926887 -7.7881985 10.885546 -5.7510357 -7.4426804 -20.580008 -5.7510357 
		-7.9836421 9.4272213 -5.7510357 -6.4426804 -22.038332 -5.7510357 -6.9836421 9.3068609 
		-0.42926887 -6.4426804 -0.69313902 -0.42926887 -7.0073256 0.34306917 -1.2398204 -7.7881985 
		-0.69313902 -1.2398205 -7.0073256 9.3068609 -1.2398205 -6.4426804 10.343069 -1.2398204 
		-7.2235537 -0.69313902 -1.969317 -7.0073256 0.63384771 -1.9693168 -8.0073252 10.633848 
		-1.9693168 -7.4426804 9.3068609 -1.969317 -6.4426804 -0.69313902 -2.6258638 -7.0073256 
		0.63384771 -2.6258636 -8.0073252 10.633848 -2.6258636 -7.4426804 9.3068609 -2.6258638 
		-6.4426804;
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
createNode mesh -n "polySurfaceShape1" -p "|roofPieceSide4|wall5";
	rename -uid "0EAD41DA-4E92-79EF-5B5E-75848EA15B12";
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
	setAttr -s 9 ".pt[0:8]" -type "float3"  -5 5 -0.5 -5 5 -0.5 -5 5 
		-0.5 -5 5 -0.5 -5 5 -0.5 -5 5 -0.5 -5 5 -0.5 -5 5 -0.5 0 0 0;
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
createNode mesh -n "polySurfaceShape2" -p "|roofPieceSide4|wall5";
	rename -uid "97549F35-4F0F-5317-87B8-B4AE156DB2DA";
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
createNode transform -n "wall6" -p "roofPieceSide4";
	rename -uid "34539157-42CF-B608-9F9E-B6BD840D8867";
	setAttr ".rp" -type "double3" -0.69313913609019218 -0.42925571313914457 -3.193590562117401 ;
	setAttr ".sp" -type "double3" -0.69313913609019218 -0.42925571313914457 -3.193590562117401 ;
createNode mesh -n "wall6Shape" -p "|roofPieceSide4|wall6";
	rename -uid "EE0C9B18-4654-11DE-DC03-50BFD88A4E87";
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
	setAttr -s 20 ".pt[0:19]" -type "float3"  9.9783506 -0.42926887 -2.4098186 
		-0.021649335 -0.42926887 -2.9744635 10.885546 -5.7510357 -2.6289451 -20.580008 -5.7510357 
		-3.1699076 9.4272213 -5.7510357 -1.6289451 -22.038332 -5.7510357 -2.1699078 9.3068609 
		-0.42926887 -1.6289455 -0.69313902 -0.42926887 -2.1935906 0.34306917 -1.2398204 -2.9744637 
		-0.69313902 -1.2398205 -2.1935906 9.3068609 -1.2398205 -1.6289455 10.343069 -1.2398204 
		-2.4098184 -0.69313902 -1.969317 -2.1935906 0.63384771 -1.9693168 -3.1935906 10.633848 
		-1.9693168 -2.6289454 9.3068609 -1.969317 -1.6289455 -0.69313902 -2.6258638 -2.1935906 
		0.63384771 -2.6258636 -3.1935906 10.633848 -2.6258636 -2.6289454 9.3068609 -2.6258638 
		-1.6289455;
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
createNode mesh -n "polySurfaceShape1" -p "|roofPieceSide4|wall6";
	rename -uid "4BC79885-4257-9F7A-0537-4CB45E5C68FC";
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
	setAttr -s 9 ".pt[0:8]" -type "float3"  -5 5 -0.5 -5 5 -0.5 -5 5 
		-0.5 -5 5 -0.5 -5 5 -0.5 -5 5 -0.5 -5 5 -0.5 -5 5 -0.5 0 0 0;
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
createNode mesh -n "polySurfaceShape2" -p "|roofPieceSide4|wall6";
	rename -uid "E71E5BD1-4333-4564-65DD-CE9E0EB12844";
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
connectAttr "|wall4Shape.iog" "lambert2SG.dsm" -na;
connectAttr "|wall5Shape.iog" "lambert2SG.dsm" -na;
connectAttr "|wall6Shape.iog" "lambert2SG.dsm" -na;
connectAttr "roofPieceSide4Shape.iog" "lambert2SG.dsm" -na;
connectAttr "|roofPieceSide4|wall4|wall4Shape.iog" "lambert2SG.dsm" -na;
connectAttr "|roofPieceSide4|wall5|wall5Shape.iog" "lambert2SG.dsm" -na;
connectAttr "|roofPieceSide4|wall6|wall6Shape.iog" "lambert2SG.dsm" -na;
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
// End of roofSide.ma
