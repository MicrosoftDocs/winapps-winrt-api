---
-api-id: T:Microsoft.Windows.AI.Text.LanguageModel
-api-type: winrt class
---

# Microsoft.Windows.AI.Text.LanguageModel

<!--
public sealed class LanguageModel : System.IDisposable
-->

## -description

Represents a local small language model.

## -remarks

The **LanguageModel** class provides access to Phi Silica, a local small language model (SLM) optimized for Windows Copilot+ PCs with a neural processing unit (NPU). The model runs entirely on-device, which means prompts and responses stay local and no internet connection is required.

Before creating a **LanguageModel** instance, call [GetReadyState](languagemodel_getreadystate_1726041729.md) to check whether the model is available on the device. If the model is not ready, call [EnsureReadyAsync](languagemodel_ensurereadyasync_1335418254.md) to download and prepare it. Then call [CreateAsync](languagemodel_createasync_616540418.md) to create an instance.

The **LanguageModel** class implements [IDisposable](/dotnet/api/system.idisposable), so you should use a `using` statement (C#) or call **Close** (C++/WinRT) to release model resources when you are done.

You can use **LanguageModel** directly to generate free-form text responses through [GenerateResponseAsync](languagemodel_generateresponseasync_1596814667.md), or pass a **LanguageModel** instance to a Text Intelligence Skill class such as [TextSummarizer](textsummarizer.md), [TextRewriter](textrewriter.md), or [TextToTableConverter](texttotableconverter.md) for structured text transformations.

> [!IMPORTANT]
> Phi Silica features are not available in China.

## -see-also

[Get started with Phi Silica](/windows/ai/apis/phi-silica), [LanguageModelOptions](languagemodeloptions.md), [LanguageModelResponseResult](languagemodelresponseresult.md), [TextSummarizer](textsummarizer.md), [TextRewriter](textrewriter.md), [TextToTableConverter](texttotableconverter.md), [Content moderation](/windows/ai/apis/content-moderation)

## -examples

The following example shows how to check model availability, create a **LanguageModel**, and generate a response.

```csharp
using Microsoft.Windows.AI.Text;
using Microsoft.Windows.AI;

if (LanguageModel.GetReadyState() != AIFeatureReadyState.Ready) 
{ 
    await LanguageModel.EnsureReadyAsync(); 
} 

using LanguageModel languageModel = await LanguageModel.CreateAsync();

string prompt = "Provide the molecular formula for glucose.";
var result = await languageModel.GenerateResponseAsync(prompt);

Console.WriteLine(result.Text);
// Output: C6H12O6
```
