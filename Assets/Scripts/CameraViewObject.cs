using UnityEngine;

public class CameraViewObject : AbstractCameraView {

    protected override Texture GetTexture() {
        return this.GetComponent<Renderer>().material.mainTexture;
    }

    protected override void SetTexture(Texture texture) {
        this.GetComponent<Renderer>().material.mainTexture = texture;
    }

}
