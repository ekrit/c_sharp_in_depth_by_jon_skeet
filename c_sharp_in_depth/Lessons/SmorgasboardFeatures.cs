namespace c_sharp_in_depth.Lessons;

public class SmorgasboardFeatures
{
    // using static directives
    
    /*
         static Point PolarToCartesian(double degrees, double magnitude)
         {
          double radians = degrees * Math.PI / 180; 
          return new Point( 
          Math.Cos(radians) * magnitude, 
          Math.Sin(radians) * magnitude); 
         } 
          
         after adding this line:
          
         using static System.Math;
         
         static Point PolarToCartesian(double degrees, double magnitude)
         {
          double radians = degrees * PI / 180; 
          return new Point( 
          Cos(radians) * magnitude, 
          Sin(radians) * magnitude); 
         }
            
     */
}