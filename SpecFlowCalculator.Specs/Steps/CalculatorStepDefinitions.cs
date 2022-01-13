namespace SpecFlowCalculator.Specs.Steps;
using Xunit;

[Binding]
public sealed class CalculatorStepDefinitions
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly ScenarioContext _scenarioContext;

    private readonly Calculator _calculator = new Calculator();
    
    private int _result;

    public CalculatorStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(int result)
    {
        Assert.Equal(result, _result);
    }

    [Given(@"the list number is (.*), (.*), (.*)")]
    public void GivenTheListNumberIs(int p0, int p1, int p2)
    {
        _calculator.ListNumber = new List<int>() {p0, p1, p2};
    }

    [When(@"the n numbers are added")]
    public void WhenTheNNumbersAreAdded()
    {
        _result = _calculator.Add();
    }

    [When(@"the n numbers are multiplied")]
    public void WhenTheNNumbersAreMultiplied()
    {
        _result = _calculator.Multiply();
    }

    [When(@"the n numbers are divided")]
    public void WhenTheNNumbersAreDivided()
    {
        _result = _calculator.Divide();
    }
}