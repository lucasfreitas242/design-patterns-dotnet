# Singleton Pattern Example in .NET

Este repositório demonstra a implementação do padrão Singleton em .NET. O padrão Singleton garante que uma classe tenha apenas uma instância e fornece um ponto de acesso global a essa instância. Neste exemplo, usamos a classe `Random` para ilustrar que a instância permanece a mesma ao longo do tempo.

## Implementação

A classe Singleton é implementada de maneira que apenas uma única instância da classe pode existir. Isso é conseguido através das seguintes etapas:

1. **Instância Estática**: A classe possui uma instância estática privada de si mesma. Esta instância é criada quando a classe é carregada pela primeira vez.

2. **Construtor Privado**: O construtor da classe é privado, impedindo que outras classes criem novas instâncias da classe Singleton diretamente.

3. **Propriedade de Instância**: A classe fornece uma propriedade pública que retorna a instância única da classe. Esta propriedade garante acesso global à instância Singleton.

4. **Valor Aleatório**: Para demonstrar que a instância é única, um valor aleatório é gerado e armazenado em um campo quando a instância é criada. Este valor permanece o mesmo em todas as referências à instância Singleton.

## Por que o `Random` foi usado?

O `Random` foi utilizado para gerar um valor aleatório no momento da criação da instância Singleton. Esse valor é armazenado em um campo da classe e serve para ilustrar que, independentemente de quantas vezes a instância Singleton seja acessada, o valor permanecerá o mesmo. Isto demonstra que a mesma instância está sendo utilizada, reforçando o conceito do padrão Singleton.

## Uso

Para utilizar a classe Singleton, você deve acessar a instância única através da propriedade pública fornecida. Ao tentar acessar a instância múltiplas vezes, você verá que a mesma instância é retornada sempre, comprovando que apenas uma instância da classe é criada.

## Resultado Esperado

Quando você acessar a instância Singleton e verificar o valor armazenado, verá que o valor é o mesmo, independentemente de quantas vezes você acesse a instância. Isso confirma que a instância é única.

Além disso, ao comparar referências à instância Singleton, você descobrirá que todas as referências apontam para o mesmo objeto, reforçando o fato de que o padrão Singleton impede a criação de múltiplas instâncias da classe.

## Conclusão

Este exemplo demonstra como o padrão Singleton garante que apenas uma instância de uma classe seja criada, fornecendo um ponto de acesso global a essa instância. Este padrão é útil em situações onde uma única instância é necessária para gerenciar recursos compartilhados, como conexões de banco de dados ou configurações de aplicação.
