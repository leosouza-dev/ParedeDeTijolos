# Parede de Tijolos

## Desenvolvimento

Solução desenvolvida em C#, com uma api em ASP.NET Core 6.0 e Projeto de Teste usando NUnit.

## Complexidade Assintótica

Adicionei outras camada nessa solução, além do código responsável pelo calculo de **Menor Número de Tijolos Cortados**, mas vamos analisar somente essa Método que está na Classe **Parede.cs**:

A complexidade assintótica desse código é **O(nm)**, onde n é o número de linhas de tijolos e m é o comprimento máximo da parede.

O loop externo fornece a complexidade O(n), pois ele itera pelas linhas de tijolos na parede. O loop interno itera pelos tijolos em cada linha, tendo a complexidade total da lista é O(m).

Assim, a complexidade total é a multiplicação da complexidade do loop externo com a do loop interno.