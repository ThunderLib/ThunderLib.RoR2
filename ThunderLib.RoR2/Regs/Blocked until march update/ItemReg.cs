namespace ThunderLib.RoR2
{
    using System;
    using System.Collections.Generic;

    using ThunderLib.Core;
    using ThunderLib.Core.RegistrySystem;

    //TODO: Cannot implement this until after march update
    public sealed class ItemReg : Registry<ItemReg, ItemDefinition, ItemBackend>
    {
    }


    //TODO: March Update
    public class ItemDefinition : ItemReg.IRegistryDef
    {
        public String guid => throw new NotImplementedException();

        public ItemReg.RegistrationToken regToken { get; set; }
    }

    //TODO: March Update
    public struct ItemBackend : ItemReg.IRegistryBackend
    {
        public ItemReg.Element? this[ItemReg.Index index] => throw new NotImplementedException();

        public ItemReg.Element? this[String guid] => throw new NotImplementedException();

        public UInt64 count => throw new NotImplementedException();

        public Boolean CreateDefaultDefsIfNeeded() => throw new NotImplementedException();
        public IEnumerable<ItemReg.Element> EnumerateElements() => throw new NotImplementedException();
        public Boolean Finalize() => throw new NotImplementedException();
        public Boolean Init() => throw new NotImplementedException();
        public Boolean SetFromGuidMap(IEnumerable<(String guid, ItemReg.RegistrationToken token)> map) => throw new NotImplementedException();
        public Boolean SupplyAdditionalMap(IEnumerable<(String guid, ItemReg.RegistrationToken token)> map) => throw new NotImplementedException();
        public Boolean TryDisable() => throw new NotImplementedException();
        public Boolean TryEnable() => throw new NotImplementedException();
    }
}
