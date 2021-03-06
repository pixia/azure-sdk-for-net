// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace Azure.Search.Models
{
    /// <summary> Specifies the mode for Autocomplete. The default is &apos;oneTerm&apos;. Use &apos;twoTerms&apos; to get shingles and &apos;oneTermWithContext&apos; to use the current context in producing autocomplete terms. </summary>
    public enum AutocompleteMode
    {
        /// <summary> oneTerm. </summary>
        OneTerm,
        /// <summary> twoTerms. </summary>
        TwoTerms,
        /// <summary> oneTermWithContext. </summary>
        OneTermWithContext
    }
}
