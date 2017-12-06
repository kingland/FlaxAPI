// Flax Engine scripting API

using System;

namespace FlaxEngine
{
    /// <summary>
    /// Virtual input action binding. Helps with listening for a selected input event.
    /// </summary>
    public class InputEvent
    {
        /// <summary>
        /// The name of the action to use. See <see cref="Input.ActionMappings"/>.
        /// </summary>
        [Tooltip("The name of the action to use.")]
        public string Name;

        /// <summary>
        /// Returns true if the event has been triggered during the current frame (e.g. user pressed a key). Use <see cref="Triggered"/> to catch events without active waiting.
        /// </summary>
        public bool Active => Input.GetAction(Name);

        /// <summary>
        /// Occurs when event is triggered (e.g. user pressed a key). Called before scripts update.
        /// </summary>
        public event Action Triggered;

        /// <summary>
        /// Initializes a new instance of the <see cref="InputEvent"/> class.
        /// </summary>
        public InputEvent()
        {
            Input.ActionTriggered += Handler;
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="InputEvent"/> class.
        /// </summary>
        ~InputEvent()
        {
            Input.ActionTriggered -= Handler;
        }

        private void Handler(string name)
        {
            if (string.Equals(name, Name, StringComparison.OrdinalIgnoreCase))
                Triggered?.Invoke();
        }
    }
}
