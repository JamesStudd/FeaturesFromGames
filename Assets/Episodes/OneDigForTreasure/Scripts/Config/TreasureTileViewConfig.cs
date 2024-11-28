using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Episodes.OneDigForTreasure.Scripts.Config
{
    [CreateAssetMenu(fileName = nameof(TreasureTileViewConfig), menuName = "OneDigForTreasure/" + nameof(TreasureTileViewConfig), order = 0)]
    public class TreasureTileViewConfig : ScriptableObject
    {
        [Serializable]
        public class Config
        {
            [SerializeField] private TreasureTileTier _tier;
            [SerializeField] private Sprite _sprite;
            
            public TreasureTileTier Tier => _tier;
            public Sprite Sprite => _sprite;
        }

        [SerializeField] private Config[] _configs;

        private Dictionary<TreasureTileTier, Config> _configCache;
        private Dictionary<TreasureTileTier, Config> ConfigCache => _configCache ??= _configs.ToDictionary(e => e.Tier);

        public Sprite GetSprite(TreasureTileTier type) => ConfigCache[type].Sprite;
    }
}