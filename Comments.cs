using System;
using System.Text;	

public class Comments
{
	
	public static void Main()
	{
		 String[] array = { "1","2","3"};
         Console.WriteLine(A2S.ArrayToString(array));//Calling ArrayToString Function.
	}
}
	/// <summary>
    /// This Class can help you to convert Array to String.
    /// </summary>
    /* This Class can help you to convert Array to String.
     * Thank You.
    */
class A2S
    {
		/// <summary>
   		/// Converts String Array to String.
    	/// </summary>
    	/// <param name="arr">A String Array</param>
    	/// <returns>String with all the array elements in it.</returns>
        public static String ArrayToString(string[] arr)//Method that performs conversiob from array to String
        {
            StringBuilder s1 = new StringBuilder();
            foreach(String i in arr)
            {
                s1.Append(i);
            }
            return s1.ToString();
            
        } 
   }