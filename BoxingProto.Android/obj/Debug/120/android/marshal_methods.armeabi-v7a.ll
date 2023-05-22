; ModuleID = 'obj\Debug\120\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Debug\120\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [322 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 97
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 127
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 16
	i32 57263871, ; 3: Xamarin.Forms.Core.dll => 0x369c6ff => 122
	i32 57967248, ; 4: Xamarin.Android.Support.VersionedParcelable.dll => 0x3748290 => 66
	i32 101534019, ; 5: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 111
	i32 102832730, ; 6: Plugin.SimpleAudioPlayer => 0x6211a5a => 18
	i32 120558881, ; 7: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 111
	i32 160529393, ; 8: Xamarin.Android.Arch.Core.Common => 0x9917bf1 => 36
	i32 165246403, ; 9: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 78
	i32 166922606, ; 10: Xamarin.Android.Support.Compat.dll => 0x9f3096e => 47
	i32 182336117, ; 11: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 112
	i32 201930040, ; 12: Xamarin.Android.Arch.Core.Runtime => 0xc093538 => 37
	i32 209399409, ; 13: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 76
	i32 219130465, ; 14: Xamarin.Android.Support.v4 => 0xd0faa61 => 63
	i32 220171995, ; 15: System.Diagnostics.Debug => 0xd1f8edb => 151
	i32 230216969, ; 16: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 92
	i32 230752869, ; 17: Microsoft.CSharp.dll => 0xdc10265 => 159
	i32 231814094, ; 18: System.Globalization => 0xdd133ce => 145
	i32 232815796, ; 19: System.Web.Services => 0xde07cb4 => 140
	i32 261689757, ; 20: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 81
	i32 278686392, ; 21: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 96
	i32 280482487, ; 22: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 90
	i32 318968648, ; 23: Xamarin.AndroidX.Activity.dll => 0x13031348 => 68
	i32 321597661, ; 24: System.Numerics => 0x132b30dd => 30
	i32 342366114, ; 25: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 94
	i32 347068432, ; 26: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0x14afd810 => 24
	i32 385762202, ; 27: System.Memory.dll => 0x16fe439a => 29
	i32 388313361, ; 28: Xamarin.Android.Support.Animated.Vector.Drawable => 0x17253111 => 43
	i32 389971796, ; 29: Xamarin.Android.Support.Core.UI => 0x173e7f54 => 49
	i32 441335492, ; 30: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 80
	i32 442521989, ; 31: Xamarin.Essentials => 0x1a605985 => 121
	i32 442565967, ; 32: System.Collections => 0x1a61054f => 144
	i32 450948140, ; 33: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 89
	i32 459347974, ; 34: System.Runtime.Serialization.Primitives.dll => 0x1b611806 => 146
	i32 465846621, ; 35: mscorlib => 0x1bc4415d => 15
	i32 469710990, ; 36: System.dll => 0x1bff388e => 28
	i32 476646585, ; 37: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 90
	i32 486930444, ; 38: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 101
	i32 498788369, ; 39: System.ObjectModel => 0x1dbae811 => 152
	i32 514659665, ; 40: Xamarin.Android.Support.Compat => 0x1ead1551 => 47
	i32 524864063, ; 41: Xamarin.Android.Support.Print => 0x1f48ca3f => 60
	i32 526420162, ; 42: System.Transactions.dll => 0x1f6088c2 => 134
	i32 545304856, ; 43: System.Runtime.Extensions => 0x2080b118 => 156
	i32 605376203, ; 44: System.IO.Compression.FileSystem => 0x24154ecb => 138
	i32 627609679, ; 45: Xamarin.AndroidX.CustomView => 0x2568904f => 85
	i32 663517072, ; 46: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 117
	i32 666292255, ; 47: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 73
	i32 690569205, ; 48: System.Xml.Linq.dll => 0x29293ff5 => 35
	i32 692692150, ; 49: Xamarin.Android.Support.Annotations => 0x2949a4b6 => 44
	i32 700284507, ; 50: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 128
	i32 734269858, ; 51: BoxingProto.Android => 0x2bc411a2 => 0
	i32 748832960, ; 52: SQLitePCLRaw.batteries_v2 => 0x2ca248c0 => 22
	i32 775507847, ; 53: System.IO.Compression => 0x2e394f87 => 137
	i32 800472933, ; 54: SQLiteNetExtensionsAsync => 0x2fb63f65 => 21
	i32 801787702, ; 55: Xamarin.Android.Support.Interpolator => 0x2fca4f36 => 56
	i32 809851609, ; 56: System.Drawing.Common.dll => 0x30455ad9 => 136
	i32 843511501, ; 57: Xamarin.AndroidX.Print => 0x3246f6cd => 108
	i32 877678880, ; 58: System.Globalization.dll => 0x34505120 => 145
	i32 882883187, ; 59: Xamarin.Android.Support.v4.dll => 0x349fba73 => 63
	i32 916714535, ; 60: Xamarin.Android.Support.Print.dll => 0x36a3f427 => 60
	i32 928116545, ; 61: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 127
	i32 936632277, ; 62: DevExpress.XamarinForms.CollectionView => 0x37d3dfd5 => 9
	i32 955402788, ; 63: Newtonsoft.Json => 0x38f24a24 => 16
	i32 958213972, ; 64: Xamarin.Android.Support.Media.Compat => 0x391d2f54 => 59
	i32 967690846, ; 65: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 94
	i32 974778368, ; 66: FormsViewGroup.dll => 0x3a19f000 => 12
	i32 975874589, ; 67: System.Xml.XDocument => 0x3a2aaa1d => 143
	i32 987342438, ; 68: Xamarin.Android.Arch.Lifecycle.LiveData.dll => 0x3ad9a666 => 40
	i32 992768348, ; 69: System.Collections.dll => 0x3b2c715c => 144
	i32 996170219, ; 70: Plugin.SimpleAudioPlayer.Abstractions => 0x3b6059eb => 17
	i32 1012816738, ; 71: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 110
	i32 1035644815, ; 72: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 72
	i32 1039530251, ; 73: CHD.StepSlider => 0x3df5f90b => 6
	i32 1042160112, ; 74: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 124
	i32 1044663988, ; 75: System.Linq.Expressions.dll => 0x3e444eb4 => 148
	i32 1052210849, ; 76: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 98
	i32 1084122840, ; 77: Xamarin.Kotlin.StdLib => 0x409e66d8 => 130
	i32 1098167829, ; 78: Xamarin.Android.Arch.Lifecycle.ViewModel => 0x4174b615 => 42
	i32 1098259244, ; 79: System => 0x41761b2c => 28
	i32 1175144683, ; 80: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 115
	i32 1178241025, ; 81: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 105
	i32 1204270330, ; 82: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 73
	i32 1267360935, ; 83: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 116
	i32 1292207520, ; 84: SQLitePCLRaw.core.dll => 0x4d0585a0 => 23
	i32 1292763917, ; 85: Xamarin.Android.Support.CursorAdapter.dll => 0x4d0e030d => 51
	i32 1293217323, ; 86: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 87
	i32 1297413738, ; 87: Xamarin.Android.Arch.Lifecycle.LiveData.Core => 0x4d54f66a => 39
	i32 1324164729, ; 88: System.Linq => 0x4eed2679 => 150
	i32 1364015309, ; 89: System.IO => 0x514d38cd => 141
	i32 1365406463, ; 90: System.ServiceModel.Internals.dll => 0x516272ff => 131
	i32 1376866003, ; 91: Xamarin.AndroidX.SavedState => 0x52114ed3 => 110
	i32 1379779777, ; 92: System.Resources.ResourceManager => 0x523dc4c1 => 2
	i32 1395857551, ; 93: Xamarin.AndroidX.Media.dll => 0x5333188f => 102
	i32 1406073936, ; 94: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 82
	i32 1411638395, ; 95: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 32
	i32 1445445088, ; 96: Xamarin.Android.Support.Fragment => 0x5627bde0 => 55
	i32 1451498148, ; 97: DevExpress.XamarinForms.Core.dll => 0x56841aa4 => 11
	i32 1455166989, ; 98: DevExpress.Xamarin.Android.CollectionView.dll => 0x56bc160d => 7
	i32 1457743152, ; 99: System.Runtime.Extensions.dll => 0x56e36530 => 156
	i32 1460219004, ; 100: Xamarin.Forms.Xaml => 0x57092c7c => 125
	i32 1462112819, ; 101: System.IO.Compression.dll => 0x57261233 => 137
	i32 1469204771, ; 102: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 71
	i32 1543031311, ; 103: System.Text.RegularExpressions.dll => 0x5bf8ca0f => 153
	i32 1550322496, ; 104: System.Reflection.Extensions.dll => 0x5c680b40 => 1
	i32 1574652163, ; 105: Xamarin.Android.Support.Core.Utils.dll => 0x5ddb4903 => 50
	i32 1581342938, ; 106: DevExpress.XamarinForms.Core.Android.dll => 0x5e4160da => 10
	i32 1582372066, ; 107: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 86
	i32 1587447679, ; 108: Xamarin.Android.Arch.Core.Common.dll => 0x5e9e877f => 36
	i32 1592978981, ; 109: System.Runtime.Serialization.dll => 0x5ef2ee25 => 4
	i32 1604451928, ; 110: SQLiteNetExtensions => 0x5fa1fe58 => 20
	i32 1622152042, ; 111: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 100
	i32 1622358360, ; 112: System.Dynamic.Runtime => 0x60b33958 => 149
	i32 1624863272, ; 113: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 119
	i32 1626988262, ; 114: Plugin.SimpleAudioPlayer.Abstractions.dll => 0x60f9dee6 => 17
	i32 1636350590, ; 115: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 84
	i32 1639515021, ; 116: System.Net.Http.dll => 0x61b9038d => 3
	i32 1639986890, ; 117: System.Text.RegularExpressions => 0x61c036ca => 153
	i32 1657153582, ; 118: System.Runtime => 0x62c6282e => 33
	i32 1658241508, ; 119: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 113
	i32 1658251792, ; 120: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 126
	i32 1662014763, ; 121: Xamarin.Android.Support.Vector.Drawable => 0x6310552b => 65
	i32 1666713512, ; 122: SQLiteNetExtensions.dll => 0x635807a8 => 20
	i32 1670060433, ; 123: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 81
	i32 1698840827, ; 124: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 129
	i32 1701541528, ; 125: System.Diagnostics.Debug.dll => 0x656b7698 => 151
	i32 1711441057, ; 126: SQLitePCLRaw.lib.e_sqlite3.android => 0x660284a1 => 24
	i32 1726116996, ; 127: System.Reflection.dll => 0x66e27484 => 147
	i32 1729485958, ; 128: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 77
	i32 1765942094, ; 129: System.Reflection.Extensions => 0x6942234e => 1
	i32 1766324549, ; 130: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 112
	i32 1776026572, ; 131: System.Core.dll => 0x69dc03cc => 27
	i32 1788241197, ; 132: Xamarin.AndroidX.Fragment => 0x6a96652d => 89
	i32 1808609942, ; 133: Xamarin.AndroidX.Loader => 0x6bcd3296 => 100
	i32 1813058853, ; 134: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 130
	i32 1813201214, ; 135: Xamarin.Google.Android.Material => 0x6c13413e => 126
	i32 1818569960, ; 136: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 106
	i32 1824175904, ; 137: System.Text.Encoding.Extensions => 0x6cbab720 => 158
	i32 1858542181, ; 138: System.Linq.Expressions => 0x6ec71a65 => 148
	i32 1866717392, ; 139: Xamarin.Android.Support.Interpolator.dll => 0x6f43d8d0 => 56
	i32 1867746548, ; 140: Xamarin.Essentials.dll => 0x6f538cf4 => 121
	i32 1872127555, ; 141: DevExpress.XamarinForms.Core.Android => 0x6f966643 => 10
	i32 1878053835, ; 142: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 125
	i32 1885316902, ; 143: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 74
	i32 1900610850, ; 144: System.Resources.ResourceManager.dll => 0x71490522 => 2
	i32 1916660109, ; 145: Xamarin.Android.Arch.Lifecycle.ViewModel.dll => 0x723de98d => 42
	i32 1919157823, ; 146: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 103
	i32 1983156543, ; 147: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 129
	i32 2011961780, ; 148: System.Buffers.dll => 0x77ec19b4 => 26
	i32 2019465201, ; 149: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 98
	i32 2037417872, ; 150: Xamarin.Android.Support.ViewPager => 0x79708790 => 67
	i32 2044222327, ; 151: Xamarin.Android.Support.Loader => 0x79d85b77 => 57
	i32 2055257422, ; 152: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 95
	i32 2079903147, ; 153: System.Runtime.dll => 0x7bf8cdab => 33
	i32 2090596640, ; 154: System.Numerics.Vectors => 0x7c9bf920 => 31
	i32 2097448633, ; 155: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 91
	i32 2103459038, ; 156: SQLitePCLRaw.provider.e_sqlite3.dll => 0x7d603cde => 25
	i32 2126786730, ; 157: Xamarin.Forms.Platform.Android => 0x7ec430aa => 123
	i32 2139458754, ; 158: Xamarin.Android.Support.DrawerLayout => 0x7f858cc2 => 54
	i32 2166116741, ; 159: Xamarin.Android.Support.Core.Utils => 0x811c5185 => 50
	i32 2193016926, ; 160: System.ObjectModel.dll => 0x82b6c85e => 152
	i32 2196165013, ; 161: Xamarin.Android.Support.VersionedParcelable => 0x82e6d195 => 66
	i32 2201231467, ; 162: System.Net.Http => 0x8334206b => 3
	i32 2217644978, ; 163: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 115
	i32 2244775296, ; 164: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 101
	i32 2256548716, ; 165: Xamarin.AndroidX.MultiDex => 0x8680336c => 103
	i32 2261435625, ; 166: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 93
	i32 2279755925, ; 167: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 109
	i32 2287417322, ; 168: Plugin.SimpleAudioPlayer.dll => 0x885737ea => 18
	i32 2315684594, ; 169: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 69
	i32 2323008830, ; 170: DevExpress.XamarinForms.CollectionView.Android.dll => 0x8a764d3e => 8
	i32 2330457430, ; 171: Xamarin.Android.Support.Core.UI.dll => 0x8ae7f556 => 49
	i32 2330986192, ; 172: Xamarin.Android.Support.SlidingPaneLayout.dll => 0x8af006d0 => 61
	i32 2368005991, ; 173: System.Xml.ReaderWriter.dll => 0x8d24e767 => 154
	i32 2373288475, ; 174: Xamarin.Android.Support.Fragment.dll => 0x8d75821b => 55
	i32 2409053734, ; 175: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 107
	i32 2440966767, ; 176: Xamarin.Android.Support.Loader.dll => 0x917e326f => 57
	i32 2454642406, ; 177: System.Text.Encoding.dll => 0x924edee6 => 155
	i32 2465273461, ; 178: SQLitePCLRaw.batteries_v2.dll => 0x92f11675 => 22
	i32 2465532216, ; 179: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 80
	i32 2471841756, ; 180: netstandard.dll => 0x93554fdc => 132
	i32 2475788418, ; 181: Java.Interop.dll => 0x93918882 => 13
	i32 2487632829, ; 182: Xamarin.Android.Support.DocumentFile => 0x944643bd => 53
	i32 2501346920, ; 183: System.Data.DataSetExtensions => 0x95178668 => 135
	i32 2505896520, ; 184: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 97
	i32 2542131234, ; 185: BoxingProto.dll => 0x9785d822 => 5
	i32 2562349572, ; 186: Microsoft.CSharp => 0x98ba5a04 => 159
	i32 2581819634, ; 187: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 116
	i32 2585220780, ; 188: System.Text.Encoding.Extensions.dll => 0x9a1756ac => 158
	i32 2620871830, ; 189: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 84
	i32 2624644809, ; 190: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 88
	i32 2633051222, ; 191: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 96
	i32 2664396074, ; 192: System.Xml.XDocument.dll => 0x9ecf752a => 143
	i32 2684512982, ; 193: DevExpress.XamarinForms.Core => 0xa0026ad6 => 11
	i32 2693849962, ; 194: System.IO.dll => 0xa090e36a => 141
	i32 2698266930, ; 195: Xamarin.Android.Arch.Lifecycle.LiveData => 0xa0d44932 => 40
	i32 2701096212, ; 196: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 113
	i32 2715334215, ; 197: System.Threading.Tasks.dll => 0xa1d8b647 => 142
	i32 2732626843, ; 198: Xamarin.AndroidX.Activity => 0xa2e0939b => 68
	i32 2737747696, ; 199: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 71
	i32 2751899777, ; 200: Xamarin.Android.Support.Collections => 0xa406a881 => 46
	i32 2766581644, ; 201: Xamarin.Forms.Core => 0xa4e6af8c => 122
	i32 2770495804, ; 202: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 128
	i32 2778351058, ; 203: DevExpress.XamarinForms.CollectionView.Android => 0xa59a45d2 => 8
	i32 2778768386, ; 204: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 118
	i32 2788639665, ; 205: Xamarin.Android.Support.LocalBroadcastManager => 0xa63743b1 => 58
	i32 2788775637, ; 206: Xamarin.Android.Support.SwipeRefreshLayout.dll => 0xa63956d5 => 62
	i32 2810250172, ; 207: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 82
	i32 2819470561, ; 208: System.Xml.dll => 0xa80db4e1 => 34
	i32 2853208004, ; 209: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 118
	i32 2855708567, ; 210: Xamarin.AndroidX.Transition => 0xaa36a797 => 114
	i32 2876493027, ; 211: Xamarin.Android.Support.SwipeRefreshLayout => 0xab73cce3 => 62
	i32 2893257763, ; 212: Xamarin.Android.Arch.Core.Runtime.dll => 0xac739c23 => 37
	i32 2900621748, ; 213: System.Dynamic.Runtime.dll => 0xace3f9b4 => 149
	i32 2901442782, ; 214: System.Reflection => 0xacf080de => 147
	i32 2903344695, ; 215: System.ComponentModel.Composition => 0xad0d8637 => 139
	i32 2905242038, ; 216: mscorlib.dll => 0xad2a79b6 => 15
	i32 2916838712, ; 217: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 119
	i32 2919462931, ; 218: System.Numerics.Vectors.dll => 0xae037813 => 31
	i32 2921128767, ; 219: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 70
	i32 2921692953, ; 220: Xamarin.Android.Support.CustomView.dll => 0xae257f19 => 52
	i32 2922925221, ; 221: Xamarin.Android.Support.Vector.Drawable.dll => 0xae384ca5 => 65
	i32 2978675010, ; 222: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 87
	i32 3024354802, ; 223: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 92
	i32 3044182254, ; 224: FormsViewGroup => 0xb57288ee => 12
	i32 3056250942, ; 225: Xamarin.Android.Support.AsyncLayoutInflater.dll => 0xb62ab03e => 45
	i32 3057625584, ; 226: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 104
	i32 3068715062, ; 227: Xamarin.Android.Arch.Lifecycle.Common => 0xb6e8e036 => 38
	i32 3075834255, ; 228: System.Threading.Tasks => 0xb755818f => 142
	i32 3092211740, ; 229: Xamarin.Android.Support.Media.Compat.dll => 0xb84f681c => 59
	i32 3111772706, ; 230: System.Runtime.Serialization => 0xb979e222 => 4
	i32 3204380047, ; 231: System.Data.dll => 0xbefef58f => 133
	i32 3204912593, ; 232: Xamarin.Android.Support.AsyncLayoutInflater => 0xbf0715d1 => 45
	i32 3211777861, ; 233: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 86
	i32 3220365878, ; 234: System.Threading => 0xbff2e236 => 157
	i32 3233339011, ; 235: Xamarin.Android.Arch.Lifecycle.LiveData.Core.dll => 0xc0b8d683 => 39
	i32 3247949154, ; 236: Mono.Security => 0xc197c562 => 160
	i32 3258312781, ; 237: Xamarin.AndroidX.CardView => 0xc235e84d => 77
	i32 3267021929, ; 238: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 75
	i32 3286872994, ; 239: SQLite-net.dll => 0xc3e9b3a2 => 19
	i32 3296380511, ; 240: Xamarin.Android.Support.Collections.dll => 0xc47ac65f => 46
	i32 3299363146, ; 241: System.Text.Encoding => 0xc4a8494a => 155
	i32 3317135071, ; 242: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 85
	i32 3317144872, ; 243: System.Data => 0xc5b79d28 => 133
	i32 3321585405, ; 244: Xamarin.Android.Support.DocumentFile.dll => 0xc5fb5efd => 53
	i32 3340431453, ; 245: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 74
	i32 3346324047, ; 246: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 105
	i32 3352662376, ; 247: Xamarin.Android.Support.CoordinaterLayout => 0xc7d59168 => 48
	i32 3353484488, ; 248: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 91
	i32 3353544232, ; 249: Xamarin.CommunityToolkit.dll => 0xc7e30628 => 120
	i32 3357663996, ; 250: Xamarin.Android.Support.CursorAdapter => 0xc821e2fc => 51
	i32 3360279109, ; 251: SQLitePCLRaw.core => 0xc849ca45 => 23
	i32 3362522851, ; 252: Xamarin.AndroidX.Core => 0xc86c06e3 => 83
	i32 3366347497, ; 253: Java.Interop => 0xc8a662e9 => 13
	i32 3374999561, ; 254: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 109
	i32 3395150330, ; 255: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 32
	i32 3402652849, ; 256: BoxingProto.Android.dll => 0xcad05cb1 => 0
	i32 3404865022, ; 257: System.ServiceModel.Internals => 0xcaf21dfe => 131
	i32 3407215217, ; 258: Xamarin.CommunityToolkit => 0xcb15fa71 => 120
	i32 3429136800, ; 259: System.Xml => 0xcc6479a0 => 34
	i32 3430777524, ; 260: netstandard => 0xcc7d82b4 => 132
	i32 3439690031, ; 261: Xamarin.Android.Support.Annotations.dll => 0xcd05812f => 44
	i32 3441283291, ; 262: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 88
	i32 3476120550, ; 263: Mono.Android => 0xcf3163e6 => 14
	i32 3486566296, ; 264: System.Transactions => 0xcfd0c798 => 134
	i32 3493954962, ; 265: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 79
	i32 3501239056, ; 266: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 75
	i32 3509114376, ; 267: System.Xml.Linq => 0xd128d608 => 35
	i32 3536029504, ; 268: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 123
	i32 3547625832, ; 269: Xamarin.Android.Support.SlidingPaneLayout => 0xd3747968 => 61
	i32 3567349600, ; 270: System.ComponentModel.Composition.dll => 0xd4a16f60 => 139
	i32 3588335826, ; 271: DevExpress.Xamarin.Android.CollectionView => 0xd5e1a8d2 => 7
	i32 3608519521, ; 272: System.Linq.dll => 0xd715a361 => 150
	i32 3618140916, ; 273: Xamarin.AndroidX.Preference => 0xd7a872f4 => 107
	i32 3627220390, ; 274: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 108
	i32 3632359727, ; 275: Xamarin.Forms.Platform => 0xd881692f => 124
	i32 3633644679, ; 276: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 70
	i32 3641597786, ; 277: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 95
	i32 3664423555, ; 278: Xamarin.Android.Support.ViewPager.dll => 0xda6aaa83 => 67
	i32 3672681054, ; 279: Mono.Android.dll => 0xdae8aa5e => 14
	i32 3676310014, ; 280: System.Web.Services.dll => 0xdb2009fe => 140
	i32 3678221644, ; 281: Xamarin.Android.Support.v7.AppCompat => 0xdb3d354c => 64
	i32 3681174138, ; 282: Xamarin.Android.Arch.Lifecycle.Common.dll => 0xdb6a427a => 38
	i32 3682565725, ; 283: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 76
	i32 3684561358, ; 284: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 79
	i32 3689375977, ; 285: System.Drawing.Common => 0xdbe768e9 => 136
	i32 3714038699, ; 286: Xamarin.Android.Support.LocalBroadcastManager.dll => 0xdd5fbbab => 58
	i32 3718463572, ; 287: Xamarin.Android.Support.Animated.Vector.Drawable.dll => 0xdda34054 => 43
	i32 3718780102, ; 288: Xamarin.AndroidX.Annotation => 0xdda814c6 => 69
	i32 3724971120, ; 289: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 104
	i32 3754567612, ; 290: SQLitePCLRaw.provider.e_sqlite3 => 0xdfca27bc => 25
	i32 3758932259, ; 291: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 93
	i32 3776062606, ; 292: Xamarin.Android.Support.DrawerLayout.dll => 0xe112248e => 54
	i32 3786282454, ; 293: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 78
	i32 3822602673, ; 294: Xamarin.AndroidX.Media => 0xe3d849b1 => 102
	i32 3829621856, ; 295: System.Numerics.dll => 0xe4436460 => 30
	i32 3832731800, ; 296: Xamarin.Android.Support.CoordinaterLayout.dll => 0xe472d898 => 48
	i32 3857743245, ; 297: BoxingProto => 0xe5f07d8d => 5
	i32 3862817207, ; 298: Xamarin.Android.Arch.Lifecycle.Runtime.dll => 0xe63de9b7 => 41
	i32 3874897629, ; 299: Xamarin.Android.Arch.Lifecycle.Runtime => 0xe6f63edd => 41
	i32 3876362041, ; 300: SQLite-net => 0xe70c9739 => 19
	i32 3883175360, ; 301: Xamarin.Android.Support.v7.AppCompat.dll => 0xe7748dc0 => 64
	i32 3885922214, ; 302: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 114
	i32 3896760992, ; 303: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 83
	i32 3920810846, ; 304: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 138
	i32 3921031405, ; 305: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 117
	i32 3928044579, ; 306: System.Xml.ReaderWriter => 0xea213423 => 154
	i32 3931092270, ; 307: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 106
	i32 3945713374, ; 308: System.Data.DataSetExtensions.dll => 0xeb2ecede => 135
	i32 3955647286, ; 309: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 72
	i32 4025784931, ; 310: System.Memory => 0xeff49a63 => 29
	i32 4063435586, ; 311: Xamarin.Android.Support.CustomView => 0xf2331b42 => 52
	i32 4073602200, ; 312: System.Threading.dll => 0xf2ce3c98 => 157
	i32 4087494849, ; 313: SQLiteNetExtensionsAsync.dll => 0xf3a238c1 => 21
	i32 4091549906, ; 314: CHD.StepSlider.dll => 0xf3e018d2 => 6
	i32 4105002889, ; 315: Mono.Security.dll => 0xf4ad5f89 => 160
	i32 4151237749, ; 316: System.Core => 0xf76edc75 => 27
	i32 4181436372, ; 317: System.Runtime.Serialization.Primitives => 0xf93ba7d4 => 146
	i32 4182413190, ; 318: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 99
	i32 4260525087, ; 319: System.Buffers => 0xfdf2741f => 26
	i32 4267535345, ; 320: DevExpress.XamarinForms.CollectionView.dll => 0xfe5d6bf1 => 9
	i32 4292120959 ; 321: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 99
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [322 x i32] [
	i32 97, i32 127, i32 16, i32 122, i32 66, i32 111, i32 18, i32 111, ; 0..7
	i32 36, i32 78, i32 47, i32 112, i32 37, i32 76, i32 63, i32 151, ; 8..15
	i32 92, i32 159, i32 145, i32 140, i32 81, i32 96, i32 90, i32 68, ; 16..23
	i32 30, i32 94, i32 24, i32 29, i32 43, i32 49, i32 80, i32 121, ; 24..31
	i32 144, i32 89, i32 146, i32 15, i32 28, i32 90, i32 101, i32 152, ; 32..39
	i32 47, i32 60, i32 134, i32 156, i32 138, i32 85, i32 117, i32 73, ; 40..47
	i32 35, i32 44, i32 128, i32 0, i32 22, i32 137, i32 21, i32 56, ; 48..55
	i32 136, i32 108, i32 145, i32 63, i32 60, i32 127, i32 9, i32 16, ; 56..63
	i32 59, i32 94, i32 12, i32 143, i32 40, i32 144, i32 17, i32 110, ; 64..71
	i32 72, i32 6, i32 124, i32 148, i32 98, i32 130, i32 42, i32 28, ; 72..79
	i32 115, i32 105, i32 73, i32 116, i32 23, i32 51, i32 87, i32 39, ; 80..87
	i32 150, i32 141, i32 131, i32 110, i32 2, i32 102, i32 82, i32 32, ; 88..95
	i32 55, i32 11, i32 7, i32 156, i32 125, i32 137, i32 71, i32 153, ; 96..103
	i32 1, i32 50, i32 10, i32 86, i32 36, i32 4, i32 20, i32 100, ; 104..111
	i32 149, i32 119, i32 17, i32 84, i32 3, i32 153, i32 33, i32 113, ; 112..119
	i32 126, i32 65, i32 20, i32 81, i32 129, i32 151, i32 24, i32 147, ; 120..127
	i32 77, i32 1, i32 112, i32 27, i32 89, i32 100, i32 130, i32 126, ; 128..135
	i32 106, i32 158, i32 148, i32 56, i32 121, i32 10, i32 125, i32 74, ; 136..143
	i32 2, i32 42, i32 103, i32 129, i32 26, i32 98, i32 67, i32 57, ; 144..151
	i32 95, i32 33, i32 31, i32 91, i32 25, i32 123, i32 54, i32 50, ; 152..159
	i32 152, i32 66, i32 3, i32 115, i32 101, i32 103, i32 93, i32 109, ; 160..167
	i32 18, i32 69, i32 8, i32 49, i32 61, i32 154, i32 55, i32 107, ; 168..175
	i32 57, i32 155, i32 22, i32 80, i32 132, i32 13, i32 53, i32 135, ; 176..183
	i32 97, i32 5, i32 159, i32 116, i32 158, i32 84, i32 88, i32 96, ; 184..191
	i32 143, i32 11, i32 141, i32 40, i32 113, i32 142, i32 68, i32 71, ; 192..199
	i32 46, i32 122, i32 128, i32 8, i32 118, i32 58, i32 62, i32 82, ; 200..207
	i32 34, i32 118, i32 114, i32 62, i32 37, i32 149, i32 147, i32 139, ; 208..215
	i32 15, i32 119, i32 31, i32 70, i32 52, i32 65, i32 87, i32 92, ; 216..223
	i32 12, i32 45, i32 104, i32 38, i32 142, i32 59, i32 4, i32 133, ; 224..231
	i32 45, i32 86, i32 157, i32 39, i32 160, i32 77, i32 75, i32 19, ; 232..239
	i32 46, i32 155, i32 85, i32 133, i32 53, i32 74, i32 105, i32 48, ; 240..247
	i32 91, i32 120, i32 51, i32 23, i32 83, i32 13, i32 109, i32 32, ; 248..255
	i32 0, i32 131, i32 120, i32 34, i32 132, i32 44, i32 88, i32 14, ; 256..263
	i32 134, i32 79, i32 75, i32 35, i32 123, i32 61, i32 139, i32 7, ; 264..271
	i32 150, i32 107, i32 108, i32 124, i32 70, i32 95, i32 67, i32 14, ; 272..279
	i32 140, i32 64, i32 38, i32 76, i32 79, i32 136, i32 58, i32 43, ; 280..287
	i32 69, i32 104, i32 25, i32 93, i32 54, i32 78, i32 102, i32 30, ; 288..295
	i32 48, i32 5, i32 41, i32 41, i32 19, i32 64, i32 114, i32 83, ; 296..303
	i32 138, i32 117, i32 154, i32 106, i32 135, i32 72, i32 29, i32 52, ; 304..311
	i32 157, i32 21, i32 6, i32 160, i32 27, i32 146, i32 99, i32 26, ; 312..319
	i32 9, i32 99 ; 320..321
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
