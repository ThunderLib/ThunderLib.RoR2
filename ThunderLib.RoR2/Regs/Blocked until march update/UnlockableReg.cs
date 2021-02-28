namespace ThunderLib.RoR2
{
    using System;
    using System.Collections.Generic;

    using ThunderLib.Core;
    using ThunderLib.Core.RegistrySystem;

    //TODO: Cannot implement this until after march update
    public sealed class UnlockableReg : Registry<UnlockableReg, UnlockableDefinition, UnlockableBackend>
    {
    }


    //TODO: March Update
    public class UnlockableDefinition : UnlockableReg.IRegistryDef
    {
        public String guid => throw new NotImplementedException();

        public UnlockableReg.RegistrationToken regToken { get; set; }
    }

    //TODO: March Update
    public struct UnlockableBackend : UnlockableReg.IRegistryBackend
    {
        public UnlockableReg.Element? this[UnlockableReg.Index index] => throw new NotImplementedException();

        public UnlockableReg.Element? this[String guid] => throw new NotImplementedException();

        public UInt64 count => throw new NotImplementedException();

        public Boolean CreateDefaultDefsIfNeeded() => throw new NotImplementedException();
        public IEnumerable<UnlockableReg.Element> EnumerateElements() => throw new NotImplementedException();
        public Boolean Finalize() => throw new NotImplementedException();
        public Boolean Init() => throw new NotImplementedException();
        public Boolean SetFromGuidMap(IEnumerable<(String guid, UnlockableReg.RegistrationToken token)> map) => throw new NotImplementedException();
        public Boolean SupplyAdditionalMap(IEnumerable<(String guid, UnlockableReg.RegistrationToken token)> map) => throw new NotImplementedException();
        public Boolean TryDisable() => throw new NotImplementedException();
        public Boolean TryEnable() => throw new NotImplementedException();
    }
}
