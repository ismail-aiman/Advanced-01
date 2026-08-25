namespace Advanced_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //a generic class is a class that can work with any data type
            //and we use it because it is type safety,code reusability and performance 
            #endregion
            #region q3
            //multiple type parameters allows the class to have two differnt types of daya
            #endregion
            #region q4
            //a generic method is a method that can work with any data (the method is under the main method)

            #endregion
            #region q6
            // a generic interface is an interface that can work with any data type

            #endregion
            #region from q7 to 11
            //the struct constraint is that the type parameter must be a value type
            //the class constraint is that the type parameter must be a reference type
            //the new() constraint is that the type parameter must have a public parameterless constructor
            //the interface constraint is that the type parameter must implement a specific interface
            //the base class constraint is that the type parameter must be or derive from a specific base class 
            #endregion
            //q13
            //the default returns the defaoult value of the data type
            //q15
            //covariance and the out keyword is to specify that the type parameter is used only as output(return type)
            //q16
            //contravariance and the in keyword is to specify that the type parameter is used only as input(parameter type)
            //q17
            //the difference is that covariance is for output and contravariance is for input
            //q18
            //dont know
            //19
            //we can inherit from a generic class by specifying the type parameter when we inherit from it
        }

        #region q4
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        } 
        #endregion
        #region q5
        public static T FindMax<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        } 
        #endregion
    }
}
