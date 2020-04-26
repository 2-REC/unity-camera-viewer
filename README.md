# CAMERA VIEWER

Allows to visualise a device camera feed (front or rear) as background of a Unity camera or GameObject, useful for AR like camera view.<br>
...<br>


Remarks:<br>
- Cannot have 2 camera feeds at the same time, only the last to be instantiated is working.<br>
    => It seems to be a bug in Unity (?)<br>

(TODO: check...)<br>
- For the "Camera Canvas Viewer", when changing the resolution of the game:<br>
    - Player<br>
        => Choose the desired resolution:<br>
            "Edit" -> "Project settings" -> "Player"<br>
                (or choose from the drop down list in the "Game" window)<br>
    - Canvas object<br>
        => Set the same resolution as for the Player:<br>
            "Canvas Scaler": Set the "X" and "Y" values in "Reference Resolution"<br>
    - "Camera View" (RawImage object)<br>
        => Follow these steps in this order:<br>
            1. "AspectRatioFitter": Set "Aspect Ratio" to "None"<br>
            2. "Rect Transform": Set all the size values back to 0 ("Left", "Top", "Pos Z", "Right", "Bottom")<br>
            3. "AspectRatioFitter": Set "Aspect Ratio" back to "Envelope Parent"<br>

