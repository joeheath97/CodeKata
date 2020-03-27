/**
 * Rock, Paper, Scissors
 * 
 * @param {String} Player1
 * @param {String} Player2
 * @return {String} results 
 * 
 */

const result = (Player1, Player2) => 
{
    if(Player1 === Player2) return "Draw!";

    //Creating Object as the rules
    var rules = {rock:"scissors", paper: "rock", scissors: "paper"};

    if(Player2 === rules[Player1])
    {
        return "Payer 1 Won!";
    }
    else
    {
        return "Player 2 Won!";
    }
}

console.log(result('rock', 'scissors'));
