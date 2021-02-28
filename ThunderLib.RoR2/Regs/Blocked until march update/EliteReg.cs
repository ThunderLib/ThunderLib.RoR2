namespace ThunderLib.RoR2
{
    using System;
    using System.Collections.Generic;

    using ThunderLib.Core;
    using ThunderLib.Core.RegistrySystem;

    //TODO: Cannot implement this until after march update
    public sealed class EliteReg : Registry<EliteReg, EliteDefinition, EliteBackend>
    {
    }


    //TODO: March Update
    public class EliteDefinition : EliteReg.IRegistryDef
    {
        public String guid => throw new NotImplementedException();

        public EliteReg.RegistrationToken regToken { get; set; }
    }

    //TODO: March Update
    public struct EliteBackend : EliteReg.IRegistryBackend
    {
        public EliteReg.Element? this[EliteReg.Index index] => throw new NotImplementedException();

        public EliteReg.Element? this[String guid] => throw new NotImplementedException();

        public UInt64 count => throw new NotImplementedException();

        public Boolean CreateDefaultDefsIfNeeded() => throw new NotImplementedException();
        public IEnumerable<EliteReg.Element> EnumerateElements() => throw new NotImplementedException();
        public Boolean Finalize() => throw new NotImplementedException();
        public Boolean Init() => throw new NotImplementedException();
        public Boolean SetFromGuidMap(IEnumerable<(String guid, EliteReg.RegistrationToken token)> map) => throw new NotImplementedException();
        public Boolean SupplyAdditionalMap(IEnumerable<(String guid, EliteReg.RegistrationToken token)> map) => throw new NotImplementedException();
        public Boolean TryDisable() => throw new NotImplementedException();
        public Boolean TryEnable() => throw new NotImplementedException();
    }
}
