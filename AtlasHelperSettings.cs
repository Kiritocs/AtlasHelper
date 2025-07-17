using System.Collections.Generic;
using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;
using SharpDX;

namespace AtlasHelper
{
    public class AtlasHelperSettings : ISettings
    {
        public Dictionary<string, int> MapStashAmount = new Dictionary<string, int>();
        public Dictionary<string, int[]> MapRegionsAmount = new Dictionary<string, int[]>();

        public AtlasHelperSettings()
        {

        }




        public ToggleNode Enable { get; set; } = new ToggleNode();
        public ToggleNode EnableDiagonalProgressionHighlight { get; set; } = new ToggleNode();
        public ToggleNode Debug { get; set; } = new ToggleNode(true);
        public ToggleNode SimulateHighestCompletedTier { get; set; } = new ToggleNode();

        public RangeNode<int> HighestCompletedTierSim { get; set; } = new RangeNode<int>(1, 2, 16);

        //[Menu("League")] // gonna use from GameController.Game.IngameState.ServerData.League
        //public ListNode League { get; set; } = new ListNode();

        public ToggleNode HighlightDuplicateMaps { get; set; } = new ToggleNode();
        public ColorNode HighlightDuplicateMapsColor { get; set; } = new ColorNode(Color.OrangeRed);
        public ToggleNode ShowCacheOnScreen { get; set; } = new ToggleNode(false);
        public ToggleNode HighlightIgnoredMaps { get; set; } = new ToggleNode();
        public ToggleNode WarnInsideMapToNotComplete { get; set; } = new ToggleNode();
        public ToggleNode ShowCurrencyHint { get; set; } = new ToggleNode();
        public ToggleNode ShowMapTierTopLeft { get; set; } = new ToggleNode();
        public ToggleNode ShowIfMapIsReadyOrNeedsCurrency { get; set; } = new ToggleNode();
        public ToggleNode DrawKiracMapsNaturalTier { get; set; } = new ToggleNode();
        public ColorNode UncompletedMaps { get; set; } = new ColorNode(Color.LightGreen);
        public ColorNode IgnoredMaps { get; set; } = new ColorNode(Color.Red);
        public ColorNode MapReady { get; set; } = new ColorNode(Color.LightGreen);
        public ColorNode MapNeedsCurrency { get; set; } = new ColorNode(Color.Yellow);
        public ColorNode DiagonalProgressionHighlightWillGiveCompletion { get; set; } = new ColorNode(Color.DeepPink);
        public ColorNode DiagonalProgressionHighlightWontGiveCompletion { get; set; } = new ColorNode(Color.Yellow);

        [Menu("Enchanted Mods Highlighting")]
        public ToggleNode HighlightEnchantedMods { get; set; } = new ToggleNode(false);

        [ConditionalDisplay(nameof(HighlightEnchantedMods))]
        [Menu("Harvest Beasts")]
        public ToggleNode EnchantedModHarvestBeasts { get; set; } = new ToggleNode(false);

        [ConditionalDisplay(nameof(HighlightEnchantedMods))]
        [Menu("Harvest Seeds")]
        public ToggleNode EnchantedModHarvestSeeds { get; set; } = new ToggleNode(false);

        [ConditionalDisplay(nameof(HighlightEnchantedMods))]
        [Menu("Flash Breaches")]
        public ToggleNode EnchantedModFlashBreaches { get; set; } = new ToggleNode(false);
        
        [ConditionalDisplay(nameof(HighlightEnchantedMods))]
        [Menu("Player is Harbinger")]
        public ToggleNode EnchantedModHarbinger { get; set; } = new ToggleNode(false);
    }
}
