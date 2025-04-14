public class Crater
{
    private double xCord;
    private double yCord;
    private double radius;
    private string craterName;

    public Crater(string line)
    {
        xCord = double.Parse(line.Split('\t')[0]);
        yCord = double.Parse(line.Split('\t')[1]);
        radius = double.Parse(line.Split('\t')[2]);
        craterName = line.Split('\t')[3];
    }

    public double XCord { get => xCord; }
    public double YCord { get => yCord;  }
    public double Radius { get => radius;  }
    public string CraterName { get => craterName; }
    public double Circumference { get => 2 * Math.PI * radius;}
    public double Area { get => Math.PI * Math.Pow(radius, 2);}

    public bool IsInside(Crater crater) => Math.Sqrt(Math.Pow(this.xCord - crater.xCord, 2) + Math.Pow(this.yCord - crater.yCord, 2)) < (this.radius - crater.radius);

}