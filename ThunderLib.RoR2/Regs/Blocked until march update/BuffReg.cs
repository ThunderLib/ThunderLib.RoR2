namespace ThunderLib.RoR2
{
    using System;
    using System.Collections.Generic;

    using ThunderLib.Core;
    using ThunderLib.Core.RegistrySystem;

    //TODO: Cannot implement this until after march update
    public sealed class BuffReg : Registry<BuffReg, BuffDefinition, BuffBackend>
    {
    }


    //TODO: March Update
    public class BuffDefinition : BuffReg.IRegistryDef
    {
        public String guid => throw new NotImplementedException();

        public BuffReg.RegistrationToken regToken { get; set; }
    }

    //TODO: March Update
    public struct BuffBackend : BuffReg.IRegistryBackend
    {
        public BuffReg.Element? this[BuffReg.Index index] => throw new NotImplementedException();

        public BuffReg.Element? this[String guid] => throw new NotImplementedException();

        public UInt64 count => throw new NotImplementedException();

        public Boolean CreateDefaultDefsIfNeeded() => throw new NotImplementedException();
        public IEnumerable<BuffReg.Element> EnumerateElements() => throw new NotImplementedException();
        public Boolean Finalize() => throw new NotImplementedException();
        public Boolean Init() => throw new NotImplementedException();
        public Boolean SetFromGuidMap(IEnumerable<(String guid, BuffReg.RegistrationToken token)> map) => throw new NotImplementedException();
        public Boolean SupplyAdditionalMap(IEnumerable<(String guid, BuffReg.RegistrationToken token)> map) => throw new NotImplementedException();
        public Boolean TryDisable() => throw new NotImplementedException();
        public Boolean TryEnable() => throw new NotImplementedException();
    }
}
