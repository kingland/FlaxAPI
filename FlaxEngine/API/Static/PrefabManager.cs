// Copyright (c) 2012-2018 Wojciech Figat. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace FlaxEngine
{
    public static partial class PrefabManager
    {
        /// <summary>
        /// Spawns the instance of the prefab objects. Prefab will be spawned to the first loaded scene.
        /// </summary>
        /// <param name="prefab">The prefab asset.</param>
        /// <returns>The created actor (root) or null if failed</returns>
        public static Actor SpawnPrefab(Prefab prefab)
        {
            var scene = SceneManager.GetScene(0);
            if (scene == null)
                return null;
            return SpawnPrefab(prefab, scene);
        }

        #region Internal Calls

#if !UNIT_TEST_COMPILANT
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool Internal_ApplyAll(IntPtr instance);
#endif

        #endregion
    }
}