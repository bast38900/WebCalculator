namespace WebCalculatorLib;

  /// 
  /// The interface represents a advanced operation that can be performed on two numbers.
  /// 
  public interface IAdvancedOperation
  {
    double Modulus(double a, double b);
    double Power(double a, double b);
    double SquareRoot(double a);
  }