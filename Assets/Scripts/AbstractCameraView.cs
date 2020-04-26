using UnityEngine;

public abstract class AbstractCameraView : MonoBehaviour {

    public bool frontCamera = false;

    protected bool isCameraAvailable;
    protected WebCamTexture cameraTexture;
    private Texture defaultBackground;


    void Start() {
        isCameraAvailable = false;
        defaultBackground = GetTexture();

        WebCamDevice[] devices = WebCamTexture.devices;
        if (devices.Length == 0) {
            Debug.Log("No camera detected!");
            return;
        }

        for (int i=0; i<devices.Length; ++i) {
            if (devices[i].isFrontFacing == frontCamera) {
                cameraTexture = new WebCamTexture(devices[i].name, Screen.width, Screen.height);
            }
        }

        if (cameraTexture == null) {
            Debug.Log("Couldn't find asked camera!");
            return;
        }

        if (!cameraTexture.isPlaying) {
            cameraTexture.Play();
        }

        SetTexture(cameraTexture);

        isCameraAvailable = true;
    }


    protected abstract Texture GetTexture();
    protected abstract void SetTexture(Texture texture);

}
