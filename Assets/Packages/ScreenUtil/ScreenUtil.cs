using UnityEngine;

public static class ScreenUtil
{
    #region Property

    public static float AspectRatio => (float)Screen.width / Screen.height;

    #endregion Property

    #region Method

    public static Vector2Int ViewportToScreen(in Vector2 viewport, in bool normalize = false)
    {
        return ViewportToScreen(viewport.x, viewport.y, normalize);
    }

    public static Vector2Int ViewportToScreen(in float viewportX, in float viewportY, bool normalize = false)
    {
        return normalize ? new Vector2Int((int)Mathf.Lerp(0, Screen.width,  viewportX),
                                          (int)Mathf.Lerp(0, Screen.height, viewportY))
                         : new Vector2Int((int)(Screen.width  * viewportX),
                                          (int)(Screen.height * viewportY));
    }

    public static Vector2 ScreenToViewport(in Vector2Int screen, in bool normalize = false)
    {
        return ScreenToViewport(screen.x, screen.y, normalize);
    }

    public static Vector2 ScreenToViewport(in Vector3 screen, in bool normalize = false)
    {
        // NOTE:
        // Input.mousePosition returns Vector3 type value.

        return ScreenToViewport((int)screen.x, (int)screen.y, normalize);
    }

    public static Vector2 ScreenToViewport(in int screenX, in int screenY, in bool normalize = false)
    {
        var viewport = new Vector2((float) screenX / Screen.width, (float) screenY / Screen.height);

        if (normalize)
        {
            viewport.x = Mathf.Lerp(0, 1, viewport.x);
            viewport.y = Mathf.Lerp(0, 1, viewport.y);
        }

        return viewport;
    }

    #endregion Method
}