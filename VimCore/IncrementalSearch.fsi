﻿#light

namespace Vim
open Microsoft.VisualStudio.Text
open Microsoft.VisualStudio.Text.Operations
open Microsoft.VisualStudio.Text.Editor
open Microsoft.VisualStudio.Text.Outlining

type internal IncrementalSearch =
    new : ITextView * IOutliningManager option * IVimLocalSettings * ITextStructureNavigator * ISearchService * IVimData -> IncrementalSearch
    interface IIncrementalSearch
