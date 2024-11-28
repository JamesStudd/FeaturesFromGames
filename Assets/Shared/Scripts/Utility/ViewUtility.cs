using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Utility
{
    public static class ViewUtility
    {
        //Returns 'true' if we touched or hovering on Unity UI element.
        public static bool IsPointerOverUIElement()
        {
            return IsPointerOverUIElement(GetEventSystemRaycastResults());
        }

        //Returns 'true' if we touched or hovering on Unity UI element.
        private static bool IsPointerOverUIElement(IEnumerable<RaycastResult> eventSystemRaycastResults)
        {
            foreach (var raycastResult in eventSystemRaycastResults)
            {
                if (raycastResult.gameObject.layer == Constants.UILayer)
                {
                    return true;
                }
            }

            return false;
        }

        //Gets all event system raycast results of current mouse or touch position.
        private static List<RaycastResult> GetEventSystemRaycastResults()
        {
            var eventData = new PointerEventData(EventSystem.current) {position = Input.mousePosition};
            var raysastResults = new List<RaycastResult>();
            EventSystem.current.RaycastAll(eventData, raysastResults);
            return raysastResults;
        }
    }
}