---
-api-id: M:Microsoft.Windows.AI.Text.TextRewriter.#ctor(Microsoft.Windows.AI.Text.LanguageModel)
-api-type: winrt constructor
---

# Microsoft.Windows.AI.Text.TextRewriter.#ctor(Microsoft.Windows.AI.Text.LanguageModel)

<!--
public TextRewriter (Microsoft.Windows.AI.Text.LanguageModel languageModel);
-->

## -description

Initializes a new instance of a [TextRewriter](textrewriter.md) object.

## -parameters

### -param languageModel

The local small language model.

## -remarks

The **LanguageModel** must be created and ready before passing it to this constructor. Call [LanguageModel.GetReadyState](languagemodel_getreadystate_1726041729.md), [LanguageModel.EnsureReadyAsync](languagemodel_ensurereadyasync_1335418254.md), and [LanguageModel.CreateAsync](languagemodel_createasync_616540418.md) to get a ready instance.

## -see-also

[LanguageModel](languagemodel.md), [TextRewriter](textrewriter.md)

## -examples
