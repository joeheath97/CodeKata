/*
    Function to sort odd number in an array, 
    but to leave even number at their index.
*/
function sortArray(array)
{
    var oddArray = [];

    for(var i = 0; i < array.length; i++)
    {
        if(array[i]%2 !== 0)
        {
            console.log(array[i])
            oddArray.push(array[i]);
            array.splice(i,1,0);
        }
    }

    oddArray.sort();

    for(var j = 0; j < array.length; j++)
    {
        if(array[j]==0)
        {
            array.splice(j, 1, oddArray.shift())
        }
    }

    return array;
}

console.log(sortArray([2,2,1,4,7,6,5]));