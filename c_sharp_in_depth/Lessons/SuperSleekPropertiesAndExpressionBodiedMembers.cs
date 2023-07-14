namespace c_sharp_in_depth.Lessons;

public class SuperSleekPropertiesAndExpressionBodiedMembers
{
    /*
    public sealed class Point
    {
        private double x, y;
        public double X { get { return x; } set { x = value; } } 
        public double Y { get { return y; } set { y = value; } }
    }
    
    is same as 
        
    public sealed class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    */
    
    
    
    
    /*
    public sealed class Point
    {
        private readonly double x, y; 
        public double X { get { return x; } } 
        public double Y { get { return y; } } 
        public Point(double x, double y)
        {
            this.x = x; 
            this.y = y; 
        }
    }
    
    is same as
        
    public sealed class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    */
    
    
    
    
    /*
    public class Person
    {
        public List<Person> Friends { get; set; } = 
            new List<Person>(); 
    }
    
        Declares and initializes a read/write 
        automatically implemented
    */
    
    
    
    /*
     
    public double DistanceFromOrigin 
    { 
        get { return Math.Sqrt(X * X + Y * Y); } 
    }
    
    becomes
        
    public double DistanceFromOrigin => Math.Sqrt(X * X + Y * Y);

     */

    // Declares a read-only property
    // public int Foo => 0;
    // Declares a read/write public field
    // public int Foo = 0;
    
    
    
}