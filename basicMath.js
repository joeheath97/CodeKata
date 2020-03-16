/**
 * To out put a the "sum" depending on the operation passed in 
 * 
 * @param {String} operation 
 * @param {Number} value1 
 * @param {Number} value2 
 */

function basicOp(operation, value1, value2)
{
    var sum = 0;
    switch(operation)
    {
        case "+":
            sum = value1 + value2;
            break;
        case "-":
            sum = value1 - value2;
            break; 
        case "*":
            sum = value1 * value2;
            break; 
        case "/":
            sum = value1 / value2;
            break;   
    }

    return sum;
}

/**
 * Alternate way of geting sum.
 * The eval() function evaluates JavaScript code represented as a string.
 * 
 * @param {String} operation 
 * @param {Number} value1 
 * @param {Number} value2 
 */
function basicOp2(operation, value1, value2)
{
    return eval(value1 + operation + value2);
}
