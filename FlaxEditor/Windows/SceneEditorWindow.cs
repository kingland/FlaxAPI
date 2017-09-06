////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2012-2017 Flax Engine. All rights reserved.
////////////////////////////////////////////////////////////////////////////////////

using FlaxEngine;
using FlaxEngine.GUI;

namespace FlaxEditor.Windows
{
    /// <summary>
    /// Base class for editor windows dedicated to scene editing.
    /// </summary>
    /// <seealso cref="FlaxEditor.Windows.EditorWindow" />
    public abstract class SceneEditorWindow : EditorWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SceneEditorWindow"/> class.
        /// </summary>
        /// <param name="editor">The editor.</param>
        /// <param name="hideOnClose">True if hide window on closing, otherwise it will be destroyed.</param>
        /// <param name="scrollBars">The scroll bars.</param>
        protected SceneEditorWindow(Editor editor, bool hideOnClose, ScrollBars scrollBars)
            : base(editor, hideOnClose, scrollBars)
        {
        }

        /// <summary>
        /// Saves all changes.
        /// </summary>
        public void SaveAll()
        {
            Editor.SaveAll();
        }

        /// <inheritdoc />
        public override bool OnKeyPressed(KeyCodeMap key)
        {
            // Base
            if (base.OnKeyPressed(key)) return true;

            if(key.InvokeFirstCommand(KeyCode.Control,
                (KeyCode.S, Editor.SaveAll),
                (KeyCode.Z, Editor.PerformUndo),
                (KeyCode.Y, () => { Editor.PerformRedo(); Focus(); }),
                (KeyCode.X, Editor.SceneEditing.Cut),
                (KeyCode.C, Editor.SceneEditing.Copy),
                (KeyCode.V, () => { Editor.SceneEditing.Paste(); }),
                (KeyCode.D, Editor.SceneEditing.Duplicate),
                (KeyCode.A, Editor.SceneEditing.SelectAllScenes),
                (KeyCode.F, Editor.Windows.SceneWin.Search)
            )){ return true; }
            return key.InvokeFirstCommand((KeyCode.Delete, Editor.SceneEditing.Delete));
        }
    }
}
