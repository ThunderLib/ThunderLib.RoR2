namespace ThunderLib.RoR2
{
    using System;
    using System.Collections.Generic;

    using ThunderLib.Core;
    using ThunderLib.Core.RegistrySystem;

    public sealed class SurvivorReg : Registry<SurvivorReg, SurvivorDefinition, SurvivorBackend>
    {
    }


    //TODO: March Update
    public class SurvivorDefinition : SurvivorReg.IRegistryDef
    {
        public String guid => throw new NotImplementedException();

        public SurvivorReg.RegistrationToken regToken { get; set; }
    }

    //TODO: March Update
    public struct SurvivorBackend : SurvivorReg.IRegistryBackend
    {
        public SurvivorReg.Element? this[SurvivorReg.Index index] => throw new NotImplementedException();

        public SurvivorReg.Element? this[String guid] => throw new NotImplementedException();

        public UInt64 count => throw new NotImplementedException();

        public Boolean CreateDefaultDefsIfNeeded() => throw new NotImplementedException();
        public IEnumerable<SurvivorReg.Element> EnumerateElements() => throw new NotImplementedException();
        public Boolean Finalize() => throw new NotImplementedException();
        public Boolean Init() => throw new NotImplementedException();
        public Boolean SetFromGuidMap(IEnumerable<(String guid, SurvivorReg.RegistrationToken token)> map) => throw new NotImplementedException();
        public Boolean SupplyAdditionalMap(IEnumerable<(String guid, SurvivorReg.RegistrationToken token)> map) => throw new NotImplementedException();
        public Boolean TryDisable() => throw new NotImplementedException();
        public Boolean TryEnable() => throw new NotImplementedException();
    }
}
