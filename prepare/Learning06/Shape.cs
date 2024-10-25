public class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public virtual float GetArea()
    {
        // Default implementation, can be overridden
        return 0;
    }
}