---
-api-id: T:Microsoft.UI.Xaml.DispatcherTimer
-api-type: winrt class
---

<!-- Class syntax.
public class DispatcherTimer : Microsoft.UI.Xaml.IDispatcherTimer
-->

# Microsoft.UI.Xaml.DispatcherTimer

## -description

Provides a timer that is integrated into the **Dispatcher** queue, which is processed at a specified interval of time and at a specified priority.

## -remarks

The `DispatcherTimer` can be used to run code on the same thread that produces the UI thread. Code running on this thread has the privilege to create and modify objects that can only be created and modified on the UI thread. To specify that code should run on the UI thread, set the [Interval](dispatchertimer_interval.md) property and then call the [Start](dispatchertimer_start_1587696324.md) method. The [Tick](dispatchertimer_tick.md) event fires after the time specified in `Interval` has elapsed. `Tick` continues firing at the same `Interval` until the [Stop](dispatchertimer_stop_1201535524.md) method is called, the app terminates, or the app is suspended.

One scenario for `DispatcherTimer` is to check properties on sensors where changes to the sensor values are not purely event-driven, or the events don't give you the granularity you want. You can see this in the [Accelerometer sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/Accelerometer).

Other scenarios for `DispatcherTimer` include checking for state changes that don't have related events, or for periodic UI updates that can't use a storyboarded animation or a two-way binding.

## -examples

This example code implements a simple console-style timer that writes data to a [TextBlock](../microsoft.ui.xaml.controls/textblock.md) named `TimerLog` (XAML that defines `TimerLog` is not shown). The [Interval](dispatchertimer_interval.md) value is set to 1, and the log displays the actual elapsed time for each [Tick](dispatchertimer_tick.md).

[!code-csharp[1](../microsoft.ui.xaml/code/DispatcherTimer/csharp/MainPage.xaml.cs#Snippet1)]

``` cppwinrt
// MainPage.cpp
...
#include <chrono>
...
void MainPage::StartTimerAndRegisterHandler()
{
    Windows::UI::Xaml::DispatcherTimer timer;
    timer.Interval(std::chrono::milliseconds{ 500 });
    auto registrationtoken = timer.Tick({this, &MainPage::OnTick });
    timer.Start();
}

void MainPage::OnTick(Windows::Foundation::IInspectable const& /* sender */,
    Windows::Foundation::IInspectable const& /* e */)
{
    // do something on each tick here ...
}
```

## -see-also

[CoreDispatcher](/uwp/api/windows.ui.core.coredispatcher), [ThreadPoolTimer](/uwp/api/windows.system.threading.threadpooltimer)
