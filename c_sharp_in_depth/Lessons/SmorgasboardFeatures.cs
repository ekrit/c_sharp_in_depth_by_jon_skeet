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
    
    /*
            var readingCustomers = allCustomers
                .Where(c => c.Profile.DefaultShippingAddress.Town == "Reading");
                
            what if some of these are null
            
            var readingCustomers = allCustomers
                .Where(c => c.Profile != null &&
                c.Profile.DefaultShippingAddress != null &&
                c.Profile.DefaultShippingAddress.Town == "Reading");
                
            this is a lot of code
            
            var readingCustomers = allCustomers
                .Where(c => c.Profile?.DefaultShippingAddress?.Town == "Reading");
                
            ? fixes everything here
            
            ---------------------------------------------------------------------------
            
            if (name?.Equals("X") ?? false)
            
            is same as
            
            if (name?.Equals("X") == true)
            
            ---------------------------------------------------------------------------
            
            if (name?.Equals("X") ?? true)
            
            is same as
            
            if (name?.Equals("X") != false)
            
            ---------------------------------------------------------------------------
            
     */
}
