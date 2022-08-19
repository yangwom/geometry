
 
## 1 - Crie uma classe `Rectangle`

Vamos começar com uma das formas mais simples, que é o retângulo.

<details>
  <summary>A classe <code>Rectangle</code> deve possuir uma propriedade <code>Width</code> e uma propriedade <code>Height</code>, ambas do tipo <code>double</code></summary><br />

Essas propriedades irão representar a largura e a altura do retângulo, respectivamente.
  
</details>

<details>
  <summary>A classe <code>Rectangle</code> deve possuir uma propriedade <code>Area</code> com um getter que utilize a altura e a largura para retornar o valor correto</summary><br />

A área de um retângulo é igual a largura * altura. Essa propriedade não deve ter um setter.
  
</details>

<details>
  <summary>A classe <code>Rectangle</code> deve possuir uma propriedade <code>Perimeter</code> com um getter que utilize a altura e a largura para retornar o valor correto</summary><br />

O perímetro de um retângulo é igual a soma de todos os seus lados. Essa propriedade não deve ter um setter.
  
</details>

<details>
  <summary>A classe <code>Rectangle</code> deve possuir um construtor que receba a altura e a largura como parâmetros, valide se ambas são maiores que zero e atribua os valores de <code>Width</code> e <code>Height</code></summary><br />

Caso algum dos parâmetros seja negativo, deverá ser lançada uma `ArgumentException` com a mensagem `"All sides must be greater than zero"`.
  
</details>

<details>
  <summary>Escreva testes unitários para a classe <code>Rectangle</code></summary><br />

Deve ser testado o seguinte:
- A classe deve designar os valores de `Width` e `Height` corretamente
- A classe deve retornar o valor da `Area` corretamente
- A classe deve lançar uma exceção ao recebe valores menores ou iguais a zero como parâmetros
  
</details>

## 2 - Crie uma classe `Square`

Como você aprendeu nas aulas de matemática, todo quadrado é também um retângulo, mas com todos os lados iguais. Vamos então criar uma classe que reflita isso.

<details>
  <summary>A classe <code>Square</code> deve ser derivada da classe <code>Rectangle</code></summary><br />

Todo quadrado é um subtipo de retângulo, pelo que faz sentido estabelecer aqui uma relação de herança.
  
</details>

<details>
  <summary>A classe <code>Square</code> deve ter um construtor que receba apenas um parâmetro <code>side</code> do tipo <code>double</code></summary><br />

Esse construtor deve repassar o valor de `side` para ambos os parâmetros do construtor da classe base.
  
</details>

<details>
  <summary>Escreva testes unitários para a classe <code>Square</code></summary><br />

Deve ser testado o seguinte:
- A classe deve ser herdeira de `Rectangle`
- `Width` e `Height` devem ser iguais e designados corretamente
- A classe deve retornar o valor da `Area` corretamente
- A classe deve lançar uma exceção ao recebe valores menores ou iguais a zero como parâmetros

</details>
  

## 3 - Crie uma classe `Parallelepiped`

Paralelepípedos são construtos com três dimensões, que possuem seis faces que são retângulos. Vamos criar uma classe que reflita isso.

<details>
  <summary>A classe <code>Parallelepiped</code> deve possuir uma propriedade <code>Width</code>, propriedade <code>Height</code> e uma propriedade <code>Depth</code>, as três do tipo <code>double</code></summary><br />

Essas propriedades irão representar a largura, a altura e a profundidade do paralelepípedo, respectivamente.
  
</details>

<details>
  <summary>A classe <code>Parallelepiped</code> deve possuir uma propriedade <code>Volume</code> com um getter que utilize a altura, a largura e a profundidade para retornar o valor correto</summary><br />

O volume de um paralelepípedo é igual a largura * altura * profundidade. Essa propriedade não deve ter um setter.
  
</details>


<details>
  <summary>A classe <code>Parallelepiped</code> deve possuir uma propriedade <code>FaceA</code>, uma propriedade <code>FaceB</code> e uma propriedade <code>FaceC</code>, as três do tipo `Rectangle`, utilizando altura, largura e profundidade para retornar retângulos que representem as suas faces</summary><br />

As faces devem representar o seguinte:
- Produto entre altura e largura
- Produto entre altura e profundidade
- Produto entre largura e profundidade
  
</details>

<details>
  <summary>A classe <code>Parallelepiped</code> deve possuir uma propriedade <code>SurfaceArea</code> com um getter que utilize as áreas das três faces para retornar o total da área de superfície</summary><br />

Some as áreas de todas as faces para retornar o valor da área de superfície do paralelepípedo.

Dica ✏️: Lembre-se que cada uma das três faces definidas deve ter sua área somada duas vezes, pois o paralelepípedo tem 6 faces, sendo que cada uma delas se repete uma vez.
  
</details>

<details>
  <summary>A classe <code>Parallelepiped</code> deve possuir um construtor que receba a altura, largura e profundidade como parâmetros, valide se todas são maiores que zero e atribua os valores de <code>Width</code>, <code>Height</code> e <code>Depth</code></summary><br />

Caso algum dos parâmetros seja negativo, deverá ser lançada uma `ArgumentException` com a mensagem `"All sides must be greater than zero"`.
  
</details>

<details>
  <summary>Escreva testes unitários para a classe <code>Parallelepiped</code></summary><br />

Deve ser testado o seguinte:
- `Width`, `Height` e `Depth` devem ser designados corretamente
- O volume deve retornar o valor correto
- A área de superfície deve retornar o valor correto
- As faces devem retornar as áreas corretas

</details>

## 4 - Crie uma classe `Cube`
Os cubos são subtipos de Paralelepípedos, mas suas faces são quadrados, o que torna a sua composição levemente diferente da classe base. Que tal especificarmos melhor essa característica?


<details>
  <summary>A classe <code>Cube</code> deve ser herdeira da classe <code>Parallelepiped</code></summary><br />

O primeiro passo aqui é definir a relação de herança entre as duas classes.
  
</details>

<details>
  <summary>A classe <code>Cube</code> deve ser ter uma propriedade <code>Side</code> do tipo double</summary><br />

Como temos todos os lados iguais, faz sentido podermos acessar o valor dos lados sem precisar especificar de qual lado estamos falando.
  
</details>

<details>
  <summary>A classe <code>Cube</code> deve ter um construtor que receba apenas um valor de <code>side</code>, repasse esse valor para todos os parâmetros da da classe <code>Parallelepiped</code> e o atribua à propriedade <code>Side</code></summary><br />
  
</details>

<details>
  <summary>Por fim, sobrescreva as propriedades <code>FaceA</code>, <code>FaceB</code> e <code>FaceC</code> da classe base para que o tipo retornado pelas três seja um <code>Square</code>, e não um <code>Rectangle</code></summary><br />

Como não existem propriedades virtuais, para sobrescrevê-las você pode simplesmente utilizar o modificador `new`.
  
</details>

<details>
  <summary>Escreva testes unitários para a classe <code>Cube</code></summary><br />

Deve ser testado o seguinte:
- A classe deve ser herdeira de `Parallelepiped`
- `Side` deve ser designado corretamente
- Todas as faces devem ser iguais e do tipo `Square`
- O volume deve ser retornado corretamente

</details>

Parabéns, agora você domina a utilização de composição e herança e pode ir rumo aos próximos desafios!
