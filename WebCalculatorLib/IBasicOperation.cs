namespace WebCalculatorLib;

  /// 
  /// The interface represents a basic operation that can be performed on two numbers.
  /// 
  public interface IBasicOperation
  {
    double Add(double a, double b);
    double Subtract(double a, double b);
    double Multiply(double a, double b);
    double Divide(double a, double b);
  }