# Unity_ScreenUtil

Convert between screen-coord and pixel-coord, and, any others.

## Import to Your Project

You can import this asset from UnityPackage.

- [ScreenUtil.unitypackage](https://github.com/XJINE/Unity_ScreenUtil/blob/master/ScreenUtil.unitypackage)


## How to use

``` csharp
ScreenUtil.ScreenToPixel(Vertex2 coord);
ScreenUtil.ScreenToPixel(float coordX, float coordY);
ScreenUtil.PixelToScreen(Vertex2Int coord);
ScreenUtil.PixelToScreen(int coordX, int coordY);
ScreenUtil.AspectRatio;
```