using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptEditor
{
    public static class Globals
    {
        public enum Languages
        {
            Universal = 0,
            Orcish = 1,
            Darnassian = 2,
            Taurahe = 3,
            Dwarvish = 6,
            Common = 7,
            Demonic = 8,
            Titan = 9,
            Thalassian = 10,
            Draconic = 11,
            Kalimag = 12,
            Gnomish = 13,
            Troll = 14,
            Gutterspeak = 33
        }

        public enum ChatTypes
        {
            Say = 0,
            Yell = 1,
            Emote = 2,
            ZoneEmote = 3,
            Whisper = 4,
            BossWhisper = 5,
            ZoneYell = 6
        }

        public enum Finders
        {
            Areas,
            Creatures,
            Events,
            Factions,
            FactionTemplates,
            GameObjects,
            Items,
            Quests,
            Spells,
            Taxis,
            BroadcastTexts
        }

        public enum FlagHelpers
        {
            GenericFlags,
            GameObjectDynamicFlags,
            GameObjectFlags,
            NpcFlags,
            PlayerFlags,
            SpellMechanicMask,
            UnitDynamicFlags,
            UnitFlags
        }
    }
}
