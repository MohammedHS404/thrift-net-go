typedef i32 int

service CalculatorService {
  int add(1:int num1, 2:int num2),
  int subtract(1:int num1, 2:int num2),
  int multiply(1:int num1, 2:int num2),
  int divide(1:int num1, 2:int num2)
}