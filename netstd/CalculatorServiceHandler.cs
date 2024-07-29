namespace netstd;

public class CalculatorServiceHandler: CalculatorService.IAsync{
    public Task<int> add(int num1, int num2, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(num1 + num2);
    }
    public Task<int> subtract(int num1, int num2, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(num1 - num2);
    }
    public Task<int> multiply(int num1, int num2, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(num1 * num2);
    }
    public Task<int> divide(int num1, int num2, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(num1 / num2);
    }
}