﻿namespace ItemManager.Core.Modules.Snatcher.Controllables
{
    using Ensage;

    using Menus.Modules.Snatcher;

    internal abstract class Controllable
    {
        protected Controllable(Unit unit)
        {
            Unit = unit;
            Handle = unit.Handle;
        }

        public uint Handle { get; }

        protected Unit Unit { get; }

        public abstract bool CanPick(PhysicalItem physicalItem, Manager manager, SnatcherMenu menu);

        public abstract bool CanPick(Rune rune);

        public bool IsValid()
        {
            return Unit != null && Unit.IsValid && Unit.IsAlive;
        }

        public void Pick(PhysicalItem item)
        {
            Unit.PickUpItem(item);
        }

        public void Pick(Rune rune)
        {
            Unit.PickUpRune(rune);
        }
    }
}