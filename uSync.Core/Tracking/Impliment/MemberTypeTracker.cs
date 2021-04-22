﻿using System.Linq;

using Umbraco.Cms.Core.Models;

using uSync.Core.Serialization;

namespace uSync.Core.Tracking.Impliment
{
    public class MemberTypeTracker : ContentTypeBaseTracker<IMemberType>, ISyncNodeTracker<IMemberType>
    {
        public MemberTypeTracker(ISyncSerializer<IMemberType> serializer) : base(serializer)
        { }
    }
}