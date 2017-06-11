// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Microsoft.Restier.Core.Submit
{

    /// <summary>
    /// Represents an item in a change set.
    /// </summary>
    public abstract class ChangeSetItem
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeSetItem"/> class.
        /// </summary>
        /// <param name="type">The <see cref="ChangeSetItemType" /> for this item.</param>
        internal ChangeSetItem(ChangeSetItemType type)
        {
            this.Type = type;
            this.ChangeSetItemProcessingStage = ChangeSetItemProcessingStage.Initialized;
        }

        /// <summary>
        /// Gets the type of this change set item.
        /// </summary>
        internal ChangeSetItemType Type { get; private set; }

        /// <summary>
        /// Gets or sets the dynamic state of this change set item.
        /// </summary>
        internal ChangeSetItemProcessingStage ChangeSetItemProcessingStage { get; set; }

        /// <summary>
        /// Indicates whether this change set item is in a changed state.
        /// </summary>
        /// <returns>
        /// Whether this change set item is in a changed state.
        /// </returns>
        public bool HasChanged()
        {
            return this.ChangeSetItemProcessingStage == ChangeSetItemProcessingStage.Initialized ||
                this.ChangeSetItemProcessingStage == ChangeSetItemProcessingStage.ChangedWithinOwnPreEventing;
        }

    }

}
