---
-api-id: P:Microsoft.Windows.ApplicationModel.DynamicDependency.AddPackageDependencyOptions.PrependIfRankCollision
-api-type: winrt property
---

# Microsoft.Windows.ApplicationModel.DynamicDependency.AddPackageDependencyOptions.PrependIfRankCollision

<!--
public bool PrependIfRankCollision { get; set; }
-->

## -description

When you call the [PackageDependency.Add](packagedependency_add_1022868492.md) method and multiple packages are present in the package graph with the same rank as specified by the [Rank](addpackagedependencyoptions_rank.md) property, this property indicates whether the resolved package is added before others of the same rank.

## -property-value

If **true**, the resolved package is added before others of the same rank. If **false**, the resolved package is not added before others of the same rank.

## -remarks

## -see-also

[PackageDependency.Add](packagedependency_add_1022868492.md)

## -examples


