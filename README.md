# CJS.MudExtensions

MudBlazor extension components.

## Install

1. Add the NuGet package.
1. Ensure MudBlazor is set up (services + CSS + JS).

## Consumer Setup (Required)

Add the library stylesheet:

```html
<link href="_content/CJS.MudExtensions/cjs-mudextensions.css" rel="stylesheet" />
```

MudBlazor assets are also required for interactive components:

```html
<link href="_content/MudBlazor/MudBlazor.min.css" rel="stylesheet" />
<script src="_content/MudBlazor/MudBlazor.min.js"></script>
```

Register MudBlazor services:

```csharp
builder.Services.AddMudServices();
```

## Components

### `MudIsland`

Wrapper around `MudPaper` with an opt-in fill/scroll layout model.

```razor
<MudIsland Layout="FillAndScroll" Padding="16px" Elevation="3">
    ...
</MudIsland>
```

`Layout` values:
- `FillAndScroll` (default)
- `FillNoScroll`
- `Content`

### `MudIslandDataGrid<T>`

Always renders a `MudDataGrid` inside a `MudIsland`.

Outer wrapper styling uses `Class`/`Style`. Inner grid styling uses `InnerClass`/`InnerStyle`.

```razor
<MudIslandDataGrid T="MyRow" Items="Rows" IslandLayout="FillAndScroll" Class="my-card">
    <Columns>
        <PropertyColumn T="MyRow" TProperty="string" Property="x => x.Name" />
    </Columns>
</MudIslandDataGrid>
```
