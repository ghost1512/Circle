class Circles
{
    float radius;
    public static void Main(string[] args)
    {
        Console.WriteLine("khong co ban kinh");
    }

    public Circles(float radius)
    {
        this.radius = radius;
    }

    public float Area()
    {
        float localRadius = 3.14f * radius * radius;
        return localRadius;
    }
    public float PermeteCircle()
    {
        float PermeteCircle = 3.14f * 2 * radius * radius;
        return PermeteCircle;
    }
}
