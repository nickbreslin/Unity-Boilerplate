using UnityEditor;
using UnityEngine;

class MoveToOrigin
{
	/// <summary>
	/// Moves selected game object(s) to (0, 0, 0).
	/// <summary>
	/// <remarks>Keyboard shortcut: shift-cmd-0 (Mac), shift-ctrl-0 (Windows).</remarks>
	[MenuItem ("GameObject/Move To Origin #%0")]
	static void MenuMoveToOrigin ()
	{
		foreach (var t in Selection.transforms) {
			Undo.RegisterUndo(t, "Move " + t.name);
			t.position = Vector3.zero;
			Debug.Log("Moving " + t.name + " to origin.");
		}
	}

	/// <summary>
	/// Validates "Move To Origin" menu item.
	/// </summary>
	/// <remarks>The menu item will be disabled if no transform is selected.</remarks>
	[MenuItem ("GameObject/Move To Origin #%0", true)]
	static bool ValidateMoveToOrigin ()
	{
		return Selection.activeTransform != null;
	}
}

