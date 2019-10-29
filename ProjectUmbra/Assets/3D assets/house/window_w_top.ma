//Maya ASCII 2019 scene
//Name: window_w_top.ma
//Last modified: Tue, Oct 29, 2019 02:10:18 PM
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
createNode transform -n "windowtop1";
	rename -uid "9A74AA33-42CE-9B01-7DE8-00A49079B1BC";
	setAttr ".rp" -type "double3" -4.9999998668865828 5.3259678883120483 0.14650406653428294 ;
	setAttr ".sp" -type "double3" -4.9999998668865828 5.3259678883120483 0.14650406653428294 ;
createNode mesh -n "windowtop1Shape" -p "windowtop1";
	rename -uid "46D3673C-4D34-1AA0-31B9-5CB5E0037F44";
	setAttr -k off ".v";
	setAttr -s 3 ".iog[0].og";
	setAttr ".iog[0].og[0].gcl" -type "componentList" 1 "f[0:81]";
	setAttr ".iog[0].og[1].gcl" -type "componentList" 3 "f[82:92]" "f[94:100]" "f[102:111]";
	setAttr ".iog[0].og[2].gcl" -type "componentList" 2 "f[93]" "f[101]";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 137 ".uvst[0].uvsp[0:136]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25 0.375 0.25 0.625 0.25 0.625 0.5 0.375 0.5 0.375 0.25
		 0.625 0.25 0.625 0.5 0.375 0.5 0.375 0.25 0.625 0.25 0.625 0.5 0.375 0.5 0.375 0.25
		 0.625 0.25 0.625 0.5 0.375 0.5 0.41666675 0 0.41666675 1 0.41666675 0.75 0.41666675
		 0.5 0.41666675 0.5 0.41666675 0.5 0.41666675 0.5 0.41666675 0.5 0.41666675 0.25 0.41666675
		 0.25 0.41666675 0.25 0.41666675 0.25 0.41666675 0.25 0.4583334 0 0.4583334 1 0.4583334
		 0.75 0.4583334 0.5 0.4583334 0.5 0.4583334 0.5 0.4583334 0.5 0.4583334 0.5 0.4583334
		 0.25 0.4583334 0.25 0.4583334 0.25 0.4583334 0.25 0.4583334 0.25 0.50000006 0 0.50000006
		 1 0.50000006 0.75 0.50000006 0.5 0.50000006 0.5 0.50000006 0.5 0.50000006 0.5 0.50000006
		 0.5 0.50000006 0.25 0.50000006 0.25 0.50000006 0.25 0.50000006 0.25 0.50000006 0.25
		 0.54166663 0 0.54166663 1 0.54166663 0.75 0.54166663 0.5 0.54166663 0.5 0.54166663
		 0.5 0.54166663 0.5 0.54166663 0.5 0.54166663 0.25 0.54166663 0.25 0.54166663 0.25
		 0.54166663 0.25 0.54166663 0.25 0.58333331 0 0.58333331 1 0.58333331 0.75 0.58333331
		 0.5 0.58333331 0.5 0.58333331 0.5 0.58333331 0.5 0.58333331 0.5 0.58333331 0.25 0.58333331
		 0.25 0.58333331 0.25 0.58333331 0.25 0.58333331 0.25 0.375 0.096016251 0.625 0.096016251
		 0.625 0.10533773 0.375 0.10533773 0.375 0.25 0.625 0.25 0.625 0.5 0.375 0.5 0.375
		 0.64466214 0.625 0.64466214 0.625 0.65398371 0.375 0.65398371 0.375 0.75 0.625 0.75
		 0.625 1 0.375 1 0.625 0.096016251 0.875 0.096016243 0.875 0.10533781 0.625 0.10533773
		 0.125 0.096016243 0.375 0.096016251 0.375 0.10533773 0.125 0.10533781 0.375 0 0.625
		 0 0.625 0 0.375 0 0.375 0.25 0.625 0.25 0.375 0 0.625 0 0.625 0.096016251 0.375 0.096016251
		 0.875 0 0.125 0 0.875 0.25 0.375 0.10533773 0.625 0.10533773 0.625 0.25 0.375 0.25
		 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 116 ".vt[0:115]"  -7.23327446 6.64406395 0.51621532 -2.76672721 6.64406395 0.51621532
		 -7.23327446 7.3256197 0.51621532 -2.76672721 7.3256197 0.51621532 -7.23327446 7.3256197 -0.22320719
		 -2.76672721 7.3256197 -0.22320719 -7.23327446 6.47464657 -0.22320719 -2.76672721 6.47464657 -0.22320719
		 -7.43565464 7.3256197 0.61374837 -2.56434512 7.3256197 0.61374837 -2.56434512 7.3256197 -0.32074022
		 -7.43565464 7.3256197 -0.32074022 -7.43565464 7.54385662 0.61374837 -2.56434512 7.54385662 0.61374837
		 -2.56434512 7.54385662 -0.32074022 -7.43565464 7.54385662 -0.32074022 -7.61889839 7.54385662 0.70875984
		 -2.38110137 7.54385662 0.70875984 -2.38110137 7.54385662 -0.41575176 -7.61889839 7.54385662 -0.41575176
		 -7.61889839 7.82324028 0.70875984 -2.38110137 7.82324028 0.70875984 -2.38110137 7.82324028 -0.41575176
		 -7.61889839 7.82324028 -0.41575176 -6.48884821 6.64406395 0.51621532 -6.48884821 6.47464657 -0.22320719
		 -6.48884821 7.3256197 -0.22320719 -6.62376833 7.3256197 -0.32074022 -6.62376833 7.54385662 -0.32074022
		 -6.74593067 7.54385662 -0.41575176 -6.74593067 7.82324028 -0.41575176 -6.74593067 7.82324028 0.70875984
		 -6.74593067 7.54385662 0.70875984 -6.62376833 7.54385662 0.61374837 -6.62376833 7.3256197 0.61374837
		 -6.48884821 7.3256197 0.51621532 -5.74442387 6.89228821 0.51621532 -5.74442387 6.72287083 -0.22320719
		 -5.74442387 7.57384396 -0.22320719 -5.81188393 7.57384396 -0.32074028 -5.81188393 7.79208088 -0.32074028
		 -5.87296486 7.79208088 -0.41575181 -5.87296486 8.071464539 -0.41575181 -5.87296486 8.071464539 0.7087599
		 -5.87296486 7.79208088 0.7087599 -5.81188393 7.79208088 0.61374837 -5.81188393 7.57384396 0.61374837
		 -5.74442387 7.57384396 0.51621532 -5 7.031423569 0.51621532 -5 6.86200619 -0.22320719
		 -5 7.71297932 -0.22320719 -4.99999905 7.71297932 -0.32074028 -4.99999905 7.93121624 -0.32074028
		 -4.99999905 7.93121624 -0.41575181 -4.99999905 8.2105999 -0.41575181 -4.99999905 8.2105999 0.7087599
		 -4.99999905 7.93121624 0.7087599 -4.99999905 7.93121624 0.61374837 -4.99999905 7.71297932 0.61374837
		 -5 7.71297932 0.51621532 -4.25557613 6.89228821 0.51621526 -4.25557613 6.72287083 -0.22320716
		 -4.25557613 7.57384396 -0.22320716 -4.18811512 7.57384396 -0.32074022 -4.18811512 7.79208088 -0.32074022
		 -4.12703419 7.79208088 -0.41575176 -4.12703419 8.071464539 -0.41575176 -4.12703419 8.071464539 0.70875984
		 -4.12703419 7.79208088 0.70875984 -4.18811512 7.79208088 0.61374837 -4.18811512 7.57384396 0.61374837
		 -4.25557613 7.57384396 0.51621526 -3.51115179 6.64406395 0.51621532 -3.51115179 6.47464657 -0.22320719
		 -3.51115179 7.3256197 -0.22320719 -3.37623024 7.3256197 -0.32074022 -3.37623024 7.54385662 -0.32074022
		 -3.25406766 7.54385662 -0.41575176 -3.25406766 7.82324028 -0.41575176 -3.25406766 7.82324028 0.70875984
		 -3.25406766 7.54385662 0.70875984 -3.37623024 7.54385662 0.61374837 -3.37623024 7.3256197 0.61374837
		 -3.51115179 7.3256197 0.51621532 -6.33156681 2.44133568 0.32608414 -3.66843319 2.44133568 0.32608414
		 -6.33156681 7.55866528 0.32608414 -3.66843319 7.55866528 0.32608414 -6.33156681 7.55866528 -0.32608414
		 -3.66843319 7.55866528 -0.32608414 -6.33156681 2.44133568 -0.32608414 -3.66843319 2.44133568 -0.32608414
		 -6.23170567 2.63322234 0.32608414 -3.76829362 2.63322234 0.32608414 -3.76829362 7.36677837 0.32608414
		 -6.23170567 7.36677837 0.32608414 -6.33156681 4.40672255 0.32608414 -6.23170567 4.45121574 0.32608414
		 -3.76829362 4.45121574 0.32608414 -3.66843319 4.40672255 0.32608414 -3.66843319 4.40672255 -0.32608414
		 -6.33156681 4.40672255 -0.32608414 -6.33156681 4.59752893 -0.32608414 -3.66843319 4.59752893 -0.32608414
		 -3.66843319 4.5975275 0.32608414 -3.76829362 4.62771082 0.32608414 -6.23170567 4.62771082 0.32608414
		 -6.33156681 4.5975275 0.32608414 -6.23170567 2.63322234 0.094035022 -3.76829362 2.63322234 0.094035022
		 -3.76829362 4.45121574 0.094035022 -6.23170567 4.45121574 0.094035022 -3.76829362 4.62771082 0.22628857
		 -6.23170567 4.62771082 0.22628857 -3.76829362 7.36677837 0.22628857 -6.23170567 7.36677837 0.22628857;
	setAttr -s 224 ".ed";
	setAttr ".ed[0:165]"  0 24 0 2 35 0 4 26 0 6 25 0 0 2 0 1 3 0 2 4 0 3 5 0
		 4 6 0 5 7 0 6 0 0 7 1 0 2 8 0 3 9 0 8 34 0 5 10 0 9 10 0 4 11 0 11 27 0 8 11 0 8 12 0
		 9 13 0 12 33 0 10 14 0 13 14 0 11 15 0 15 28 0 12 15 0 12 16 0 13 17 0 16 32 0 14 18 0
		 17 18 0 15 19 0 19 29 0 16 19 0 16 20 0 17 21 0 20 31 0 18 22 0 21 22 0 19 23 0 23 30 0
		 20 23 0 24 36 0 25 37 0 26 38 0 27 39 0 28 40 0 29 41 0 30 42 0 31 43 0 32 44 0 33 45 0
		 34 46 0 35 47 0 24 25 1 25 26 1 26 27 1 27 28 1 28 29 1 29 30 1 30 31 1 31 32 1 32 33 1
		 33 34 1 34 35 1 35 24 1 36 48 0 37 49 0 38 50 0 39 51 0 40 52 0 41 53 0 42 54 0 43 55 0
		 44 56 0 45 57 0 46 58 0 47 59 0 36 37 1 37 38 1 38 39 1 39 40 1 40 41 1 41 42 1 42 43 1
		 43 44 1 44 45 1 45 46 1 46 47 1 47 36 1 48 60 0 49 61 0 50 62 0 51 63 0 52 64 0 53 65 0
		 54 66 0 55 67 0 56 68 0 57 69 0 58 70 0 59 71 0 48 49 1 49 50 1 50 51 1 51 52 1 52 53 1
		 53 54 1 54 55 1 55 56 1 56 57 1 57 58 1 58 59 1 59 48 1 60 72 0 61 73 0 62 74 0 63 75 0
		 64 76 0 65 77 0 66 78 0 67 79 0 68 80 0 69 81 0 70 82 0 71 83 0 60 61 1 61 62 1 62 63 1
		 63 64 1 64 65 1 65 66 1 66 67 1 67 68 1 68 69 1 69 70 1 70 71 1 71 60 1 72 1 0 73 7 0
		 74 5 0 75 10 0 76 14 0 77 18 0 78 22 0 79 21 0 80 17 0 81 13 0 82 9 0 83 3 0 72 73 1
		 73 74 1 74 75 1 75 76 1 76 77 1 77 78 1 78 79 1 79 80 1 80 81 1 81 82 1 82 83 1 83 72 1
		 84 85 0 86 87 0;
	setAttr ".ed[166:223]" 88 89 0 90 91 0 84 96 0 85 99 0 86 88 0 87 89 0 88 102 0
		 89 103 0 90 84 0 91 85 0 84 92 0 85 93 0 92 93 0 87 94 0 93 98 0 86 95 0 95 94 0
		 92 97 0 96 107 0 97 106 0 98 105 0 99 104 0 100 91 0 101 90 0 96 97 1 97 98 0 98 99 1
		 99 100 1 100 101 1 101 96 1 102 101 0 103 100 0 104 87 0 105 94 0 106 95 0 107 86 0
		 102 103 1 103 104 1 104 105 1 105 106 0 106 107 1 107 102 1 92 108 0 93 109 0 108 109 0
		 98 110 0 109 110 0 97 111 0 111 110 0 108 111 0 105 112 0 106 113 0 112 113 0 94 114 0
		 112 114 0 95 115 0 115 114 0 113 115 0;
	setAttr -s 112 -ch 448 ".fc[0:111]" -type "polyFaces" 
		f 4 163 140 5 -152
		mu 0 4 94 82 1 3
		f 4 158 147 40 -147
		mu 0 4 89 90 27 28
		f 4 153 142 9 -142
		mu 0 4 84 85 5 7
		f 4 152 141 11 -141
		mu 0 4 83 84 7 9
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13
		f 4 162 151 13 -151
		mu 0 4 93 94 3 15
		f 4 7 15 -17 -14
		mu 0 4 3 5 16 15
		f 4 -143 154 143 -16
		mu 0 4 5 85 86 16
		f 4 -7 12 19 -18
		mu 0 4 4 2 14 17
		f 4 161 150 21 -150
		mu 0 4 92 93 15 19
		f 4 16 23 -25 -22
		mu 0 4 15 16 20 19
		f 4 -144 155 144 -24
		mu 0 4 16 86 87 20
		f 4 -20 20 27 -26
		mu 0 4 17 14 18 21
		f 4 160 149 29 -149
		mu 0 4 91 92 19 23
		f 4 24 31 -33 -30
		mu 0 4 19 20 24 23
		f 4 -145 156 145 -32
		mu 0 4 20 87 88 24
		f 4 -28 28 35 -34
		mu 0 4 21 18 22 25
		f 4 159 148 37 -148
		mu 0 4 90 91 23 27
		f 4 32 39 -41 -38
		mu 0 4 23 24 28 27
		f 4 -146 157 146 -40
		mu 0 4 24 88 89 28
		f 4 -36 36 43 -42
		mu 0 4 25 22 26 29
		f 4 3 -57 -1 -11
		mu 0 4 6 32 31 8
		f 4 2 -58 -4 -9
		mu 0 4 4 33 32 6
		f 4 -59 -3 17 18
		mu 0 4 34 33 4 17
		f 4 -60 -19 25 26
		mu 0 4 35 34 17 21
		f 4 -61 -27 33 34
		mu 0 4 36 35 21 25
		f 4 -62 -35 41 42
		mu 0 4 37 36 25 29
		f 4 38 -63 -43 -44
		mu 0 4 26 38 37 29
		f 4 30 -64 -39 -37
		mu 0 4 22 39 38 26
		f 4 22 -65 -31 -29
		mu 0 4 18 40 39 22
		f 4 14 -66 -23 -21
		mu 0 4 14 41 40 18
		f 4 1 -67 -15 -13
		mu 0 4 2 42 41 14
		f 4 0 -68 -2 -5
		mu 0 4 0 30 42 2
		f 4 56 45 -81 -45
		mu 0 4 31 32 45 44
		f 4 57 46 -82 -46
		mu 0 4 32 33 46 45
		f 4 -83 -47 58 47
		mu 0 4 47 46 33 34
		f 4 -84 -48 59 48
		mu 0 4 48 47 34 35
		f 4 -85 -49 60 49
		mu 0 4 49 48 35 36
		f 4 -86 -50 61 50
		mu 0 4 50 49 36 37
		f 4 62 51 -87 -51
		mu 0 4 37 38 51 50
		f 4 63 52 -88 -52
		mu 0 4 38 39 52 51
		f 4 64 53 -89 -53
		mu 0 4 39 40 53 52
		f 4 65 54 -90 -54
		mu 0 4 40 41 54 53
		f 4 66 55 -91 -55
		mu 0 4 41 42 55 54
		f 4 67 44 -92 -56
		mu 0 4 42 30 43 55
		f 4 80 69 -105 -69
		mu 0 4 44 45 58 57
		f 4 81 70 -106 -70
		mu 0 4 45 46 59 58
		f 4 -107 -71 82 71
		mu 0 4 60 59 46 47
		f 4 -108 -72 83 72
		mu 0 4 61 60 47 48
		f 4 -109 -73 84 73
		mu 0 4 62 61 48 49
		f 4 -110 -74 85 74
		mu 0 4 63 62 49 50
		f 4 86 75 -111 -75
		mu 0 4 50 51 64 63
		f 4 87 76 -112 -76
		mu 0 4 51 52 65 64
		f 4 88 77 -113 -77
		mu 0 4 52 53 66 65
		f 4 89 78 -114 -78
		mu 0 4 53 54 67 66
		f 4 90 79 -115 -79
		mu 0 4 54 55 68 67
		f 4 91 68 -116 -80
		mu 0 4 55 43 56 68
		f 4 104 93 -129 -93
		mu 0 4 57 58 71 70
		f 4 105 94 -130 -94
		mu 0 4 58 59 72 71
		f 4 -131 -95 106 95
		mu 0 4 73 72 59 60
		f 4 -132 -96 107 96
		mu 0 4 74 73 60 61
		f 4 -133 -97 108 97
		mu 0 4 75 74 61 62
		f 4 -134 -98 109 98
		mu 0 4 76 75 62 63
		f 4 110 99 -135 -99
		mu 0 4 63 64 77 76
		f 4 111 100 -136 -100
		mu 0 4 64 65 78 77
		f 4 112 101 -137 -101
		mu 0 4 65 66 79 78
		f 4 113 102 -138 -102
		mu 0 4 66 67 80 79
		f 4 114 103 -139 -103
		mu 0 4 67 68 81 80
		f 4 115 92 -140 -104
		mu 0 4 68 56 69 81
		f 4 128 117 -153 -117
		mu 0 4 70 71 84 83
		f 4 129 118 -154 -118
		mu 0 4 71 72 85 84
		f 4 -155 -119 130 119
		mu 0 4 86 85 72 73
		f 4 -156 -120 131 120
		mu 0 4 87 86 73 74
		f 4 -157 -121 132 121
		mu 0 4 88 87 74 75
		f 4 -158 -122 133 122
		mu 0 4 89 88 75 76
		f 4 134 123 -159 -123
		mu 0 4 76 77 90 89
		f 4 135 124 -160 -124
		mu 0 4 77 78 91 90
		f 4 136 125 -161 -125
		mu 0 4 78 79 92 91
		f 4 137 126 -162 -126
		mu 0 4 79 80 93 92
		f 4 138 127 -163 -127
		mu 0 4 80 81 94 93
		f 4 139 116 -164 -128
		mu 0 4 81 69 82 94
		f 4 191 186 205 -186
		mu 0 4 95 96 97 98
		f 4 165 171 -167 -171
		mu 0 4 99 100 101 102
		f 4 202 197 194 -197
		mu 0 4 103 104 105 106
		f 4 167 175 -165 -175
		mu 0 4 107 108 109 110
		f 4 193 -198 203 -188
		mu 0 4 111 112 113 114
		f 4 195 184 207 196
		mu 0 4 115 116 117 118
		f 4 164 177 -179 -177
		mu 0 4 119 120 121 122
		f 4 192 187 204 -187
		mu 0 4 96 111 114 97
		f 4 -166 181 182 -180
		mu 0 4 100 99 123 124
		f 4 206 -185 190 185
		mu 0 4 98 117 116 95
		f 4 -191 -169 176 183
		mu 0 4 95 116 119 122
		f 4 210 212 -215 -216
		mu 0 4 125 126 127 128
		f 4 169 -193 -181 -178
		mu 0 4 120 111 96 121
		f 4 -176 -189 -194 -170
		mu 0 4 120 129 112 111
		f 4 -195 188 -168 -190
		mu 0 4 106 105 108 107
		f 4 174 168 -196 189
		mu 0 4 130 119 116 115
		f 4 166 173 -203 -173
		mu 0 4 102 101 104 103
		f 4 -204 -174 -172 -199
		mu 0 4 114 113 131 100
		f 4 -205 198 179 -200
		mu 0 4 97 114 100 124
		f 4 -219 220 -223 -224
		mu 0 4 132 133 134 135
		f 4 -202 -207 200 -182
		mu 0 4 99 117 98 123
		f 4 -208 201 170 172
		mu 0 4 118 117 99 136
		f 4 178 209 -211 -209
		mu 0 4 122 121 126 125
		f 4 180 211 -213 -210
		mu 0 4 121 96 127 126
		f 4 -192 213 214 -212
		mu 0 4 96 95 128 127
		f 4 -184 208 215 -214
		mu 0 4 95 122 125 128
		f 4 -206 216 218 -218
		mu 0 4 98 97 133 132
		f 4 199 219 -221 -217
		mu 0 4 97 124 134 133
		f 4 -183 221 222 -220
		mu 0 4 124 123 135 134
		f 4 -201 217 223 -222
		mu 0 4 123 98 132 135;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode groupId -n "groupId2";
	rename -uid "E84DEAFD-4820-0C6A-8673-55B76D74057A";
	setAttr ".ihi" 0;
