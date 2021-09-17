---
-api-id: P:Microsoft.Windows.ApplicationModel.DynamicDependency.AddPackageDependencyOptions.Rank
-api-type: winrt property
---

# Microsoft.Windows.ApplicationModel.DynamicDependency.AddPackageDependencyOptions.Rank

<!--
public int Rank { get; set; }
-->


## -description

The rank to use to add the resolved package to the caller's package graph.

## -property-value

## -remarks

For more information about the rank value, see the remarks for the [PackageDependency.Add](packagedependency_add_1022868492.md) method.

If multiple packages are present in the package graph with the same rank, you can ensure the resolved package is added before others of the same rank by using the [PrependIfRankCollision](addpackagedependencyoptions_prependifrankcollision.md) property.

## -see-also

[PackageDependency.Add](packagedependency_add_1022868492.md), [PrependIfRankCollision](addpackagedependencyoptions_prependifrankcollision.md)

## -examples
