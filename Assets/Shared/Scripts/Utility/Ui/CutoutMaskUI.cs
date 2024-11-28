using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace Utility.Ui
{
    public class CutoutMaskUI : Image
    {
        private static readonly int Comp = Shader.PropertyToID("_StencilComp");

        public override Material materialForRendering
        {
            get
            {
                var mat = new Material(base.materialForRendering);
                mat.SetInt(Comp, (int)CompareFunction.NotEqual);
                return mat;
            }
        }
    }
}