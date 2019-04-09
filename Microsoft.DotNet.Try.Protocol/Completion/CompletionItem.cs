﻿using System;

namespace Microsoft.DotNet.Try.Protocol.Completion
{
    public class CompletionItem
    {
        public string DisplayText { get; }
        public string Kind { get; }
        public string FilterText { get; }
        public string SortText { get; }
        public string InsertText { get; }
        public MarkdownString Documentation { get; set; }
        public Uri AcceptanceUri { get; }
        public CompletionItem(string displayText, string kind, string filterText = null, string sortText = null, string insertText = null, MarkdownString documentation = null, Uri acceptanceUri = null)
        {
            DisplayText = displayText ?? throw new ArgumentNullException(nameof(displayText));
            Kind = kind ?? throw new ArgumentException(nameof(kind));
            FilterText = filterText;
            SortText = sortText;
            InsertText = insertText;
            Documentation = documentation;
            AcceptanceUri = acceptanceUri;
        }

        public override string ToString() => DisplayText;
    }
}