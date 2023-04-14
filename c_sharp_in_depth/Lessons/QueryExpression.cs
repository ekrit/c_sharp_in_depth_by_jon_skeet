namespace c_sharp_in_depth.Lessons;

public class QueryExpression
{
   // var products = from product in dbContext.Products
   //                where product.StockCount > 0
   //                orderby product.Price descending
   //                select new { product.Name, product.Price };
   
   /*
     In this simple example many things are used
     
     - Anonymous object (new { product.Name, product.Price }) which 
       gives us the opportunity to save only the data we are interested in 
       without creating a DTO class or something similar
       
     - Implicit typing using var, which allows us to store this anonymous object locally
     
     - Query expressions, which you could do without in this case, but which make life
       a lot simpler for more-complicated queries
       
     - Lambda expressions, which are the result of the query expression translation
     
     - Extension methods, which allow the translated query to be expressed via the
       Queryable class because of dbContext.Products implementing IQueryable<Product>
       
     - Expression trees, which allow the logic in the query to be passed to the LINQ
       provider as data, so it can be converted into SQL and executed efficiently at the
       database
     
    */
}