createNode shadingEngine -n "lambert2SG";
	rename -uid "392CDEE6-47C6-9899-F7B6-1BAE0852BE90";
	setAttr ".ihi" 0;
	setAttr -s 2 ".dsm";
	setAttr ".ro" yes;
	setAttr -s 2 ".gn";
createNode materialInfo -n "materialInfo1";
	rename -uid "ACF16D33-433C-0F57-B281-E9A1C21E5FC4";
createNode lambert -n "whitebrick";
	rename -uid "C7CC844F-43B9-7F56-6F46-7186561B7952";
	setAttr ".c" -type "float3" 1 1 1 ;
createNode groupId -n "groupId3";
	rename -uid "8FA5189E-4110-8561-603A-A9BA93357F27";
	setAttr ".ihi" 0;
createNode shadingEngine -n "lambert3SG";
	rename -uid "CDE61583-4AA1-38E2-DA31-F19D0C0A8C18";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode materialInfo -n "materialInfo2";
	rename -uid "2AA448D8-41C9-36A6-A200-2386DEC94B62";
createNode lambert -n "frame";
	rename -uid "8524A2C0-4185-A75F-A92B-68A0B68208FA";
	setAttr ".c" -type "float3" 0.02 0.02 0.02 ;
createNode groupId -n "groupId4";
	rename -uid "3D2AAF91-475F-BB05-61F2-B78EA4E16E90";
	setAttr ".ihi" 0;
