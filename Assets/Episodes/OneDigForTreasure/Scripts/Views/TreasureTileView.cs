using Episodes.OneDigForTreasure.Scripts.Config;
using UnityEngine;
using UnityEngine.UI;

namespace Episodes.OneDigForTreasure.Scripts.Views
{
    public class TreasureTileView : MonoBehaviour
    {
        [SerializeField] private Button _selectButton;
        [SerializeField] private GameObject _backgroundView;
        [SerializeField] private GameObject _revealedView;
        [SerializeField] private TreasureTileViewConfig _tileViewConfig;
        [SerializeField] private Image _tierImage;

        public bool IsRevealed
        {
            set
            {
                _backgroundView.SetActive(!value);
                _revealedView.SetActive(value);
            }
        }

        public Sprite TierSprite
        {
            set => _tierImage.sprite = value;
        }

        public void Init(TreasureTileTier tier)
        {
            TierSprite = _tileViewConfig.GetSprite(tier);
        }

        private void Awake()
        {
            IsRevealed = false;
            _selectButton.onClick.AddListener(() => IsRevealed = true);
        }
    }    
}