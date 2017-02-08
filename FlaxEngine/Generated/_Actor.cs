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
		/// Base class for all actor types on the scene
		/// </summary>
		public abstract partial class Actor : Object
		{
			/// <summary>
			/// Gets Actor ID
			/// </summary>
			[UnmanagedCall]
			public Guid GetName
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetID(unmanagedPtr); }
#endif
			}

			/// <summary>
			/// Gets or sets parent actor (or null if actor has no parent)
			/// </summary>
			[UnmanagedCall]
			public Actor Parent
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetParent(unmanagedPtr); }
				set { Internal_SetParent(unmanagedPtr, GetUnmanagedPtr(value), false); }
#endif
			}

			/// <summary>
			/// Sets parent actor with parameters
			/// </summary>
			/// <param name="newParent">New parent to assign</param>
			/// <param name="worldPositionLock">Should actor world positions remain the same after parent change</param>
#if UNIT_TEST_COMPILANT
			[Obsolete("Unit tests, don't support methods calls.")]
#endif
			[UnmanagedCall]
			public void SetParent(Actor newParent, bool worldPositionLock = false) 
			{
#if UNIT_TEST_COMPILANT
				throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
				Internal_SetParent(unmanagedPtr, GetUnmanagedPtr(newParent), worldPositionLock);
#endif
			}

			/// <summary>
			/// Gets or sets actor name
			/// </summary>
			[UnmanagedCall]
			public String Name
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetName(unmanagedPtr); }
				set { Internal_SetName(unmanagedPtr, value); }
#endif
			}

			/// <summary>
			/// Gets or sets actor static fags
			/// </summary>
			[UnmanagedCall]
			public StaticFlags StaticFlags
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetStaticFlags(unmanagedPtr); }
				set { Internal_SetStaticFlags(unmanagedPtr, value); }
#endif
			}

			/// <summary>
			/// Gets or sets active state of actor
			/// </summary>
			[UnmanagedCall]
			public bool IsActive
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetIsActive(unmanagedPtr); }
				set { Internal_SetIsActive(unmanagedPtr, value); }
#endif
			}

			/// <summary>
			/// Gets actor activation state in hierarchy
			/// </summary>
			[UnmanagedCall]
			public bool IsActiveInHierarchy
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetIsActiveInHierarchy(unmanagedPtr); }
#endif
			}

			/// <summary>
			/// Gets or sets actor's world transform position
			/// </summary>
			[UnmanagedCall]
			public Vector3 Position
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetPosition(unmanagedPtr); }
				set { Internal_SetPosition(unmanagedPtr, ref value); }
#endif
			}

			/// <summary>
			/// Gets or sets actor's world transform orientation
			/// </summary>
			[UnmanagedCall]
			public Quaternion Orientation
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetOrientation(unmanagedPtr); }
				set { Internal_SetOrientation(unmanagedPtr, ref value); }
#endif
			}

			/// <summary>
			/// Gets or sets actor's world transform scale
			/// </summary>
			[UnmanagedCall]
			public Vector3 Scale
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetScale(unmanagedPtr); }
				set { Internal_SetScale(unmanagedPtr, ref value); }
#endif
			}

			/// <summary>
			/// Gets or sets actor's world a three dimensional mathematical transformation
			/// </summary>
			[UnmanagedCall]
			public Transform Transform
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetTransform(unmanagedPtr); }
				set { Internal_SetTransform(unmanagedPtr, ref value); }
#endif
			}

			/// <summary>
			/// Gets or sets actor's local transform position
			/// </summary>
			[UnmanagedCall]
			public Vector3 LocalPosition
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetLocalPosition(unmanagedPtr); }
				set { Internal_SetLocalPosition(unmanagedPtr, ref value); }
#endif
			}

			/// <summary>
			/// Gets or sets actor's local transform orientation
			/// </summary>
			[UnmanagedCall]
			public Quaternion LocalOrientation
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetLocalOrientation(unmanagedPtr); }
				set { Internal_SetLocalOrientation(unmanagedPtr, ref value); }
#endif
			}

			/// <summary>
			/// Gets or sets actor's local transform scale
			/// </summary>
			[UnmanagedCall]
			public Vector3 LocalScale
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetLocalScale(unmanagedPtr); }
				set { Internal_SetLocalScale(unmanagedPtr, ref value); }
#endif
			}

			/// <summary>
			/// Gets or sets actor's world a three dimensional mathematical transformation
			/// </summary>
			[UnmanagedCall]
			public Transform LocalTransform
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetLocalTransform(unmanagedPtr); }
				set { Internal_SetLocalTransform(unmanagedPtr, ref value); }
