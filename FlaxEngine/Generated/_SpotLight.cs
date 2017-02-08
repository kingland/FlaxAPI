//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{

		/// <summary>
		/// Spot Light can emmit light from point in space in a given direction
		/// </summary>
		public sealed partial class SpotLight : Actor
		{
			/// <summary>
			/// Gets or sets value indicating if visual element affects the world
			/// </summary>
			[UnmanagedCall]
			public bool AffectsWorld
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetAffectsWorld(unmanagedPtr); }
				set { Internal_SetAffectsWorld(unmanagedPtr, value); }
#endif
			}

			/// <summary>
			/// Gets or sets light color
			/// </summary>
			[UnmanagedCall]
			public Color Color
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetColor(unmanagedPtr); }
				set { Internal_SetColor(unmanagedPtr, ref value); }
#endif
			}

			/// <summary>
			/// Gets or sets light brightness parameter
			/// </summary>
			[UnmanagedCall]
			public float Brightness
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetBrightness(unmanagedPtr); }
				set { Internal_SetBrightness(unmanagedPtr, value); }
#endif
			}

			/// <summary>
			/// Gets or sets light radius parameter
			/// </summary>
			[UnmanagedCall]
			public float Radius
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetRadius(unmanagedPtr); }
				set { Internal_SetRadius(unmanagedPtr, value); }
#endif
			}

			/// <summary>
			/// Gets or sets light source bulb radius parameter
			/// </summary>
			[UnmanagedCall]
			public float SourceRadius
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetSourceRadius(unmanagedPtr); }
				set { Internal_SetSourceRadius(unmanagedPtr, value); }
#endif
			}

			/// <summary>
			/// Gets or sets light source minimum roughness parameter
			/// </summary>
			[UnmanagedCall]
			public float MinimumRoughness
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetMinimumRoughness(unmanagedPtr); }
				set { Internal_SetMinimumRoughness(unmanagedPtr, value); }
#endif
			}

			/// <summary>
			/// Gets or sets value indicating if how visual element casts shadows
			/// </summary>
			[UnmanagedCall]
			public ShadowsCastingMode ShadowsMode
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetShadowsMode(unmanagedPtr); }
				set { Internal_SetShadowsMode(unmanagedPtr, value); }
#endif
			}

#region Internal Calls
#if !UNIT_TEST_COMPILANT
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool Internal_GetAffectsWorld(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetAffectsWorld(IntPtr obj, bool val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Color Internal_GetColor(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetColor(IntPtr obj, ref Color val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern float Internal_GetBrightness(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetBrightness(IntPtr obj, float val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern float Internal_GetRadius(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetRadius(IntPtr obj, float val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern float Internal_GetSourceRadius(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetSourceRadius(IntPtr obj, float val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern float Internal_GetMinimumRoughness(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetMinimumRoughness(IntPtr obj, float val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern ShadowsCastingMode Internal_GetShadowsMode(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetShadowsMode(IntPtr obj, ShadowsCastingMode val);
#endif
#endregion
	}
}

