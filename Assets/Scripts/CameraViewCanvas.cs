using UnityEngine;
using UnityEngine.UI;

public class CameraViewCanvas : AbstractCameraView {

    public RawImage cameraView;
    public AspectRatioFitter aspectRatioFitter;


//TODO: see what can be removed to an "Init" method (& use a delegate)
    void Update() {
        if (!isCameraAvailable) {
            return;
        }

        aspectRatioFitter.aspectRatio = (float)cameraTexture.width / (float)cameraTexture.height;

        float scaleY = cameraTexture.videoVerticallyMirrored ? -1.0f : 1.0f;
        cameraView.rectTransform.localScale = new Vector3(1.0f, scaleY, 1.0f);

        int orientation = cameraTexture.videoRotationAngle;
        cameraView.rectTransform.localEulerAngles = new Vector3(.0f, .0f, -orientation);
    }

    protected override Texture GetTexture() {
        return cameraView.texture;
    }

    protected override void SetTexture(Texture texture) {
        cameraView.texture = texture;
    }


}
