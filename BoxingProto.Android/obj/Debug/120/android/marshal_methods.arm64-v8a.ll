; ModuleID = 'obj\Debug\120\android\marshal_methods.arm64-v8a.ll'
source_filename = "obj\Debug\120\android\marshal_methods.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [322 x i64] [
	i64 24362543149721218, ; 0: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 88
	i64 120698629574877762, ; 1: Mono.Android => 0x1accec39cafe242 => 14
	i64 196720943101637631, ; 2: System.Linq.Expressions.dll => 0x2bae4a7cd73f3ff => 148
	i64 210515253464952879, ; 3: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 78
	i64 232391251801502327, ; 4: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 110
	i64 295915112840604065, ; 5: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 111
	i64 590536689428908136, ; 6: Xamarin.Android.Arch.Lifecycle.ViewModel.dll => 0x83201fd803ec868 => 42
	i64 634308326490598313, ; 7: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 97
	i64 702024105029695270, ; 8: System.Drawing.Common => 0x9be17343c0e7726 => 136
	i64 720058930071658100, ; 9: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 91
	i64 742007272015649219, ; 10: BoxingProto.Android => 0xa4c23aebd3fd9c3 => 0
	i64 816102801403336439, ; 11: Xamarin.Android.Support.Collections => 0xb53612c89d8d6f7 => 46
	i64 846634227898301275, ; 12: Xamarin.Android.Arch.Lifecycle.LiveData.Core => 0xbbfd9583890bb5b => 39
	i64 870603111519317375, ; 13: SQLitePCLRaw.lib.e_sqlite3.android => 0xc1500ead2756d7f => 24
	i64 872800313462103108, ; 14: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 87
	i64 940822596282819491, ; 15: System.Transactions => 0xd0e792aa81923a3 => 134
	i64 996343623809489702, ; 16: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 124
	i64 1000557547492888992, ; 17: Mono.Security.dll => 0xde2b1c9cba651a0 => 160
	i64 1120440138749646132, ; 18: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 126
	i64 1285447915151038934, ; 19: DevExpress.XamarinForms.Core.dll => 0x11d6d41177d819d6 => 11
	i64 1301485588176585670, ; 20: SQLitePCLRaw.core => 0x120fce3f338e43c6 => 23
	i64 1315114680217950157, ; 21: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 73
	i64 1342439039765371018, ; 22: Xamarin.Android.Support.Fragment => 0x12a14d31b1d4d88a => 55
	i64 1425944114962822056, ; 23: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 4
	i64 1490981186906623721, ; 24: Xamarin.Android.Support.VersionedParcelable => 0x14b1077d6c5c0ee9 => 66
	i64 1507091876539346714, ; 25: Plugin.SimpleAudioPlayer.Abstractions => 0x14ea4413a9012f1a => 17
	i64 1518315023656898250, ; 26: SQLitePCLRaw.provider.e_sqlite3 => 0x151223783a354eca => 25
	i64 1624659445732251991, ; 27: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 71
	i64 1628611045998245443, ; 28: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 99
	i64 1636321030536304333, ; 29: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 92
	i64 1731380447121279447, ; 30: Newtonsoft.Json => 0x18071957e9b889d7 => 16
	i64 1743969030606105336, ; 31: System.Memory.dll => 0x1833d297e88f2af8 => 29
	i64 1744702963312407042, ; 32: Xamarin.Android.Support.v7.AppCompat => 0x18366e19eeceb202 => 64
	i64 1795316252682057001, ; 33: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 72
	i64 1836611346387731153, ; 34: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 110
	i64 1875917498431009007, ; 35: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 69
	i64 1938067011858688285, ; 36: Xamarin.Android.Support.v4.dll => 0x1ae565add0bd691d => 63
	i64 1981742497975770890, ; 37: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 98
	i64 1986553961460820075, ; 38: Xamarin.CommunityToolkit => 0x1b91a84d8004686b => 120
	i64 2133195048986300728, ; 39: Newtonsoft.Json.dll => 0x1d9aa1984b735138 => 16
	i64 2136356949452311481, ; 40: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 103
	i64 2165725771938924357, ; 41: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 76
	i64 2209945103967622875, ; 42: BoxingProto.Android.dll => 0x1eab4d5cff1a96db => 0
	i64 2262844636196693701, ; 43: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 87
	i64 2284400282711631002, ; 44: System.Web.Services => 0x1fb3d1f42fd4249a => 140
	i64 2329709569556905518, ; 45: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 95
	i64 2337758774805907496, ; 46: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 32
	i64 2470498323731680442, ; 47: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 82
	i64 2479423007379663237, ; 48: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 115
	i64 2497223385847772520, ; 49: System.Runtime => 0x22a7eb7046413568 => 33
	i64 2547086958574651984, ; 50: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 68
	i64 2592350477072141967, ; 51: System.Xml.dll => 0x23f9e10627330e8f => 34
	i64 2624866290265602282, ; 52: mscorlib.dll => 0x246d65fbde2db8ea => 15
	i64 2694427813909235223, ; 53: Xamarin.AndroidX.Preference.dll => 0x256487d230fe0617 => 107
	i64 2783046991838674048, ; 54: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 32
	i64 2853437745093055792, ; 55: DevExpress.XamarinForms.CollectionView.Android => 0x27997282d0f69530 => 8
	i64 2949706848458024531, ; 56: Xamarin.Android.Support.SlidingPaneLayout => 0x28ef76c01de0a653 => 61
	i64 2960931600190307745, ; 57: Xamarin.Forms.Core => 0x2917579a49927da1 => 122
	i64 2977248461349026546, ; 58: Xamarin.Android.Support.DrawerLayout => 0x29514fb392c97af2 => 54
	i64 3017704767998173186, ; 59: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 126
	i64 3022227708164871115, ; 60: Xamarin.Android.Support.Media.Compat.dll => 0x29f11c168f8293cb => 59
	i64 3289520064315143713, ; 61: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 94
	i64 3303437397778967116, ; 62: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 70
	i64 3311221304742556517, ; 63: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 31
	i64 3493805808809882663, ; 64: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 113
	i64 3522470458906976663, ; 65: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 112
	i64 3531994851595924923, ; 66: System.Numerics => 0x31042a9aade235bb => 30
	i64 3571415421602489686, ; 67: System.Runtime.dll => 0x319037675df7e556 => 33
	i64 3647754201059316852, ; 68: System.Xml.ReaderWriter => 0x329f6d1e86145474 => 154
	i64 3716579019761409177, ; 69: netstandard.dll => 0x3393f0ed5c8c5c99 => 132
	i64 3727469159507183293, ; 70: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 109
	i64 3772598417116884899, ; 71: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 88
	i64 3966267475168208030, ; 72: System.Memory => 0x370b03412596249e => 29
	i64 4009997192427317104, ; 73: System.Runtime.Serialization.Primitives => 0x37a65f335cf1a770 => 146
	i64 4187479170553454871, ; 74: System.Linq.Expressions => 0x3a1cea1e912fa117 => 148
	i64 4252163538099460320, ; 75: Xamarin.Android.Support.ViewPager.dll => 0x3b02b8357f4958e0 => 67
	i64 4337444564132831293, ; 76: SQLitePCLRaw.batteries_v2.dll => 0x3c31b2d9ae16203d => 22
	i64 4349341163892612332, ; 77: Xamarin.Android.Support.DocumentFile => 0x3c5bf6bea8cd9cec => 53
	i64 4416987920449902723, ; 78: Xamarin.Android.Support.AsyncLayoutInflater.dll => 0x3d4c4b1c879b9883 => 45
	i64 4525561845656915374, ; 79: System.ServiceModel.Internals => 0x3ece06856b710dae => 131
	i64 4636684751163556186, ; 80: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 117
	i64 4782108999019072045, ; 81: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 75
	i64 4794310189461587505, ; 82: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 68
	i64 4795410492532947900, ; 83: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 112
	i64 4841234827713643511, ; 84: Xamarin.Android.Support.CoordinaterLayout => 0x432f856d041f03f7 => 48
	i64 4963205065368577818, ; 85: Xamarin.Android.Support.LocalBroadcastManager.dll => 0x44e0d8b5f4b6a71a => 58
	i64 5081566143765835342, ; 86: System.Resources.ResourceManager.dll => 0x4685597c05d06e4e => 2
	i64 5099468265966638712, ; 87: System.Resources.ResourceManager => 0x46c4f35ea8519678 => 2
	i64 5142919913060024034, ; 88: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 123
	i64 5178572682164047940, ; 89: Xamarin.Android.Support.Print.dll => 0x47ddfc6acbee1044 => 60
	i64 5203618020066742981, ; 90: Xamarin.Essentials => 0x4836f704f0e652c5 => 121
	i64 5205316157927637098, ; 91: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 101
	i64 5288341611614403055, ; 92: Xamarin.Android.Support.Interpolator.dll => 0x4963f6ad4b3179ef => 56
	i64 5348796042099802469, ; 93: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 102
	i64 5376510917114486089, ; 94: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 115
	i64 5408338804355907810, ; 95: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 114
	i64 5439315836349573567, ; 96: Xamarin.Android.Support.Animated.Vector.Drawable.dll => 0x4b7c54ef36c5e9bf => 43
	i64 5446034149219586269, ; 97: System.Diagnostics.Debug => 0x4b94333452e150dd => 151
	i64 5451019430259338467, ; 98: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 81
	i64 5507995362134886206, ; 99: System.Core.dll => 0x4c705499688c873e => 27
	i64 5582653315569930024, ; 100: DevExpress.XamarinForms.CollectionView.Android.dll => 0x4d79919cc2b3cf28 => 8
	i64 5692067934154308417, ; 101: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 119
	i64 5757522595884336624, ; 102: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 79
	i64 5767696078500135884, ; 103: Xamarin.Android.Support.Annotations.dll => 0x500af9065b6a03cc => 44
	i64 5814345312393086621, ; 104: Xamarin.AndroidX.Preference => 0x50b0b44182a5c69d => 107
	i64 5896680224035167651, ; 105: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x51d5376bfbafdda3 => 96
	i64 6044705416426755068, ; 106: Xamarin.Android.Support.SwipeRefreshLayout.dll => 0x53e31b8ccdff13fc => 62
	i64 6085203216496545422, ; 107: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 124
	i64 6086316965293125504, ; 108: FormsViewGroup.dll => 0x5476f10882baef80 => 12
	i64 6183170893902868313, ; 109: SQLitePCLRaw.batteries_v2 => 0x55cf092b0c9d6f59 => 22
	i64 6252756117335416132, ; 110: SQLiteNetExtensionsAsync.dll => 0x56c6408f68ed9d44 => 21
	i64 6311200438583329442, ; 111: Xamarin.Android.Support.LocalBroadcastManager => 0x5795e35c580c82a2 => 58
	i64 6319713645133255417, ; 112: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 97
	i64 6401687960814735282, ; 113: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 95
	i64 6405879832841858445, ; 114: Xamarin.Android.Support.Vector.Drawable.dll => 0x58e641c4a660ad8d => 65
	i64 6504860066809920875, ; 115: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 76
	i64 6548213210057960872, ; 116: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 85
	i64 6588599331800941662, ; 117: Xamarin.Android.Support.v4 => 0x5b6f682f335f045e => 63
	i64 6591024623626361694, ; 118: System.Web.Services.dll => 0x5b7805f9751a1b5e => 140
	i64 6597847241890044908, ; 119: BoxingProto.dll => 0x5b90431c0f259bec => 5
	i64 6659513131007730089, ; 120: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 91
	i64 6814185388980153342, ; 121: System.Xml.XDocument.dll => 0x5e90d98217d1abfe => 143
	i64 6876862101832370452, ; 122: System.Xml.Linq => 0x5f6f85a57d108914 => 35
	i64 6894844156784520562, ; 123: System.Numerics.Vectors => 0x5faf683aead1ad72 => 31
	i64 6999232271162345813, ; 124: SQLiteNetExtensions => 0x612244aac7150955 => 20
	i64 7036436454368433159, ; 125: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x61a671acb33d5407 => 93
	i64 7103753931438454322, ; 126: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 90
	i64 7194160955514091247, ; 127: Xamarin.Android.Support.CursorAdapter.dll => 0x63d6cb45d266f6ef => 51
	i64 7270811800166795866, ; 128: System.Linq => 0x64e71ccf51a90a5a => 150
	i64 7338192458477945005, ; 129: System.Reflection => 0x65d67f295d0740ad => 147
	i64 7488575175965059935, ; 130: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 35
	i64 7489048572193775167, ; 131: System.ObjectModel => 0x67ee71ff6b419e3f => 152
	i64 7547171332664898270, ; 132: SQLiteNetExtensions.dll => 0x68bcf0572680b2de => 20
	i64 7594383334536821595, ; 133: DevExpress.Xamarin.Android.CollectionView.dll => 0x6964ab67ef36bb5b => 7
	i64 7635363394907363464, ; 134: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 122
	i64 7637365915383206639, ; 135: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 121
	i64 7654504624184590948, ; 136: System.Net.Http => 0x6a3a4366801b8264 => 3
	i64 7735176074855944702, ; 137: Microsoft.CSharp => 0x6b58dda848e391fe => 159
	i64 7735352534559001595, ; 138: Xamarin.Kotlin.StdLib.dll => 0x6b597e2582ce8bfb => 130
	i64 7820441508502274321, ; 139: System.Data => 0x6c87ca1e14ff8111 => 133
	i64 7821246742157274664, ; 140: Xamarin.Android.Support.AsyncLayoutInflater => 0x6c8aa67926f72e28 => 45
	i64 7836164640616011524, ; 141: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 71
	i64 7879037620440914030, ; 142: Xamarin.Android.Support.v7.AppCompat.dll => 0x6d57f6f88a51d86e => 64
	i64 8044118961405839122, ; 143: System.ComponentModel.Composition => 0x6fa2739369944712 => 139
	i64 8064050204834738623, ; 144: System.Collections.dll => 0x6fe942efa61731bf => 144
	i64 8083354569033831015, ; 145: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 94
	i64 8101777744205214367, ; 146: Xamarin.Android.Support.Annotations => 0x706f4beeec84729f => 44
	i64 8103644804370223335, ; 147: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 135
	i64 8113615946733131500, ; 148: System.Reflection.Extensions => 0x70995ab73cf916ec => 1
	i64 8167236081217502503, ; 149: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 13
	i64 8185542183669246576, ; 150: System.Collections => 0x7198e33f4794aa70 => 144
	i64 8196541262927413903, ; 151: Xamarin.Android.Support.Interpolator => 0x71bff6d9fb9ec28f => 56
	i64 8290740647658429042, ; 152: System.Runtime.Extensions => 0x730ea0b15c929a72 => 156
	i64 8385935383968044654, ; 153: Xamarin.Android.Arch.Lifecycle.Runtime.dll => 0x7460d3cd16cb566e => 41
	i64 8398329775253868912, ; 154: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 80
	i64 8400357532724379117, ; 155: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 106
	i64 8537064613166331693, ; 156: Plugin.SimpleAudioPlayer.dll => 0x7679bf08cc56372d => 18
	i64 8601935802264776013, ; 157: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 114
	i64 8626175481042262068, ; 158: Java.Interop => 0x77b654e585b55834 => 13
	i64 8638972117149407195, ; 159: Microsoft.CSharp.dll => 0x77e3cb5e8b31d7db => 159
	i64 8639588376636138208, ; 160: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 105
	i64 8684531736582871431, ; 161: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 138
	i64 8808820144457481518, ; 162: Xamarin.Android.Support.Loader.dll => 0x7a3f374010b17d2e => 57
	i64 8853378295825400934, ; 163: Xamarin.Kotlin.StdLib.Common.dll => 0x7add84a720d38466 => 129
	i64 8917102979740339192, ; 164: Xamarin.Android.Support.DocumentFile.dll => 0x7bbfe9ea4d000bf8 => 53
	i64 8941376889969657626, ; 165: System.Xml.XDocument => 0x7c1626e87187471a => 143
	i64 9312692141327339315, ; 166: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 119
	i64 9324707631942237306, ; 167: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 72
	i64 9584643793929893533, ; 168: System.IO.dll => 0x85037ebfbbd7f69d => 141
	i64 9659729154652888475, ; 169: System.Text.RegularExpressions => 0x860e407c9991dd9b => 153
	i64 9662334977499516867, ; 170: System.Numerics.dll => 0x8617827802b0cfc3 => 30
	i64 9678050649315576968, ; 171: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 82
	i64 9711637524876806384, ; 172: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 102
	i64 9808709177481450983, ; 173: Mono.Android.dll => 0x881f890734e555e7 => 14
	i64 9825649861376906464, ; 174: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 79
	i64 9834056768316610435, ; 175: System.Transactions.dll => 0x8879968718899783 => 134
	i64 9866412715007501892, ; 176: Xamarin.Android.Arch.Lifecycle.Common.dll => 0x88ec8a16fd6b6644 => 38
	i64 9998632235833408227, ; 177: Mono.Security => 0x8ac2470b209ebae3 => 160
	i64 10038780035334861115, ; 178: System.Net.Http.dll => 0x8b50e941206af13b => 3
	i64 10229024438826829339, ; 179: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 85
	i64 10303118382221642606, ; 180: Plugin.SimpleAudioPlayer.Abstractions.dll => 0x8efc0794931e4b6e => 17
	i64 10303855825347935641, ; 181: Xamarin.Android.Support.Loader => 0x8efea647eeb3fd99 => 57
	i64 10321854143672141184, ; 182: Xamarin.Jetbrains.Annotations.dll => 0x8f3e97a7f8f8c580 => 128
	i64 10360651442923773544, ; 183: System.Text.Encoding => 0x8fc86d98211c1e68 => 155
	i64 10363495123250631811, ; 184: Xamarin.Android.Support.Collections.dll => 0x8fd287e80cd8d483 => 46
	i64 10376576884623852283, ; 185: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 113
	i64 10430153318873392755, ; 186: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 83
	i64 10566960649245365243, ; 187: System.Globalization.dll => 0x92a562b96dcd13fb => 145
	i64 10635644668885628703, ; 188: Xamarin.Android.Support.DrawerLayout.dll => 0x93996679ee34771f => 54
	i64 10714184849103829812, ; 189: System.Runtime.Extensions.dll => 0x94b06e5aa4b4bb34 => 156
	i64 10847732767863316357, ; 190: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 73
	i64 10850923258212604222, ; 191: Xamarin.Android.Arch.Lifecycle.Runtime => 0x9696393672c9593e => 41
	i64 11023048688141570732, ; 192: System.Core => 0x98f9bc61168392ac => 27
	i64 11037814507248023548, ; 193: System.Xml => 0x992e31d0412bf7fc => 34
	i64 11122995063473561350, ; 194: Xamarin.CommunityToolkit.dll => 0x9a5cd113fcc3df06 => 120
	i64 11162124722117608902, ; 195: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 118
	i64 11298161014952581172, ; 196: DevExpress.XamarinForms.Core.Android => 0x9ccb2195376a5834 => 10
	i64 11340910727871153756, ; 197: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 84
	i64 11376461258732682436, ; 198: Xamarin.Android.Support.Compat => 0x9de14f3d5fc13cc4 => 47
	i64 11392833485892708388, ; 199: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 108
	i64 11529969570048099689, ; 200: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 118
	i64 11578238080964724296, ; 201: Xamarin.AndroidX.Legacy.Support.V4 => 0xa0ae2a30c4cd8648 => 93
	i64 11580057168383206117, ; 202: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 69
	i64 11597940890313164233, ; 203: netstandard => 0xa0f429ca8d1805c9 => 132
	i64 11672361001936329215, ; 204: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 90
	i64 11739066727115742305, ; 205: SQLite-net.dll => 0xa2e98afdf8575c61 => 19
	i64 11743665907891708234, ; 206: System.Threading.Tasks => 0xa2f9e1ec30c0214a => 142
	i64 11806260347154423189, ; 207: SQLite-net => 0xa3d8433bc5eb5d95 => 19
	i64 11834399401546345650, ; 208: Xamarin.Android.Support.SlidingPaneLayout.dll => 0xa43c3b8deb43ecb2 => 61
	i64 11865714326292153359, ; 209: Xamarin.Android.Arch.Lifecycle.LiveData => 0xa4ab7c5000e8440f => 40
	i64 12102847907131387746, ; 210: System.Buffers => 0xa7f5f40c43256f62 => 26
	i64 12123043025855404482, ; 211: System.Reflection.Extensions.dll => 0xa83db366c0e359c2 => 1
	i64 12137774235383566651, ; 212: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 116
	i64 12201331334810686224, ; 213: System.Runtime.Serialization.Primitives.dll => 0xa953d6341e3bd310 => 146
	i64 12279246230491828964, ; 214: SQLitePCLRaw.provider.e_sqlite3.dll => 0xaa68a5636e0512e4 => 25
	i64 12388767885335911387, ; 215: Xamarin.Android.Arch.Lifecycle.LiveData.dll => 0xabedbec0d236dbdb => 40
	i64 12414299427252656003, ; 216: Xamarin.Android.Support.Compat.dll => 0xac48738e28bad783 => 47
	i64 12451044538927396471, ; 217: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 89
	i64 12466513435562512481, ; 218: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 100
	i64 12487638416075308985, ; 219: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 86
	i64 12538491095302438457, ; 220: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 77
	i64 12550732019250633519, ; 221: System.IO.Compression => 0xae2d28465e8e1b2f => 137
	i64 12700543734426720211, ; 222: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 78
	i64 12708238894395270091, ; 223: System.IO => 0xb05cbbf17d3ba3cb => 141
	i64 12708922737231849740, ; 224: System.Text.Encoding.Extensions => 0xb05f29e50e96e90c => 158
	i64 12775743368198558629, ; 225: DevExpress.XamarinForms.Core => 0xb14c8ee7930713a5 => 11
	i64 12900953504065120650, ; 226: DevExpress.Xamarin.Android.CollectionView => 0xb30964dc19a1e98a => 7
	i64 12952608645614506925, ; 227: Xamarin.Android.Support.Core.Utils => 0xb3c0e8eff48193ad => 50
	i64 12963446364377008305, ; 228: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 136
	i64 13266652953903600529, ; 229: BoxingProto => 0xb81c9e9263cf9391 => 5
	i64 13358059602087096138, ; 230: Xamarin.Android.Support.Fragment.dll => 0xb9615c6f1ee5af4a => 55
	i64 13370592475155966277, ; 231: System.Runtime.Serialization => 0xb98de304062ea945 => 4
	i64 13401370062847626945, ; 232: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 116
	i64 13404347523447273790, ; 233: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 80
	i64 13454009404024712428, ; 234: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 127
	i64 13465488254036897740, ; 235: Xamarin.Kotlin.StdLib => 0xbadf06394d106fcc => 130
	i64 13491513212026656886, ; 236: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 74
	i64 13572454107664307259, ; 237: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 109
	i64 13647894001087880694, ; 238: System.Data.dll => 0xbd670f48cb071df6 => 133
	i64 13713329104121190199, ; 239: System.Dynamic.Runtime => 0xbe4f8829f32b5737 => 149
	i64 13802825973146328710, ; 240: SQLiteNetExtensionsAsync => 0xbf8d7d1791ec1e86 => 21
	i64 13828521679616088467, ; 241: Xamarin.Kotlin.StdLib.Common => 0xbfe8c733724e1993 => 129
	i64 13959074834287824816, ; 242: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 89
	i64 13967638549803255703, ; 243: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 123
	i64 14124974489674258913, ; 244: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 77
	i64 14125464355221830302, ; 245: System.Threading.dll => 0xc407bafdbc707a9e => 157
	i64 14163713728554035743, ; 246: CHD.StepSlider.dll => 0xc48f9e97f2c96a1f => 6
	i64 14172845254133543601, ; 247: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 103
	i64 14254574811015963973, ; 248: System.Text.Encoding.Extensions.dll => 0xc5d26c4442d66545 => 158
	i64 14261073672896646636, ; 249: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 108
	i64 14327695147300244862, ; 250: System.Reflection.dll => 0xc6d632d338eb4d7e => 147
	i64 14369828458497533121, ; 251: Xamarin.Android.Support.Vector.Drawable => 0xc76be2d9300b64c1 => 65
	i64 14400856865250966808, ; 252: Xamarin.Android.Support.Core.UI => 0xc7da1f051a877d18 => 49
	i64 14486659737292545672, ; 253: Xamarin.AndroidX.Lifecycle.LiveData => 0xc90af44707469e88 => 96
	i64 14644440854989303794, ; 254: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 101
	i64 14661790646341542033, ; 255: Xamarin.Android.Support.SwipeRefreshLayout => 0xcb7924e94e552091 => 62
	i64 14693486184709846151, ; 256: Plugin.SimpleAudioPlayer => 0xcbe9bfd5e7bd7487 => 18
	i64 14773006529672374306, ; 257: CHD.StepSlider => 0xcd04432b01a5e822 => 6
	i64 14775236863891732915, ; 258: DevExpress.XamarinForms.CollectionView.dll => 0xcd0c2fa52885f9b3 => 9
	i64 14792063746108907174, ; 259: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 127
	i64 14852515768018889994, ; 260: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 84
	i64 14987728460634540364, ; 261: System.IO.Compression.dll => 0xcfff1ba06622494c => 137
	i64 14988210264188246988, ; 262: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 86
	i64 15076659072870671916, ; 263: System.ObjectModel.dll => 0xd13b0d8c1620662c => 152
	i64 15133485256822086103, ; 264: System.Linq.dll => 0xd204f0a9127dd9d7 => 150
	i64 15188640517174936311, ; 265: Xamarin.Android.Arch.Core.Common => 0xd2c8e413d75142f7 => 36
	i64 15234786388537674379, ; 266: System.Dynamic.Runtime.dll => 0xd36cd580c5be8a8b => 149
	i64 15246441518555807158, ; 267: Xamarin.Android.Arch.Core.Common.dll => 0xd3963dc832493db6 => 36
	i64 15326820765897713587, ; 268: Xamarin.Android.Arch.Core.Runtime.dll => 0xd4b3ce481769e7b3 => 37
	i64 15370334346939861994, ; 269: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 83
	i64 15457813392950723921, ; 270: Xamarin.Android.Support.Media.Compat => 0xd6852f61c31a8551 => 59
	i64 15526743539506359484, ; 271: System.Text.Encoding.dll => 0xd77a12fc26de2cbc => 155
	i64 15568534730848034786, ; 272: Xamarin.Android.Support.VersionedParcelable.dll => 0xd80e8bda21875fe2 => 66
	i64 15582737692548360875, ; 273: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 99
	i64 15609085926864131306, ; 274: System.dll => 0xd89e9cf3334914ea => 28
	i64 15661133872274321916, ; 275: System.Xml.ReaderWriter.dll => 0xd9578647d4bfb1fc => 154
	i64 15777549416145007739, ; 276: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 111
	i64 15810740023422282496, ; 277: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 125
	i64 15817206913877585035, ; 278: System.Threading.Tasks.dll => 0xdb8201e29086ac8b => 142
	i64 16154507427712707110, ; 279: System => 0xe03056ea4e39aa26 => 28
	i64 16242842420508142678, ; 280: Xamarin.Android.Support.CoordinaterLayout.dll => 0xe16a2b1f8908ac56 => 48
	i64 16355080029282893091, ; 281: DevExpress.XamarinForms.Core.Android.dll => 0xe2f8eaa23a7dfd23 => 10
	i64 16565028646146589191, ; 282: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 139
	i64 16621146507174665210, ; 283: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 81
	i64 16677317093839702854, ; 284: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 106
	i64 16755018182064898362, ; 285: SQLitePCLRaw.core.dll => 0xe885c843c330813a => 23
	i64 16767985610513713374, ; 286: Xamarin.Android.Arch.Core.Runtime => 0xe8b3da12798808de => 37
	i64 16822611501064131242, ; 287: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 135
	i64 16833383113903931215, ; 288: mscorlib => 0xe99c30c1484d7f4f => 15
	i64 16890310621557459193, ; 289: System.Text.RegularExpressions.dll => 0xea66700587f088f9 => 153
	i64 16932527889823454152, ; 290: Xamarin.Android.Support.Core.Utils.dll => 0xeafc6c67465253c8 => 50
	i64 17009591894298689098, ; 291: Xamarin.Android.Support.Animated.Vector.Drawable => 0xec0e35b50a097e4a => 43
	i64 17024911836938395553, ; 292: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 70
	i64 17031351772568316411, ; 293: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 104
	i64 17037200463775726619, ; 294: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 92
	i64 17383232329670771222, ; 295: Xamarin.Android.Support.CustomView.dll => 0xf13da5b41a1cc216 => 52
	i64 17428701562824544279, ; 296: Xamarin.Android.Support.Core.UI.dll => 0xf1df2fbaec73d017 => 49
	i64 17483646997724851973, ; 297: Xamarin.Android.Support.ViewPager => 0xf2a2644fe5b6ef05 => 67
	i64 17524135665394030571, ; 298: Xamarin.Android.Support.Print => 0xf3323c8a739097eb => 60
	i64 17544493274320527064, ; 299: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 75
	i64 17627500474728259406, ; 300: System.Globalization => 0xf4a176498a351f4e => 145
	i64 17666959971718154066, ; 301: Xamarin.Android.Support.CustomView => 0xf52da67d9f4e4752 => 52
	i64 17685921127322830888, ; 302: System.Diagnostics.Debug.dll => 0xf571038fafa74828 => 151
	i64 17704177640604968747, ; 303: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 100
	i64 17710060891934109755, ; 304: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 98
	i64 17760961058993581169, ; 305: Xamarin.Android.Arch.Lifecycle.Common => 0xf67b9bfb46dbac71 => 38
	i64 17838668724098252521, ; 306: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 26
	i64 17841643939744178149, ; 307: Xamarin.Android.Arch.Lifecycle.ViewModel => 0xf79a40a25573dfe5 => 42
	i64 17866241960153083370, ; 308: DevExpress.XamarinForms.CollectionView => 0xf7f1a467421a6dea => 9
	i64 17882897186074144999, ; 309: FormsViewGroup => 0xf82cd03e3ac830e7 => 12
	i64 17891337867145587222, ; 310: Xamarin.Jetbrains.Annotations => 0xf84accff6fb52a16 => 128
	i64 17892495832318972303, ; 311: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 125
	i64 17928294245072900555, ; 312: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 138
	i64 17958105683855786126, ; 313: Xamarin.Android.Arch.Lifecycle.LiveData.Core.dll => 0xf93801f92d25c08e => 39
	i64 18025913125965088385, ; 314: System.Threading => 0xfa28e87b91334681 => 157
	i64 18116111925905154859, ; 315: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 74
	i64 18121036031235206392, ; 316: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 104
	i64 18129453464017766560, ; 317: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 131
	i64 18301997741680159453, ; 318: Xamarin.Android.Support.CursorAdapter => 0xfdfdc1fa58d8eadd => 51
	i64 18305135509493619199, ; 319: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 105
	i64 18370042311372477656, ; 320: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0xfeef80274e4094d8 => 24
	i64 18380184030268848184 ; 321: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 117
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [322 x i32] [
	i32 88, i32 14, i32 148, i32 78, i32 110, i32 111, i32 42, i32 97, ; 0..7
	i32 136, i32 91, i32 0, i32 46, i32 39, i32 24, i32 87, i32 134, ; 8..15
	i32 124, i32 160, i32 126, i32 11, i32 23, i32 73, i32 55, i32 4, ; 16..23
	i32 66, i32 17, i32 25, i32 71, i32 99, i32 92, i32 16, i32 29, ; 24..31
	i32 64, i32 72, i32 110, i32 69, i32 63, i32 98, i32 120, i32 16, ; 32..39
	i32 103, i32 76, i32 0, i32 87, i32 140, i32 95, i32 32, i32 82, ; 40..47
	i32 115, i32 33, i32 68, i32 34, i32 15, i32 107, i32 32, i32 8, ; 48..55
	i32 61, i32 122, i32 54, i32 126, i32 59, i32 94, i32 70, i32 31, ; 56..63
	i32 113, i32 112, i32 30, i32 33, i32 154, i32 132, i32 109, i32 88, ; 64..71
	i32 29, i32 146, i32 148, i32 67, i32 22, i32 53, i32 45, i32 131, ; 72..79
	i32 117, i32 75, i32 68, i32 112, i32 48, i32 58, i32 2, i32 2, ; 80..87
	i32 123, i32 60, i32 121, i32 101, i32 56, i32 102, i32 115, i32 114, ; 88..95
	i32 43, i32 151, i32 81, i32 27, i32 8, i32 119, i32 79, i32 44, ; 96..103
	i32 107, i32 96, i32 62, i32 124, i32 12, i32 22, i32 21, i32 58, ; 104..111
	i32 97, i32 95, i32 65, i32 76, i32 85, i32 63, i32 140, i32 5, ; 112..119
	i32 91, i32 143, i32 35, i32 31, i32 20, i32 93, i32 90, i32 51, ; 120..127
	i32 150, i32 147, i32 35, i32 152, i32 20, i32 7, i32 122, i32 121, ; 128..135
	i32 3, i32 159, i32 130, i32 133, i32 45, i32 71, i32 64, i32 139, ; 136..143
	i32 144, i32 94, i32 44, i32 135, i32 1, i32 13, i32 144, i32 56, ; 144..151
	i32 156, i32 41, i32 80, i32 106, i32 18, i32 114, i32 13, i32 159, ; 152..159
	i32 105, i32 138, i32 57, i32 129, i32 53, i32 143, i32 119, i32 72, ; 160..167
	i32 141, i32 153, i32 30, i32 82, i32 102, i32 14, i32 79, i32 134, ; 168..175
	i32 38, i32 160, i32 3, i32 85, i32 17, i32 57, i32 128, i32 155, ; 176..183
	i32 46, i32 113, i32 83, i32 145, i32 54, i32 156, i32 73, i32 41, ; 184..191
	i32 27, i32 34, i32 120, i32 118, i32 10, i32 84, i32 47, i32 108, ; 192..199
	i32 118, i32 93, i32 69, i32 132, i32 90, i32 19, i32 142, i32 19, ; 200..207
	i32 61, i32 40, i32 26, i32 1, i32 116, i32 146, i32 25, i32 40, ; 208..215
	i32 47, i32 89, i32 100, i32 86, i32 77, i32 137, i32 78, i32 141, ; 216..223
	i32 158, i32 11, i32 7, i32 50, i32 136, i32 5, i32 55, i32 4, ; 224..231
	i32 116, i32 80, i32 127, i32 130, i32 74, i32 109, i32 133, i32 149, ; 232..239
	i32 21, i32 129, i32 89, i32 123, i32 77, i32 157, i32 6, i32 103, ; 240..247
	i32 158, i32 108, i32 147, i32 65, i32 49, i32 96, i32 101, i32 62, ; 248..255
	i32 18, i32 6, i32 9, i32 127, i32 84, i32 137, i32 86, i32 152, ; 256..263
	i32 150, i32 36, i32 149, i32 36, i32 37, i32 83, i32 59, i32 155, ; 264..271
	i32 66, i32 99, i32 28, i32 154, i32 111, i32 125, i32 142, i32 28, ; 272..279
	i32 48, i32 10, i32 139, i32 81, i32 106, i32 23, i32 37, i32 135, ; 280..287
	i32 15, i32 153, i32 50, i32 43, i32 70, i32 104, i32 92, i32 52, ; 288..295
	i32 49, i32 67, i32 60, i32 75, i32 145, i32 52, i32 151, i32 100, ; 296..303
	i32 98, i32 38, i32 26, i32 42, i32 9, i32 12, i32 128, i32 125, ; 304..311
	i32 138, i32 39, i32 157, i32 74, i32 104, i32 131, i32 51, i32 105, ; 312..319
	i32 24, i32 117 ; 320..321
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="non-leaf" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
