// Alerta quando abre a página
// alert("Olá essa é minha página!");

// Vai mostrar o valor abaixo no console do navegador
// console.log(1); 

// Variaveis e Constantes
// criar uma variável - let e const
/*
let age = 25;
let year = 2020;

console.log(age, year);
age = 30;
console.log(age);


const points = 100;
console.log(points);
*/
// points = 101; // retorna erro ... Uma variável definida por meio de const não pode ser alterada.

/*
maneira antiga de criar variável --> var
var score = 75;
console.log(score);
*/

/*
Não pode haver espaço
cammelcase
Não pode começar com número
Palavras reservadas como let e const
*/

/*
    ----------------------------
    Tipos de dados em Javascript
    ----------------------------

    Numbers:    
    String:     
    Boolean:    
    Null:       Variável expicitamente colocada com valor nulo
    Undefined:  Variáveis que ainda não foram atribuídas um valor
    Object:     Arrays, Dates, Liberals
    Symbol:     Usadas em objetos
*/

/*
    ----------------------------
              Strings
    ----------------------------
*/


console.log("Hello World");
console.log('Hello World');
email = 'andre@andre.com';
console.log(email);

/*
    ----------------------------
      Strings  - Concatenation
    ----------------------------
*/

let primeiroNome = 'André';
let ultimoNome = 'Nevares';
let fullname = primeiroNome + ' ' + ultimoNome;
console.log(fullname);

/*
    ----------------------------
    Strings - Getting Characters
    ----------------------------
*/

// console.log(fullname[0]);
// console.log(fullname.length);

/*
    ----------------------------
    Strings - Methods
    ----------------------------
*/

// console.log(fullname.toUpperCase());
// let result = fullname.toLowerCase();
// console.log(result);

// console.log('Lembre-se da variável email: ' + email);
// let index = email.indexOf('@')
// console.log(index);