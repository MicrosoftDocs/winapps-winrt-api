---
-api-id: M:Microsoft.Windows.System.EnvironmentManager.SetEnvironmentVariable(System.String,System.String)
-api-type: winrt method
---

# Microsoft.Windows.System.EnvironmentManager.SetEnvironmentVariable(System.String,System.String)

<!--
public void SetEnvironmentVariable (string name, string value);
-->

## -description

Sets the value of the specified environment variable at the scope of the current [EnvironmentManager](environmentmanager.md).

## -parameters

### -param name

The name of the environment variable to set.

### -param value

The new value to set for the specified environment variable.

## -remarks

To remove an environment variable, call this method with an empty string as the *value*.

## -see-also

[GetEnvironmentVariable](environmentmanager_getenvironmentvariable_2043486755.md)

## -examples
