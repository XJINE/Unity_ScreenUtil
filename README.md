# Unity_ScreenUtil

Convert between viwport-coord and screen-coord, and, any others.

## Import to Your Project

You can import this asset from UnityPackage.

- [ScreenUtil.unitypackage](https://github.com/XJINE/Unity_ScreenUtil/blob/master/ScreenUtil.unitypackage)


## How to use

``` csharp
ScreenUtil.ViewportToScreen(Vector2 coord)
ScreenUtil.ViewportToScreen(float coordX, float coordY)
ScreenUtil.ScreenToViewport(Vector2Int coord)
ScreenUtil.ScreenToViewport(int coordX, int coordY)
ScreenUtil.AspectRatio;
```