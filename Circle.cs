namespace Homework7;

public class Circle
{
    public double radius {get; set;}
    const double PI = 3.14159265358979323846;

    public Circle(double radius) => this.radius = radius;

    public Circle() { }
    
    public void SetRadius(double radius) => this.radius = radius;
    public double GetRadius() => this.radius;
    public double GetArea() => Math.PI * this.radius * this.radius;
    public double GetDiameter() => 2 * this.radius;
    public double GetCircumference() => 2 * Math.PI * this.radius;
}