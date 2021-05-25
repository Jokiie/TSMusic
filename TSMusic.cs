using Terraria;
using Terraria.ModLoader;


namespace TSMusic
{
    public class TSMusic : Mod
    {
        public TSMusic Instance;

        public TSMusic()
        {
            Mod = this;

            Instance = this;

            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true,
                AutoloadBackgrounds = true
            };
        }

        public static Mod TerraStory { get; set; }

        public static TSMusic Mod { get; set; }

        public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
            if (Main.myPlayer != -1 && !Main.gameMenu)
            {
                if (!Main.dayTime
                && Main.player[Main.myPlayer].ZoneOverworldHeight
                && !Main.player[Main.myPlayer].ZoneJungle
                && !Main.player[Main.myPlayer].ZoneSnow
                && !Main.player[Main.myPlayer].ZoneCrimson
                && !Main.player[Main.myPlayer].ZoneCorrupt)
                //&& !Main.player[Main.myPlayer].ZoneHoly
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/HenesysShadow");
                    priority = MusicPriority.BiomeLow;
                }
           
                if (Main.player[Main.myPlayer].ZoneSkyHeight)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/HighEnough");
                    priority = MusicPriority.Environment;
                }

                if (Main.player[Main.myPlayer].ZoneUnderworldHeight)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/ZakumFinalFight");
                    priority = MusicPriority.Environment;
                }

                if (Main.player[Main.myPlayer].ZoneJungle)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/JungleBook");
                    priority = MusicPriority.Environment;
                }
                if (Main.player[Main.myPlayer].ZoneDesert)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/SunsetDesert");
                    priority = MusicPriority.Environment;
                }
                if (Main.player[Main.myPlayer].ZoneSnow)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/IceVillageSnow");
                    priority = MusicPriority.BiomeMedium;
                }
                if (Main.player[Main.myPlayer].ZoneSnow)
                    if (!Main.dayTime)
                    {
                        music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/WolfWood");
                        priority = MusicPriority.BiomeMedium;
                    }
                if (Main.player[Main.myPlayer].ZoneSnow
                && Main.player[Main.myPlayer].ZoneRockLayerHeight)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/FantasyCastle");
                    priority = MusicPriority.Environment;
                }
                if (Main.player[Main.myPlayer].ZoneHoly)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/DreamHallow");
                    priority = MusicPriority.BiomeLow;
                }
                if (Main.player[Main.myPlayer].ZoneCorrupt)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/Laby");
                    priority = MusicPriority.BiomeHigh;
                }
                if (Main.player[Main.myPlayer].ZoneCrimson)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/CrimsonwoodCrimson");
                    priority = MusicPriority.BiomeHigh;
                }
                if (Main.player[Main.myPlayer].ZoneDirtLayerHeight
                && !Main.player[Main.myPlayer].ZoneJungle
                && !Main.player[Main.myPlayer].ZoneSnow
                && !Main.player[Main.myPlayer].ZoneCrimson
                && !Main.player[Main.myPlayer].ZoneCorrupt
                && !Main.player[Main.myPlayer].ZoneHoly
                && !Main.player[Main.myPlayer].ZoneDesert)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/UnderGround");
                    priority = MusicPriority.Environment;
                }
                if (Main.player[Main.myPlayer].ZoneRockLayerHeight
                && !Main.player[Main.myPlayer].ZoneJungle
                && !Main.player[Main.myPlayer].ZoneSnow
                && !Main.player[Main.myPlayer].ZoneCrimson
                && !Main.player[Main.myPlayer].ZoneCorrupt
                && !Main.player[Main.myPlayer].ZoneHoly
                && !Main.player[Main.myPlayer].ZoneDesert)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/AbandonnedMines");
                    priority = MusicPriority.Environment;
                }
                if (Main.player[Main.myPlayer].ZoneSandstorm
                && Main.player[Main.myPlayer].ZoneDesert)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/PerionSandstorm");
                    priority = MusicPriority.Environment;
                }
                if (Main.player[Main.myPlayer].ZoneBeach)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/BlueWorld");
                    priority = MusicPriority.BiomeLow;
                }
                if (Main.player[Main.myPlayer].ZoneRain
                && Main.player[Main.myPlayer].ZoneOverworldHeight
                && !Main.player[Main.myPlayer].ZoneJungle
                && !Main.player[Main.myPlayer].ZoneCorrupt
                && !Main.player[Main.myPlayer].ZoneCrimson
                && !Main.player[Main.myPlayer].ZoneBeach
                && !Main.player[Main.myPlayer].ZoneHoly
                && !Main.player[Main.myPlayer].ZoneDesert
                && !Main.player[Main.myPlayer].ZoneSkyHeight
                && !Main.player[Main.myPlayer].ZoneSnow)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/MissingYouRain");
                    priority = MusicPriority.Event;
                }
                if (Main.dayTime
                && Main.player[Main.myPlayer].ZoneOverworldHeight
                && !Main.player[Main.myPlayer].ZoneDesert
                && !Main.player[Main.myPlayer].ZoneJungle
                && !Main.player[Main.myPlayer].ZoneSnow
                && !Main.player[Main.myPlayer].ZoneCrimson
                && !Main.player[Main.myPlayer].ZoneCorrupt
                && !Main.player[Main.myPlayer].ZoneHoly)
                {
                    music = (this).GetSoundSlot(SoundType.Music, "Sounds/Music/HenesysFields");
                    priority = MusicPriority.BiomeLow;
                }
            }
        }
    }
}