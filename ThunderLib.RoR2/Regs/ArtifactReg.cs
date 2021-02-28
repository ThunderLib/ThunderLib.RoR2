// TODO: Implement
namespace ThunderLib.RoR2
{
    using System;

    using ThunderLib.Core;
    using ThunderLib.Core.RegistrySystem;
    using ThunderLib.Monomod;

    using RoR2;
    using System.Collections.Generic;

    public sealed class ArtifactReg : Registry<ArtifactReg, ArtifactDefinition, ArtifactBackend>
    {

    }

    public class ArtifactDefinition : ArtifactReg.IRegistryDef
    {
        public String guid => throw new NotImplementedException();

        public ArtifactReg.RegistrationToken regToken { get; set; }
    }

    public struct ArtifactBackend : ArtifactReg.IRegistryBackend
    {
        public ArtifactReg.Element? this[ArtifactReg.Index index] => throw new NotImplementedException();

        public ArtifactReg.Element? this[String guid] => throw new NotImplementedException();

        public UInt64 count => throw new NotImplementedException();

        public Boolean CreateDefaultDefsIfNeeded() => throw new NotImplementedException();
        public IEnumerable<ArtifactReg.Element> EnumerateElements() => throw new NotImplementedException();
        public Boolean Finalize() => throw new NotImplementedException();
        public Boolean Init() => throw new NotImplementedException();
        public Boolean SetFromGuidMap(IEnumerable<(String guid, ArtifactReg.RegistrationToken token)> map) => throw new NotImplementedException();
        public Boolean SupplyAdditionalMap(IEnumerable<(String guid, ArtifactReg.RegistrationToken token)> map) => throw new NotImplementedException();
        public Boolean TryDisable() => throw new NotImplementedException();
        public Boolean TryEnable() => throw new NotImplementedException();
    }

}

/* Ordering needs:
 *  Must be after vanilla artifact catalog init
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */