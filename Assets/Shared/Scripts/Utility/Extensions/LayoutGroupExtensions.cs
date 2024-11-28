using UnityEngine.UI;

namespace Utility.Extensions
{
    public static class LayoutGroupExtensions
    {
        public static void UpdateLayout(this LayoutGroup layoutGroup)
        {
            layoutGroup.CalculateLayoutInputVertical();
            layoutGroup.CalculateLayoutInputHorizontal();
            
            layoutGroup.SetLayoutVertical();
            layoutGroup.SetLayoutHorizontal();
        }
    }
}