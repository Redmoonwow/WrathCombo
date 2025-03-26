﻿using static WrathCombo.CustomComboNS.Functions.CustomComboFunctions;

namespace WrathCombo.Combos.PvP
{
    class PvPCaster //Offensive Magic
    {
        public const uint
            Comet = 43252,
            PhantomDart = 43291,
            Rust = 43254;

        public class Debuffs
        {
            public const ushort
                PhantomDart = 1234,
                Rust = 4480;
        }

        public bool CanComet() => ActionReady(Comet);
        public bool CanPhantomDart() => ActionReady(PhantomDart);
        public bool CanRust() => ActionReady(Rust);
    }

    class PvPHealer //Healers
    {
        public const uint
            Haelan = 43255,
            StoneskinII = 43256,
            Diabrosis = 43257;

        public class Buffs
        {
            public const ushort
                StoneSkinII = 4481;
        }

        public class Debuffs
        {
            public const ushort
                Diabrosis = 4482;
        }

        public static bool CanHaelan() => ActionReady(Haelan);
        public static bool CanStoneSkinII() => ActionReady(StoneskinII);
        public static bool CanDiabrosis() => ActionReady(Diabrosis);


    }

    class PvPPhysRanged
    {
        public const uint
            Dervish = 43249,
            Bravery = 43250,
            EagleEyeShot = 43251;

        public class Buffs
        {
            public const ushort
                Dervish = 4478,
                Bravery = 4479;
        }

        public static bool CanDervish() => ActionReady(Dervish);
        public static bool CanBravery() => ActionReady(Bravery);
        public static bool CanEagleEyeShot() => ActionReady(EagleEyeShot);
    }

    class PvPMelee
    {
        public const uint
            Bloodbath = 43246,
            Swift = 43247,
            Smite = 43248;

        public class Buffs
        {
            public const ushort
            //    Bloodbath = 1234; // NEED VERIFICATION IT EVEN IS A BUFF, CANNOT FIND
                Swift = 4477;
        }

        public static bool CanBloodBath(int healthpercent) =>
           ActionReady(Bloodbath) && PlayerHealthPercentageHp() < healthpercent;
        public static bool CanSwift() => ActionReady(Swift);
        public static bool CanSmite() => ActionReady(Smite);
    }

    class PvPTank
    {
        public const uint
            Rampage = 43243,
            Rampart = 43244,
            FullSwing = 43245;

        public class Buffs
        {
            public const ushort
                Rampart = 4168;
        }

        public class Debuffs
        {
            public const ushort
                Rampage = 4476; 
        }

        public static bool CanRampage() =>
            IsEnabled(Rampage) && ActionReady(Rampage);

        public static bool CanRampart(int healthPercent) =>
            IsEnabled(Rampage) && ActionReady(Rampart) && PlayerHealthPercentageHp() < healthPercent;

        public static bool CanFullSwing() =>
            IsEnabled(FullSwing) && ActionReady(FullSwing);
    }
}
