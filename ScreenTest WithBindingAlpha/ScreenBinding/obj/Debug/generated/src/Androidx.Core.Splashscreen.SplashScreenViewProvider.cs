using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Androidx.Core.Splashscreen {

	// Metadata.xml XPath class reference: path="/api/package[@name='androidx.core.splashscreen']/class[@name='SplashScreenViewProvider']"
	[global::Android.Runtime.Register ("androidx/core/splashscreen/SplashScreenViewProvider", DoNotGenerateAcw=true)]
	public sealed partial class SplashScreenViewProvider : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("androidx/core/splashscreen/SplashScreenViewProvider", typeof (SplashScreenViewProvider));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal SplashScreenViewProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe long IconAnimationDurationMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='androidx.core.splashscreen']/class[@name='SplashScreenViewProvider']/method[@name='getIconAnimationDurationMillis' and count(parameter)=0]"
			[Register ("getIconAnimationDurationMillis", "()J", "")]
			get {
				const string __id = "getIconAnimationDurationMillis.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long IconAnimationStartMillis {
			// Metadata.xml XPath method reference: path="/api/package[@name='androidx.core.splashscreen']/class[@name='SplashScreenViewProvider']/method[@name='getIconAnimationStartMillis' and count(parameter)=0]"
			[Register ("getIconAnimationStartMillis", "()J", "")]
			get {
				const string __id = "getIconAnimationStartMillis.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Android.Views.View IconView {
			// Metadata.xml XPath method reference: path="/api/package[@name='androidx.core.splashscreen']/class[@name='SplashScreenViewProvider']/method[@name='getIconView' and count(parameter)=0]"
			[Register ("getIconView", "()Landroid/view/View;", "")]
			get {
				const string __id = "getIconView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Android.Views.View View {
			// Metadata.xml XPath method reference: path="/api/package[@name='androidx.core.splashscreen']/class[@name='SplashScreenViewProvider']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "")]
			get {
				const string __id = "getView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='androidx.core.splashscreen']/class[@name='SplashScreenViewProvider']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "")]
		public unsafe void Remove ()
		{
			const string __id = "remove.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
