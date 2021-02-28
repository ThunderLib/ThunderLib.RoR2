namespace ThunderLib.RoR2
{
    using System;
    using System.Collections.Generic;

    using ThunderLib.Core;
    using ThunderLib.Core.RegistrySystem;

    //TODO: Cannot implement this until after march update
    public sealed class EntityStateReg : Registry<EntityStateReg, EntityStateDefinition, EntityStateBackend>
    {
    }


    //TODO: March Update
    public class EntityStateDefinition : EntityStateReg.IRegistryDef
    {
        public String guid => throw new NotImplementedException();

        public EntityStateReg.RegistrationToken regToken { get; set; }
    }

    //TODO: March Update
    public struct EntityStateBackend : EntityStateReg.IRegistryBackend
    {
        public EntityStateReg.Element? this[EntityStateReg.Index index] => throw new NotImplementedException();

        public EntityStateReg.Element? this[String guid] => throw new NotImplementedException();

        public UInt64 count => throw new NotImplementedException();

        public Boolean CreateDefaultDefsIfNeeded() => throw new NotImplementedException();
        public IEnumerable<EntityStateReg.Element> EnumerateElements() => throw new NotImplementedException();
        public Boolean Finalize() => throw new NotImplementedException();
        public Boolean Init() => throw new NotImplementedException();
        public Boolean SetFromGuidMap(IEnumerable<(String guid, EntityStateReg.RegistrationToken token)> map) => throw new NotImplementedException();
        public Boolean SupplyAdditionalMap(IEnumerable<(String guid, EntityStateReg.RegistrationToken token)> map) => throw new NotImplementedException();
        public Boolean TryDisable() => throw new NotImplementedException();
        public Boolean TryEnable() => throw new NotImplementedException();
    }
}
