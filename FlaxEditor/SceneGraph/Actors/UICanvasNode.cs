// Copyright (c) 2012-2018 Wojciech Figat. All rights reserved.

using FlaxEngine;

namespace FlaxEditor.SceneGraph.Actors
{
    /// <summary>
    /// Scene tree node for <see cref="UICanvas"/> actor type.
    /// </summary>
    /// <seealso cref="ActorNode" />
    public sealed class UICanvasNode : ActorNode
    {
        /// <inheritdoc />
        public UICanvasNode(Actor actor)
        : base(actor)
        {
        }

        /// <inheritdoc />
        public override void PostSpawn()
        {
            base.PostSpawn();

            // Rotate to match the space (GUI uses upper left corner as a root)
            Actor.LocalOrientation = Quaternion.Euler(0, -180, -180);
        }

        /// <inheritdoc />
        public override bool RayCastSelf(ref RayCastData ray, out float distance)
        {
            if (Actor is UICanvas uiCanvas && uiCanvas.Is3D)
                return uiCanvas.Bounds.Intersects(ref ray.Ray, out distance);

            distance = 0;
            return false;
        }

        /// <inheritdoc />
        public override void OnDebugDraw(ViewportDebugDrawData data)
        {
            base.OnDebugDraw(data);

            if (Actor is UICanvas uiCanvas && uiCanvas.Is3D)
                DebugDraw.DrawBox(uiCanvas.Bounds, Color.BlueViolet);
        }
    }
}