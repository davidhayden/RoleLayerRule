# RoleLayerRule

RoleLayerRule.OrchardCore is an Orchard Core CMS Module that adds a `GlobalMethod`, called <em>role</em>. The method returns `true` if the current user is in the specfified role, otherwise `false`.

```
role("Administrator")
```

This method can be used as part of a layer rule to specify that widgets in a layer only be displayed to users in certain roles.

## Status

[![Build status](https://ci.appveyor.com/api/projects/status/y20etfv08kn6o5i7?svg=true)](https://ci.appveyor.com/project/davidhayden/rolelayerrule) [![Status](https://img.shields.io/myget/davidhayden-ci/v/RoleLayerRule.OrchardCore.svg)](https://www.myget.org/feed/davidhayden-ci/package/nuget/RoleLayerRule.OrchardCore)

## Getting Started

Add the NuGet package, **RoleLayerRule.OrchardCore**, to the Orchard Core CMS Website. Launch the website and sign in as an administrator to enable the module from the dashboard under <i>Configuration</i> -> <i>Modules</i>.

![RoleLayerRule.OrchardCore](https://github.com/davidhayden/RoleLayerRule/blob/master/assets/role-layer-rule-orchard-core-cms-module.png?raw=true)

Create a new layer and specify that widgets in the layer are only visible to `Administrators` using the new <em>role</em> layer rule.

![Role Layer Rule](https://github.com/davidhayden/RoleLayerRule/blob/master/assets/create-layer-orchard-core-cms.png?raw=true)

Create a widget in a visible zone and specify that it is in the restricted layer created above. In this case, I created a <em>liquid widget</em> in the <em>Content</em> zone and placed it in the new <em>Admin</em> layer.

![Orchard Core CMS Widget](https://github.com/davidhayden/RoleLayerRule/blob/master/assets/add-orchard-core-cms-widget-to-layer.png?raw=true)

Browse to a route displaying the zone and verify that the widget is only displayed to users in the `Administrators` role.

## Bugs

There are no known bugs.

## Road map

There are no plans to add any additional features.

## Credits
RoleLayerRule.OrchardCore is created and maintained by David Hayden.