#endif
			}

			/// <summary>
			/// Gets amount of children
			/// </summary>
			[UnmanagedCall]
			public int ChildCount
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetChildCount(unmanagedPtr); }
#endif
			}

			/// <summary>
			/// Gets child actor at given index
			/// </summary>
			/// <param name="index">Child's actor index</param>
			/// <returns>Child actor</returns>
#if UNIT_TEST_COMPILANT
			[Obsolete("Unit tests, don't support methods calls.")]
#endif
			[UnmanagedCall]
			public Actor GetChild(int index) 
			{
#if UNIT_TEST_COMPILANT
				throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
				return Internal_GetChildAtIndex(unmanagedPtr, index);
#endif
			}

			/// <summary>
			/// Gets child actor with given name
			/// </summary>
			/// <param name="name">Child's actor name</param>
			/// <returns>Child actor</returns>
#if UNIT_TEST_COMPILANT
			[Obsolete("Unit tests, don't support methods calls.")]
#endif
			[UnmanagedCall]
			public Actor GetChild(string name) 
			{
#if UNIT_TEST_COMPILANT
				throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
				return Internal_GetChildWithName(unmanagedPtr, name);
#endif
			}

			/// <summary>
			/// Tries to find actor with given name in this actor tree
			/// </summary>
			/// <param name="name">Actor's name to find</param>
			/// <returns>Actor instance if found, null otherwise</returns>
#if UNIT_TEST_COMPILANT
			[Obsolete("Unit tests, don't support methods calls.")]
#endif
			[UnmanagedCall]
			public Actor FindActor(string name) 
			{
#if UNIT_TEST_COMPILANT
				throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
				return Internal_FindActorWithName(unmanagedPtr, name);
#endif
			}

			/// <summary>
			/// Tries to find actor with given name on the scene
			/// </summary>
			/// <param name="name">Actor's name to find</param>
			/// <returns>Actor instance if found, null otherwise</returns>
#if UNIT_TEST_COMPILANT
			[Obsolete("Unit tests, don't support methods calls.")]
#endif
			[UnmanagedCall]
			public static Actor Find(string name) 
			{
#if UNIT_TEST_COMPILANT
				throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
				return Internal_FindActor(name);
#endif
			}

			/// <summary>
			/// Searches for a child actor of a specific type. If there are multiple actors matching the type, only the first one found is returned.
			/// </summary>
			/// <typeparam name="T">Type of the actor to search for. Includes any actors derived from the type.</typeparam>
			/// <returns>Actor instance if found, null otherwise</returns>
#if UNIT_TEST_COMPILANT
			[Obsolete("Unit tests, don't support methods calls.")]
#endif
			[UnmanagedCall]
			public T GetChild<T>() where T : Actor
			{
#if UNIT_TEST_COMPILANT
				throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
				return (T)Internal_GetChild(unmanagedPtr, typeof(T));
#endif
			}

			/// <summary>
			/// Searches for all actors of a specific type.
			/// </summary>
			/// <typeparam name="T">Type of the actor to search for. Includes any actors derived from the type.</typeparam>
			/// <returns>All actors matching the specified type</returns>
#if UNIT_TEST_COMPILANT
			[Obsolete("Unit tests, don't support methods calls.")]
#endif
			[UnmanagedCall]
			public T[] GetChildren<T>() where T : Actor
			{
#if UNIT_TEST_COMPILANT
				throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
				return Array.ConvertAll(Internal_GetChildrenPerType(unmanagedPtr, typeof(T)), x => (T)x);
#endif
			}

			/// <summary>
			/// Returns a list of all actors attached to this object.
			/// </summary>
			/// <returns>All actors attached to this object.</returns>
#if UNIT_TEST_COMPILANT
			[Obsolete("Unit tests, don't support methods calls.")]
#endif
			[UnmanagedCall]
			public Actor[] GetChildren() 
			{
#if UNIT_TEST_COMPILANT
				throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
				return Internal_GetChildren(unmanagedPtr);
#endif
			}

			/// <summary>
			/// Searches for a child script of a specific type. If there are multiple scripts matching the type, only the first one found is returned.
			/// </summary>
			/// <typeparam name="T">Type of the actor to search for. Includes any scripts derived from the type.</typeparam>
			/// <returns>Script instance if found, null otherwise.</returns>
#if UNIT_TEST_COMPILANT
			[Obsolete("Unit tests, don't support methods calls.")]
