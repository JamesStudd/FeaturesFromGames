using System.Collections.Generic;
using Episodes.OneDigForTreasure.Scripts.Config;
using UnityEngine;
using Utility.Extensions;

namespace Episodes.OneDigForTreasure.Scripts.Views
{
    public class TreasureTileCollectionView : MonoBehaviour
    {
        [SerializeField] private TreasureTileView[] _treasureTileViews;

        private void Awake()
        {
            var tiers = new List<TreasureTileTier>();
            const int amountOfEachTier = 4;
            
            EnumHelper<TreasureTileTier>.ForEach(tier =>
            {
                for (var i = 0; i < amountOfEachTier; i++)
                {
                    tiers.Add(tier);
                }
            });
            
            _treasureTileViews.ForEach(view =>
            {
                var tier = tiers.RandomElement();
                view.Init(tier);
                tiers.Remove(tier);
            });
        }
    }
}