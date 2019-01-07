// Copyright (c) 2012-2019 Wojciech Figat. All rights reserved.
// This code was generated by a tool. Changes to this file may cause
// incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Runtime.CompilerServices;

namespace FlaxEngine.Rendering
{
    /// <summary>
    /// Allows to perform custom rendering to texture.
    /// </summary>
    public sealed partial class RenderTarget : Object
    {
        /// <summary>
        /// Creates new <see cref="RenderTarget"/> object.
        /// </summary>
        private RenderTarget() : base()
        {
        }

        /// <summary>
        /// Creates new instance of <see cref="RenderTarget"/> object.
        /// </summary>
        /// <returns>Created object.</returns>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public static RenderTarget New()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            return Internal_Create(typeof(RenderTarget)) as RenderTarget;
#endif
        }

        /// <summary>
        /// Gets texture dimensions.
        /// </summary>
        [UnmanagedCall]
        public TextureDimensions Dimensions
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetDimensions(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Gets texture surface format.
        /// </summary>
        [UnmanagedCall]
        public PixelFormat Format
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetFormat(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Gets texture surface multisample level.
        /// </summary>
        [UnmanagedCall]
        public MSAALevel MultiSampleLevel
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetMultiSampleLevel(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Gets number of mipmap levels in the texture.
        /// </summary>
        [UnmanagedCall]
        public int MipLevels
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetMipLevels(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Gets the texture surface flags.
        /// </summary>
        [UnmanagedCall]
        public TextureFlags Flags
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetFlags(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Gets a value indicating whether this texture has been allocated.
        /// </summary>
        [UnmanagedCall]
        public bool IsAllocated
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetIsAllocated(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Gets the native pointer to the underlying resource. It's a low-level platform-specific handle.
        /// </summary>
        [UnmanagedCall]
        public IntPtr NativePtr
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetNativePtr(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Gets or sets texture surface width (in pixels).
        /// </summary>
        [UnmanagedCall]
        public int Width
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetWidth(unmanagedPtr); }
            set { Internal_SetWidth(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets texture surface height (in pixels).
        /// </summary>
        [UnmanagedCall]
        public int Height
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetHeight(unmanagedPtr); }
            set { Internal_SetHeight(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets texture surface depth (in pixels). Used only by volume textures. For 1D and 2D textures it defaults to 1.
        /// </summary>
        [UnmanagedCall]
        public int Depth
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetDepth(unmanagedPtr); }
            set { Internal_SetDepth(unmanagedPtr, value); }
#endif
        }

        /// <summary>
        /// Gets or sets texture array size.
        /// </summary>
        [UnmanagedCall]
        public int ArraySize
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { return Internal_GetArraySize(unmanagedPtr); }
#endif
        }

        /// <summary>
        /// Gets or sets texture surface size (in pixels).
        /// </summary>
        [UnmanagedCall]
        public Vector2 Size
        {
#if UNIT_TEST_COMPILANT
            get; set;
#else
            get { Vector2 resultAsRef; Internal_GetSize(unmanagedPtr, out resultAsRef); return resultAsRef; }
            set { Internal_SetSize(unmanagedPtr, ref value); }
#endif
        }

        /// <summary>
        /// Initializes render target texture (2D texture or 2D texture array).
        /// </summary>
        /// <param name="format">The surface pixels format.</param>
        /// <param name="width">The surface width in pixels.</param>
        /// <param name="height">The surface height in pixels.</param>
        /// <param name="flags">The surface usage flags.</param>
        /// <param name="mipMaps">Number of mipmaps for the texture. Default is 1. Use 0 to allocate full mip chain.</param>
        /// <param name="multiSampleLevel">The surface multisampling level.</param>
        /// <param name="arraySize">Size of the texture 2D array. Default is 1.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void Init(PixelFormat format, int width, int height, TextureFlags flags = TextureFlags.ShaderResource | TextureFlags.RenderTarget, int mipMaps = 1, MSAALevel multiSampleLevel = MSAALevel.None, int arraySize = 1)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_Init(unmanagedPtr, format, width, height, flags, mipMaps, multiSampleLevel, arraySize);
#endif
        }

        /// <summary>
        /// Initializes render target texture (cube map).
        /// </summary>
        /// <param name="format">The surface pixels format.</param>
        /// <param name="size">The surface size in pixels (width and height).</param>
        /// <param name="flags">The surface usage flags.</param>
        /// <param name="mipMaps">Number of mipmaps for the texture. Default is 1. Use 0 to allocate full mip chain.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void InitCube(PixelFormat format, int size, TextureFlags flags = TextureFlags.ShaderResource | TextureFlags.RenderTarget, int mipMaps = 1)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_InitCube(unmanagedPtr, format, size, flags, mipMaps);
#endif
        }

        /// <summary>
        /// Initializes render target texture (3D volume texture).
        /// </summary>
        /// <param name="format">The surface pixels format.</param>
        /// <param name="width">The surface width in pixels.</param>
        /// <param name="height">The surface height in pixels.</param>
        /// <param name="depth">The surface depth in pixels.</param>
        /// <param name="flags">The surface usage flags.</param>
        /// <param name="mipMaps">Number of mipmaps for the texture. Default is 1. Use 0 to allocate full mip chain.</param>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void Init3D(PixelFormat format, int width, int height, int depth, TextureFlags flags = TextureFlags.ShaderResource | TextureFlags.RenderTarget, int mipMaps = 1)
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_Init3D(unmanagedPtr, format, width, height, depth, flags, mipMaps);
#endif
        }

        /// <summary>
        /// Disposes render target surface data.
        /// </summary>
#if UNIT_TEST_COMPILANT
        [Obsolete("Unit tests, don't support methods calls.")]
#endif
        [UnmanagedCall]
        public void Dispose()
        {
#if UNIT_TEST_COMPILANT
            throw new NotImplementedException("Unit tests, don't support methods calls. Only properties can be get or set.");
#else
            Internal_Dispose(unmanagedPtr);
#endif
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern TextureDimensions Internal_GetDimensions(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern PixelFormat Internal_GetFormat(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern MSAALevel Internal_GetMultiSampleLevel(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int Internal_GetMipLevels(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern TextureFlags Internal_GetFlags(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_GetIsAllocated(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr Internal_GetNativePtr(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int Internal_GetWidth(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetWidth(IntPtr obj, int val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int Internal_GetHeight(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetHeight(IntPtr obj, int val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int Internal_GetDepth(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetDepth(IntPtr obj, int val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern int Internal_GetArraySize(IntPtr obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_GetSize(IntPtr obj, out Vector2 resultAsRef);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_SetSize(IntPtr obj, ref Vector2 val);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_Init(IntPtr obj, PixelFormat format, int width, int height, TextureFlags flags, int mipMaps, MSAALevel multiSampleLevel, int arraySize);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_InitCube(IntPtr obj, PixelFormat format, int size, TextureFlags flags, int mipMaps);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_Init3D(IntPtr obj, PixelFormat format, int width, int height, int depth, TextureFlags flags, int mipMaps);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_Dispose(IntPtr obj);
#endif

        #endregion
    }
}