createNode shadingEngine -n "lambert4SG";
	rename -uid "451D8C29-409A-1BA2-81A3-2E8D246918A8";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode materialInfo -n "materialInfo3";
	rename -uid "67BDAE14-4A97-A013-DB73-5AB13527918A";
createNode lambert -n "glass";
	rename -uid "4E659471-4543-FAED-B406-EB8D9E77DEBE";
createNode lightLinker -s -n "lightLinker1";
	rename -uid "5C8618AE-4BD3-A58B-8951-ADBA6DD1DBAC";
	setAttr -s 5 ".lnk";
	setAttr -s 5 ".slnk";
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
	setAttr -s 5 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 7 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :lambert1;
	setAttr ".c" -type "float3" 0.5 0.141 0.141 ;
select -ne :initialShadingGroup;
	setAttr -s 2 ".dsm";
	setAttr ".ro" yes;
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
connectAttr "groupId2.id" "windowtop1Shape.iog.og[0].gid";
connectAttr "lambert2SG.mwc" "windowtop1Shape.iog.og[0].gco";
connectAttr "groupId3.id" "windowtop1Shape.iog.og[1].gid";
connectAttr "lambert3SG.mwc" "windowtop1Shape.iog.og[1].gco";
connectAttr "groupId4.id" "windowtop1Shape.iog.og[2].gid";
connectAttr "lambert4SG.mwc" "windowtop1Shape.iog.og[2].gco";
connectAttr "whitebrick.oc" "lambert2SG.ss";
connectAttr "corner7Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "windowtop1Shape.iog.og[0]" "lambert2SG.dsm" -na;
connectAttr "groupId1.msg" "lambert2SG.gn" -na;
connectAttr "groupId2.msg" "lambert2SG.gn" -na;
connectAttr "lambert2SG.msg" "materialInfo1.sg";
connectAttr "whitebrick.msg" "materialInfo1.m";
connectAttr "frame.oc" "lambert3SG.ss";
connectAttr "windowtop1Shape.iog.og[1]" "lambert3SG.dsm" -na;
connectAttr "groupId3.msg" "lambert3SG.gn" -na;
connectAttr "lambert3SG.msg" "materialInfo2.sg";
connectAttr "frame.msg" "materialInfo2.m";
connectAttr "glass.oc" "lambert4SG.ss";
connectAttr "groupId4.msg" "lambert4SG.gn" -na;
connectAttr "windowtop1Shape.iog.og[2]" "lambert4SG.dsm" -na;
connectAttr "lambert4SG.msg" "materialInfo3.sg";
connectAttr "glass.msg" "materialInfo3.m";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "lambert2SG.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "lambert3SG.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "lambert4SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "lambert2SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "lambert3SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "lambert4SG.message" ":defaultLightSet.message";
connectAttr "lambert2SG.pa" ":renderPartition.st" -na;
connectAttr "lambert3SG.pa" ":renderPartition.st" -na;
connectAttr "lambert4SG.pa" ":renderPartition.st" -na;
connectAttr "whitebrick.msg" ":defaultShaderList1.s" -na;
connectAttr "frame.msg" ":defaultShaderList1.s" -na;
connectAttr "glass.msg" ":defaultShaderList1.s" -na;
// End of window_w_top.ma
