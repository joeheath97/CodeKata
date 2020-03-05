// To only return 4 or 6 diget pin. 
/**
 * Regex Explained
 * 
 * \d = any diget
 * {Number} = exact number of digets
 * () bonding/ enclosing 
 * ^ start of 
 * $ end of 
 * 
 *  
 * */
function validatePIN (pin) 
{
    var validPin = new RegExp(/^(\d{4}|\d{6})$/); 

    return validPin.test(pin)

}

