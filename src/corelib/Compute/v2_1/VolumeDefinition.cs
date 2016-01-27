using System.Collections.Generic;
using Newtonsoft.Json;
using OpenStack.Serialization;

namespace OpenStack.Compute.v2_1
{
    /// <summary />
    [JsonConverterWithConstructor(typeof(RootWrapperConverter), "volume")]
    public class VolumeDefinition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeDefinition"/> class.
        /// </summary>
        protected VolumeDefinition()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeDefinition"/> class.
        /// </summary>
        /// <param name="size">The size of the volume, in gigabytes (GB).</param>
        public VolumeDefinition(int size)
        {
            Size = size;
        }

        /// <summary>
        /// The volume name.
        /// </summary>
        [JsonProperty("display_name")]
        public string Name { get; set; }

        /// <summary>
        /// The volume description.
        /// </summary>
        [JsonProperty("display_description")]
        public string Description { get; set; }

        /// <summary>
        /// The size of the volume, in gigabytes (GB).
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }

        /// <summary>
        /// The unique identifier for a volume type.
        /// </summary>
        [JsonProperty("volume_type")]
        public Identifier VolumeTypeId { get; set; }

        /// <summary>
        /// One or more metadata key and value pairs to associate with the volume.
        /// </summary>
        [JsonProperty("metadata")]
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The availability zone.
        /// </summary>
        [JsonProperty("availability_zone")]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// The snapshot from which to create a volume.
        /// </summary>
        [JsonProperty("snapshot_id")]
        public Identifier SourceSnapshotId { get; set; }
    }
}