#endif
			[UnmanagedCall]
			public T GetScript<T>() where T : Script
			{
#if UNIT_TEST_COMPILANT
				throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
				return (T)Internal_GetScript(unmanagedPtr, typeof(T));
#endif
			}

			/// <summary>
			/// Searches for all scripts of a specific type.
			/// </summary>
			/// <typeparam name="T">Type of the script to search for. Includes any scripts derived from the type.</typeparam>
			/// <returns>All scripts matching the specified type.</returns>
#if UNIT_TEST_COMPILANT
			[Obsolete("Unit tests, don't support methods calls.")]
#endif
			[UnmanagedCall]
			public T[] GetScripts<T>() where T : Script
			{
#if UNIT_TEST_COMPILANT
				throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
				return Array.ConvertAll(Internal_GetScriptsPerType(unmanagedPtr, typeof(T)), x => (T)x);
#endif
			}

			/// <summary>
			/// Returns a list of all scripts attached to this object.
			/// </summary>
			/// <returns>All scripts attached to this object.</returns>
#if UNIT_TEST_COMPILANT
			[Obsolete("Unit tests, don't support methods calls.")]
#endif
			[UnmanagedCall]
			public Script[] GetScripts() 
			{
#if UNIT_TEST_COMPILANT
				throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
				return Internal_GetScripts(unmanagedPtr);
#endif
			}

			/// <summary>
			/// Gets bounding box that contains actor object (single actor, no children included)
			/// </summary>
			[UnmanagedCall]
			public BoundingBox Box
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetBox(unmanagedPtr); }
#endif
			}

			/// <summary>
			/// Gets bounding box that contains actor object and all it's children (children included in recursive way)
			/// </summary>
			[UnmanagedCall]
			public BoundingBox BoxWithChildren
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_GetBoxWithChildren(unmanagedPtr); }
#endif
			}

			/// <summary>
			/// Returns true if actor has loaded content
			/// </summary>
			[UnmanagedCall]
			public bool HasContentLoaded
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_HasContentLoaded(unmanagedPtr); }
#endif
			}

			/// <summary>
			/// Returns true if actor has fully loaded content
			/// </summary>
			[UnmanagedCall]
			public bool HasContentFullyLoaded
			{
#if UNIT_TEST_COMPILANT
				get; set;
#else
				get { return Internal_HasContentFullyLoaded(unmanagedPtr); }
#endif
			}

#region Internal Calls
#if !UNIT_TEST_COMPILANT
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Guid Internal_GetID(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Actor Internal_GetParent(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetParent(IntPtr obj, IntPtr val, bool worldPositionLock);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern String Internal_GetName(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetName(IntPtr obj, String val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern StaticFlags Internal_GetStaticFlags(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetStaticFlags(IntPtr obj, StaticFlags val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool Internal_GetIsActive(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetIsActive(IntPtr obj, bool val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool Internal_GetIsActiveInHierarchy(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Vector3 Internal_GetPosition(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetPosition(IntPtr obj, ref Vector3 val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Quaternion Internal_GetOrientation(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetOrientation(IntPtr obj, ref Quaternion val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Vector3 Internal_GetScale(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetScale(IntPtr obj, ref Vector3 val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Transform Internal_GetTransform(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetTransform(IntPtr obj, ref Transform val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Vector3 Internal_GetLocalPosition(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetLocalPosition(IntPtr obj, ref Vector3 val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Quaternion Internal_GetLocalOrientation(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetLocalOrientation(IntPtr obj, ref Quaternion val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Vector3 Internal_GetLocalScale(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetLocalScale(IntPtr obj, ref Vector3 val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Transform Internal_GetLocalTransform(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Internal_SetLocalTransform(IntPtr obj, ref Transform val);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int Internal_GetChildCount(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Actor Internal_GetChildAtIndex(IntPtr obj, int index);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Actor Internal_GetChildWithName(IntPtr obj, string name);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Actor Internal_FindActorWithName(IntPtr obj, string name);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Actor Internal_FindActor(string name);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Actor Internal_GetChild(IntPtr obj, Type type);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Actor[] Internal_GetChildrenPerType(IntPtr obj, Type type);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Actor[] Internal_GetChildren(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Script Internal_GetScript(IntPtr obj, Type type);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Script[] Internal_GetScriptsPerType(IntPtr obj, Type type);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Script[] Internal_GetScripts(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern BoundingBox Internal_GetBox(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern BoundingBox Internal_GetBoxWithChildren(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool Internal_HasContentLoaded(IntPtr obj);
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool Internal_HasContentFullyLoaded(IntPtr obj);
#endif
#endregion
	}
}

