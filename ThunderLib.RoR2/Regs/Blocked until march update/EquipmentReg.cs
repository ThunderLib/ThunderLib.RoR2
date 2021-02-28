namespace ThunderLib.RoR2
{
    using System;
    using System.Collections.Generic;

    using ThunderLib.Core;
    using ThunderLib.Core.RegistrySystem;

    //TODO: Cannot implement this until after march update
    public sealed class EquipmentReg : Registry<EquipmentReg, EquipmentDefinition, EquipmentBackend>
    {
    }


    //TODO: March Update
    public class EquipmentDefinition : EquipmentReg.IRegistryDef
    {
        public String guid => throw new NotImplementedException();

        public EquipmentReg.RegistrationToken regToken { get; set; }
    }

    //TODO: March Update
    public struct EquipmentBackend : EquipmentReg.IRegistryBackend
    {
        public EquipmentReg.Element? this[EquipmentReg.Index index] => throw new NotImplementedException();

        public EquipmentReg.Element? this[String guid] => throw new NotImplementedException();

        public UInt64 count => throw new NotImplementedException();

        public Boolean CreateDefaultDefsIfNeeded() => throw new NotImplementedException();
        public IEnumerable<EquipmentReg.Element> EnumerateElements() => throw new NotImplementedException();
        public Boolean Finalize() => throw new NotImplementedException();
        public Boolean Init() => throw new NotImplementedException();
        public Boolean SetFromGuidMap(IEnumerable<(String guid, EquipmentReg.RegistrationToken token)> map) => throw new NotImplementedException();
        public Boolean SupplyAdditionalMap(IEnumerable<(String guid, EquipmentReg.RegistrationToken token)> map) => throw new NotImplementedException();
        public Boolean TryDisable() => throw new NotImplementedException();
        public Boolean TryEnable() => throw new NotImplementedException();
    }
}
