using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Gms.Plus.Model.Moments {

	[global::Android.Runtime.Register ("com/google/android/gms/plus/model/moments/MomentBuffer", DoNotGenerateAcw=true)]
	public sealed partial class MomentBuffer : global::Com.Google.Android.Gms.Common.Data.DataBuffer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/gms/plus/model/moments/MomentBuffer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MomentBuffer); }
		}

		internal MomentBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_android_gms_common_data_DataHolder_;
		[Register (".ctor", "(Lcom/google/android/gms/common/data/DataHolder;)V", "")]
		public MomentBuffer (global::Com.Google.Android.Gms.Common.Data.DataHolder p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MomentBuffer)) {
				SetHandle (global::Android.Runtime.JNIEnv.CreateInstance (GetType (), "(Lcom/google/android/gms/common/data/DataHolder;)V", new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return;
			}

			if (id_ctor_Lcom_google_android_gms_common_data_DataHolder_ == IntPtr.Zero)
				id_ctor_Lcom_google_android_gms_common_data_DataHolder_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/android/gms/common/data/DataHolder;)V");
			SetHandle (JNIEnv.NewObject (class_ref, id_ctor_Lcom_google_android_gms_common_data_DataHolder_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_get_I;
		[Register ("get", "(I)Lcom/google/android/gms/plus/model/moments/Moment;", "")]

 		public override global::Com.Google.Android.Gms.Plus.Model.Moments.IMoment Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Lcom/google/android/gms/plus/model/moments/Moment;");
			return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Gms.Plus.Model.Moments.IMoment> (JNIEnv.CallObjectMethod  (Handle, id_get_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}
	}
}