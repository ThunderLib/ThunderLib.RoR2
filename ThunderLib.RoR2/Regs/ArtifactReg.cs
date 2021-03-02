namespace ThunderLib.RoR2
{
    using System;

    using ThunderLib.Core;
    using ThunderLib.Core.RegistrySystem;
    using ThunderLib.Monomod;

    using System.Collections.Generic;
    using global::RoR2;
    using Rewired.Data.Mapping;
    using System.Linq;

    public sealed class ArtifactReg : Registry<ArtifactReg, ArtifactDefinition, ArtifactReg.ArtifactBackend>
    {
        public struct ArtifactBackend : ArtifactReg.IRegistryBackend
        {
            public Boolean TryDisable() => true; // No hooks needed here
            public Boolean TryEnable() => true; // No hooks needed here

            private List<ArtifactReg.Element> elements;
            private List<ArtifactReg.RegistrationToken> defaults;

            private Dictionary<String, ArtifactReg.Element> guidToElement;

            public Boolean Init()
            {
                if(this.elements is not null)
                {
                    //TODO: Log error
                    //This means init was called twice, which indicates a problem in code flow.
                    return false;
                }
                this.elements = new();
                this.guidToElement = new();
                return true;
            }
            public Boolean CreateDefaultDefsIfNeeded()
            {
                if(this.defaults is not null)
                {
                    //TODO: Log error
                    //Indicates incorrect behaviour in code flow
                    return false;
                }
                this.defaults = new();
                foreach(var d in ArtifactCatalog.artifactDefs)
                {
                    var def = (ArtifactDefinition)new DefaultArtifactDefinition(d);
                    var tok = ArtifactReg._Add(ref def, true);
                    this.defaults.Add(tok);
                }
                return true;
            }
            public UInt64 count => (UInt64)(this.elements?.Count ?? 0);
            public IEnumerable<ArtifactReg.Element> EnumerateElements() => this.elements ?? Enumerable.Empty<ArtifactReg.Element>();
            //TODO: List only accepts int in indexer for whatever reason so it doesn't actually work as a storage location here... need to implement a new one...
            public ArtifactReg.Element? this[ArtifactReg.Index index] => (UInt64)index > this.count ? null : this.elements?[(Int32)index];
            public ArtifactReg.Element? this[String guid] => this.guidToElement is null ? null : this.guidToElement.TryGetValue(guid, out var val) ? val : null;


            public Boolean SetFromGuidMap(IEnumerable<(String guid, ArtifactReg.RegistrationToken token)> map)
            {
                //TODO: Null check and return false
                this.elements.Clear();
                this.guidToElement.Clear();
                //TODO: May need to update state of things before clearing.

                foreach(var (guid, token) in map)
                {
                    //TODO: Some refactoring possible here.
                    if(!this.guidToElement.TryGetValue(guid, out var elem))
                    {
                        elem = ArtifactReg._CreateElement(guid);
                        var index = (ArtifactReg.Index)this.count;
                        ArtifactReg._ModifyElement(elem, index);
                        this.elements.Add(elem);
                    } else
                    {
                        //TODO: Log message saying an override occured for some guid
                    }
                    ArtifactReg._ModifyElement(elem, token);
                }

                return true;
            }
            public Boolean SupplyAdditionalMap(IEnumerable<(String guid, ArtifactReg.RegistrationToken token)> map)
            {
                foreach(var (guid, token) in map)
                {
                    //TODO: Some refactoring possible here.
                    if(!this.guidToElement.TryGetValue(guid, out var elem))
                    {
                        elem = ArtifactReg._CreateElement(guid);
                        var index = (ArtifactReg.Index)this.count;
                        ArtifactReg._ModifyElement(elem, index);
                        this.elements.Add(elem);
                    } else
                    {
                        //TODO: Log message saying an override occured for some guid
                    }
                    ArtifactReg._ModifyElement(elem, token);
                }

                return true;
            }
            public Boolean Finalize()
            {
                var array = new ArtifactDef[this.count];

                //TODO: Decide on if this is required style when for looping on unsigned values
                for(UInt64 i = 0; i < this.count; i = checked(i++))
                {
                    var elem = this.elements[(Int32)i];
                    var def = elem.regToken.def.def;
                    array[i] = def;
                }
                ArtifactCatalog.artifactDefs = array;

                return true;
            }
        }
    }

    public abstract class ArtifactDefinition : ArtifactReg.IRegistryDef
    {
        public abstract String guid { get; }
        public abstract ArtifactDef def { get; }
        public ArtifactReg.RegistrationToken regToken { get; set; }
    }

    internal sealed class DefaultArtifactDefinition : ArtifactDefinition
    {
        internal DefaultArtifactDefinition(ArtifactDef d)
        {
            this.def = d;
            this.guid = this.def.cachedName;
        }

        public override String guid { get; }
        public override ArtifactDef def { get; }
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