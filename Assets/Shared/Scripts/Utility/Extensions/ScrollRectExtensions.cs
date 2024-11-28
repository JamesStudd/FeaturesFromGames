using UnityEngine;
using UnityEngine.UI;

namespace Utility.Extensions
{
    public static class ScrollRectExtensions
    {
        public static void MoveToCampaignRound(this ScrollRect scrollRect, RectTransform contentPanel, RectTransform campaignRoundItem, int targetIndex, float spacing, bool isFlipped = false)
        {
            var contentRect = contentPanel.rect;
            var contentRectHeight = contentRect.height;
            var highestPoint = scrollRect.content.anchoredPosition.y;
            var lowestPoint = contentRectHeight - highestPoint;
            var targetPoint = lowestPoint;

            if (isFlipped)
            {
                lowestPoint = scrollRect.content.anchoredPosition.y;
                targetPoint = lowestPoint;
            }
            
            if (targetIndex > 2)
            {
                var instances = targetIndex - 2;
                var height = campaignRoundItem.rect.height;
                targetPoint -= height * instances + spacing * instances + height / 2;
            }
            
            var movement = 1 - targetPoint / lowestPoint;
            scrollRect.verticalNormalizedPosition = movement;
        }

        public static void MoveTo(this ScrollRect scrollRect, float normalizedPos)
        {
            scrollRect.verticalNormalizedPosition = normalizedPos;
        }
    }
}