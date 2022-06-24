# Unity_ScreenUtil

Convert between viewport-coord and screen-coord, and, any others.

## Importing

You can use Package Manager or import it directly.

```
https://github.com/XJINE/Unity_ScreenUtil.git?path=Assets/Packages/ScreenUtil
```

## How to use

``` csharp
ScreenUtil.ViewportToScreen(Vector2 coord)
ScreenUtil.ViewportToScreen(float coordX, float coordY)
ScreenUtil.ScreenToViewport(Vector2Int coord)
ScreenUtil.ScreenToViewport(int coordX, int coordY)
ScreenUtil.AspectRatio;
```