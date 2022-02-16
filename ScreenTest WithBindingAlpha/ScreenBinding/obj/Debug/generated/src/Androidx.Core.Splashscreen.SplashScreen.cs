using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Androidx.Core.Splashscreen {

	// Metadata.xml XPath class reference: path="/api/package[@name='androidx.core.splashscreen']/class[@name='SplashScreen']"
	[global::Android.Runtime.Register ("androidx/core/splashscreen/SplashScreen", DoNotGenerateAcw=true)]
	public sealed partial class SplashScreen : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='androidx.core.splashscreen']/class[@name='SplashScreen.Companion']"
		[global::Android.Runtime.Register ("androidx/core/splashscreen/SplashScreen$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("androidx/core/splashscreen/SplashScreen$Companion", typeof (Companion));

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

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='androidx.core.splashscreen']/class[@name='SplashScreen.Companion']/method[@name='installSplashScreen' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register ("installSplashScreen", "(Landroid/app/Activity;)Landroidx/core/splashscreen/SplashScreen;", "")]
			public unsafe global::Androidx.Core.Splashscreen.SplashScreen InstallSplashScreen (global::Android.App.Activity _this_installSplashScreen)
			{
				const string __id = "installSplashScreen.(Landroid/app/Activity;)Landroidx/core/splashscreen/SplashScreen;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((_this_installSplashScreen == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this_installSplashScreen).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Androidx.Core.Splashscreen.SplashScreen> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (_this_installSplashScreen);
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='androidx.core.splashscreen']/interface[@name='SplashScreen.KeepOnScreenCondition']"
		[Register ("androidx/core/splashscreen/SplashScreen$KeepOnScreenCondition", "", "Androidx.Core.Splashscreen.SplashScreen/IKeepOnScreenConditionInvoker")]
		public partial interface IKeepOnScreenCondition : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='androidx.core.splashscreen']/interface[@name='SplashScreen.KeepOnScreenCondition']/method[@name='shouldKeepOnScreen' and count(parameter)=0]"
			[Register ("shouldKeepOnScreen", "()Z", "GetShouldKeepOnScreenHandler:Androidx.Core.Splashscreen.SplashScreen/IKeepOnScreenConditionInvoker, ScreenBinding")]
			bool ShouldKeepOnScreen ();

		}

		[global::Android.Runtime.Register ("androidx/core/splashscreen/SplashScreen$KeepOnScreenCondition", DoNotGenerateAcw=true)]
		internal partial class IKeepOnScreenConditionInvoker : global::Java.Lang.Object, IKeepOnScreenCondition {
			static readonly JniPeerMembers _members = new XAPeerMembers ("androidx/core/splashscreen/SplashScreen$KeepOnScreenCondition", typeof (IKeepOnScreenConditionInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IKeepOnScreenCondition GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IKeepOnScreenCondition> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'androidx.core.splashscreen.SplashScreen.KeepOnScreenCondition'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IKeepOnScreenConditionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_shouldKeepOnScreen;
#pragma warning disable 0169
			static Delegate GetShouldKeepOnScreenHandler ()
			{
				if (cb_shouldKeepOnScreen == null)
					cb_shouldKeepOnScreen = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_ShouldKeepOnScreen);
				return cb_shouldKeepOnScreen;
			}

			static bool n_ShouldKeepOnScreen (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Androidx.Core.Splashscreen.SplashScreen.IKeepOnScreenCondition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ShouldKeepOnScreen ();
			}
#pragma warning restore 0169

			IntPtr id_shouldKeepOnScreen;
			public unsafe bool ShouldKeepOnScreen ()
			{
				if (id_shouldKeepOnScreen == IntPtr.Zero)
					id_shouldKeepOnScreen = JNIEnv.GetMethodID (class_ref, "shouldKeepOnScreen", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_shouldKeepOnScreen);
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='androidx.core.splashscreen']/interface[@name='SplashScreen.OnExitAnimationListener']"
		[Register ("androidx/core/splashscreen/SplashScreen$OnExitAnimationListener", "", "Androidx.Core.Splashscreen.SplashScreen/IOnExitAnimationListenerInvoker")]
		public partial interface IOnExitAnimationListener : IJavaObject, IJavaPeerable {
			// Metadata.xml XPath method reference: path="/api/package[@name='androidx.core.splashscreen']/interface[@name='SplashScreen.OnExitAnimationListener']/method[@name='onSplashScreenExit' and count(parameter)=1 and parameter[1][@type='androidx.core.splashscreen.SplashScreenViewProvider']]"
			[Register ("onSplashScreenExit", "(Landroidx/core/splashscreen/SplashScreenViewProvider;)V", "GetOnSplashScreenExit_Landroidx_core_splashscreen_SplashScreenViewProvider_Handler:Androidx.Core.Splashscreen.SplashScreen/IOnExitAnimationListenerInvoker, ScreenBinding")]
			void OnSplashScreenExit (global::Androidx.Core.Splashscreen.SplashScreenViewProvider splashScreenViewProvider);

		}

		[global::Android.Runtime.Register ("androidx/core/splashscreen/SplashScreen$OnExitAnimationListener", DoNotGenerateAcw=true)]
		internal partial class IOnExitAnimationListenerInvoker : global::Java.Lang.Object, IOnExitAnimationListener {
			static readonly JniPeerMembers _members = new XAPeerMembers ("androidx/core/splashscreen/SplashScreen$OnExitAnimationListener", typeof (IOnExitAnimationListenerInvoker));

			static IntPtr java_class_ref {
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
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnExitAnimationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnExitAnimationListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'androidx.core.splashscreen.SplashScreen.OnExitAnimationListener'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnExitAnimationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onSplashScreenExit_Landroidx_core_splashscreen_SplashScreenViewProvider_;
#pragma warning disable 0169
			static Delegate GetOnSplashScreenExit_Landroidx_core_splashscreen_SplashScreenViewProvider_Handler ()
			{
				if (cb_onSplashScreenExit_Landroidx_core_splashscreen_SplashScreenViewProvider_ == null)
					cb_onSplashScreenExit_Landroidx_core_splashscreen_SplashScreenViewProvider_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSplashScreenExit_Landroidx_core_splashscreen_SplashScreenViewProvider_);
				return cb_onSplashScreenExit_Landroidx_core_splashscreen_SplashScreenViewProvider_;
			}

			static void n_OnSplashScreenExit_Landroidx_core_splashscreen_SplashScreenViewProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_splashScreenViewProvider)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Androidx.Core.Splashscreen.SplashScreen.IOnExitAnimationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var splashScreenViewProvider = global::Java.Lang.Object.GetObject<global::Androidx.Core.Splashscreen.SplashScreenViewProvider> (native_splashScreenViewProvider, JniHandleOwnership.DoNotTransfer);
				__this.OnSplashScreenExit (splashScreenViewProvider);
			}
#pragma warning restore 0169

			IntPtr id_onSplashScreenExit_Landroidx_core_splashscreen_SplashScreenViewProvider_;
			public unsafe void OnSplashScreenExit (global::Androidx.Core.Splashscreen.SplashScreenViewProvider splashScreenViewProvider)
			{
				if (id_onSplashScreenExit_Landroidx_core_splashscreen_SplashScreenViewProvider_ == IntPtr.Zero)
					id_onSplashScreenExit_Landroidx_core_splashscreen_SplashScreenViewProvider_ = JNIEnv.GetMethodID (class_ref, "onSplashScreenExit", "(Landroidx/core/splashscreen/SplashScreenViewProvider;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((splashScreenViewProvider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) splashScreenViewProvider).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSplashScreenExit_Landroidx_core_splashscreen_SplashScreenViewProvider_, __args);
			}

		}

		// event args for androidx.core.splashscreen.SplashScreen.OnExitAnimationListener.onSplashScreenExit
		public partial class ExitAnimationEventArgs : global::System.EventArgs {
			public ExitAnimationEventArgs (global::Androidx.Core.Splashscreen.SplashScreenViewProvider splashScreenViewProvider)
			{
				this.splashScreenViewProvider = splashScreenViewProvider;
			}

			global::Androidx.Core.Splashscreen.SplashScreenViewProvider splashScreenViewProvider;

			public global::Androidx.Core.Splashscreen.SplashScreenViewProvider SplashScreenViewProvider {
				get { return splashScreenViewProvider; }
			}

		}

		[global::Android.Runtime.Register ("mono/androidx/core/splashscreen/SplashScreen_OnExitAnimationListenerImplementor")]
		internal sealed partial class IOnExitAnimationListenerImplementor : global::Java.Lang.Object, IOnExitAnimationListener {

			object sender;

			public IOnExitAnimationListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/androidx/core/splashscreen/SplashScreen_OnExitAnimationListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

			#pragma warning disable 0649
			public EventHandler<ExitAnimationEventArgs> Handler;
			#pragma warning restore 0649

			public void OnSplashScreenExit (global::Androidx.Core.Splashscreen.SplashScreenViewProvider splashScreenViewProvider)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ExitAnimationEventArgs (splashScreenViewProvider));
			}

			internal static bool __IsEmpty (IOnExitAnimationListenerImplementor value)
			{
				return value.Handler == null;
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("androidx/core/splashscreen/SplashScreen", typeof (SplashScreen));

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

		internal SplashScreen (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='androidx.core.splashscreen']/class[@name='SplashScreen']/method[@name='installSplashScreen' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("installSplashScreen", "(Landroid/app/Activity;)Landroidx/core/splashscreen/SplashScreen;", "")]
		public static unsafe global::Androidx.Core.Splashscreen.SplashScreen InstallSplashScreen (global::Android.App.Activity obj)
		{
			const string __id = "installSplashScreen.(Landroid/app/Activity;)Landroidx/core/splashscreen/SplashScreen;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Androidx.Core.Splashscreen.SplashScreen> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='androidx.core.splashscreen']/class[@name='SplashScreen']/method[@name='setKeepVisibleCondition' and count(parameter)=1 and parameter[1][@type='androidx.core.splashscreen.SplashScreen.KeepOnScreenCondition']]"
		[Register ("setKeepVisibleCondition", "(Landroidx/core/splashscreen/SplashScreen$KeepOnScreenCondition;)V", "")]
		public unsafe void SetKeepVisibleCondition (global::Androidx.Core.Splashscreen.SplashScreen.IKeepOnScreenCondition condition)
		{
			const string __id = "setKeepVisibleCondition.(Landroidx/core/splashscreen/SplashScreen$KeepOnScreenCondition;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((condition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) condition).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (condition);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='androidx.core.splashscreen']/class[@name='SplashScreen']/method[@name='setOnExitAnimationListener' and count(parameter)=1 and parameter[1][@type='androidx.core.splashscreen.SplashScreen.OnExitAnimationListener']]"
		[Register ("setOnExitAnimationListener", "(Landroidx/core/splashscreen/SplashScreen$OnExitAnimationListener;)V", "")]
		public unsafe void SetOnExitAnimationListener (global::Androidx.Core.Splashscreen.SplashScreen.IOnExitAnimationListener listener)
		{
			const string __id = "setOnExitAnimationListener.(Landroidx/core/splashscreen/SplashScreen$OnExitAnimationListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		#region "Event implementation for Androidx.Core.Splashscreen.SplashScreen.IOnExitAnimationListener"

		public event EventHandler<global::Androidx.Core.Splashscreen.SplashScreen.ExitAnimationEventArgs> ExitAnimation {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Androidx.Core.Splashscreen.SplashScreen.IOnExitAnimationListener, global::Androidx.Core.Splashscreen.SplashScreen.IOnExitAnimationListenerImplementor>(
				ref weak_implementor_SetOnExitAnimationListener,
				__CreateIOnExitAnimationListenerImplementor,
				SetOnExitAnimationListener,
				__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Androidx.Core.Splashscreen.SplashScreen.IOnExitAnimationListener, global::Androidx.Core.Splashscreen.SplashScreen.IOnExitAnimationListenerImplementor>(
				ref weak_implementor_SetOnExitAnimationListener,
				global::Androidx.Core.Splashscreen.SplashScreen.IOnExitAnimationListenerImplementor.__IsEmpty,
				__v => SetOnExitAnimationListener (null),
				__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnExitAnimationListener;

		global::Androidx.Core.Splashscreen.SplashScreen.IOnExitAnimationListenerImplementor __CreateIOnExitAnimationListenerImplementor ()
		{
			return new global::Androidx.Core.Splashscreen.SplashScreen.IOnExitAnimationListenerImplementor (this);
		}

		#endregion

	}
}
