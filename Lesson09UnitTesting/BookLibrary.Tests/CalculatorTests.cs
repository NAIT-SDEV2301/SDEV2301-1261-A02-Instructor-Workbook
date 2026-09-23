using System;
using Xunit;

namespace Lesson09.Tests.Guided;

// CalculatorTests.cs
// Complete each test using Arrange, Act, and Assert.
// Then implement the corresponding Calculator method.

public class CalculatorTests
{
    [Fact]
    public void Add_ValidOperands_ReturnsExpectedSum()
    {
        // Arrange
        // 1. Create a Calculator.
        // 2. Choose two operands.
        // 3. Determine the expected sum.

        // Act
        // Call Add() and store the actual result.

        // Assert
        // Compare the expected and actual results.

        // Remove this line after completing the test.
        throw new NotImplementedException("TODO: Complete this test.");
    }

    [Fact]
    public void Subtract_ValidOperands_ReturnsExpectedDifference()
    {
        // Arrange
        // 1. Create a Calculator.
        // 2. Choose two operands.
        // 3. Determine the expected difference.

        // Act
        // Call Subtract() and store the actual result.

        // Assert
        // Compare the expected and actual results.

        // Remove this line after completing the test.
        throw new NotImplementedException("TODO: Complete this test.");
    }

    [Fact]
    public void Multiply_ValidOperands_ReturnsExpectedProduct()
    {
        // Arrange
        // 1. Create a Calculator.
        // 2. Choose two operands.
        // 3. Determine the expected product.

        // Act
        // Call Multiply() and store the actual result.

        // Assert
        // Compare the expected and actual results.

        // Remove this line after completing the test.
        throw new NotImplementedException("TODO: Complete this test.");
    }

    [Fact]
    public void Divide_NonZeroDivisor_ReturnsExpectedQuotient()
    {
        // Arrange
        // 1. Create a Calculator.
        // 2. Choose a dividend and a nonzero divisor.
        // 3. Determine the expected quotient.

        // Act
        // Call Divide() and store the actual result.

        // Assert
        // Compare the expected and actual double values.
        // Use the precision argument:
        // Assert.Equal(expected, actual, precision: 3);

        // Remove this line after completing the test.
        throw new NotImplementedException("TODO: Complete this test.");
    }

    [Fact]
    public void Divide_ZeroDivisor_ThrowsDivideByZeroException()
    {
        // Arrange
        // 1. Create a Calculator.
        // 2. Choose a dividend.
        // 3. Set the divisor to zero.

        // Act and Assert
        // Use Assert.Throws<DivideByZeroException>().
        // The call to Divide() should be placed inside a lambda expression.

        // Remove this line after completing the test.
        throw new NotImplementedException("TODO: Complete this test.");
    }

    // OPTIONAL EXTENSION
    //
    // After Add_ValidOperands_ReturnsExpectedSum passes,
    // convert it from a [Fact] into a parameterized [Theory].
    //
    // 1. Replace [Fact] with [Theory].
    // 2. Add at least three [InlineData] cases.
    // 3. Include positive, negative, and zero operands.
    // 4. Add a, b, and expected parameters to the test method.
}
