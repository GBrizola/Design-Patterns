# Game Design Patterns

## O que foi feito

Este projeto consiste em um jogo de adivinhação desenvolvido em C#, que utiliza cinco padrões de projetos (Design Patterns) para modularizar e organizar o código. O jogo permite ao jogador escolher entre dois níveis de dificuldade (Fácil e Difícil) e tenta adivinhar um número gerado aleatoriamente. O objetivo foi aplicar conceitos de boas práticas de programação, como reutilização de código e separação de responsabilidades.

## Como executar

1. Clone este repositório:
   ```bash
   git clone https://github.com/GBrizola/Design-Patterns.git
   ```
2. Navegue até o diretório do projeto principal:
   ```bash
   cd Design-Pattens/GameDesignPatterns/Game
   ```
3. Restaure as dependências (se aplicável):
   ```bash
   dotnet restore
   ```
4. Compile e execute o jogo:
   ```bash
   dotnet run
   ```
5. Para rodar os testes unitários, navegue até o diretório dos testes e execute:
   ```bash
   cd ../GameTests
   dotnet test
   ```

## Padrões de Projeto Utilizados

### 1. **Strategy**
- **Descrição:** Define uma família de algoritmos, encapsula cada um deles e os torna intercambiáveis.
- **Uso:** As classes `EasyDifficulty` e `HardDifficulty` implementam a interface `IDifficultyStrategy`, permitindo alternar facilmente entre os níveis de dificuldade.

### 2. **Singleton**
- **Descrição:** Garante que uma classe tenha apenas uma instância e fornece um ponto global de acesso a ela.
- **Uso:** A classe `GameManager` é responsável por controlar o fluxo do jogo e utiliza o Singleton para evitar múltiplas instâncias.

### 3. **Factory Method**
- **Descrição:** Define uma interface para criar objetos, mas permite que as subclasses decidam qual classe instanciar.
- **Uso:** O Factory Method foi utilizado para criar jogadores (`Player`), possibilitando adicionar tipos diferentes de jogadores no futuro.

### 4. **Observer**
- **Descrição:** Define uma dependência um-para-muitos entre objetos, de modo que, quando um objeto muda de estado, seus dependentes são notificados.
- **Uso:** Implementado para notificar o jogador sobre dicas ou progresso no jogo.

### 5. **Command**
- **Descrição:** Encapsula uma solicitação como um objeto, permitindo parametrizar clientes com diferentes solicitações.
- **Uso:** Utilizado para implementar as opções do menu, como iniciar o jogo ou sair.

## Autores

Rafael Rodrigues e Gabriel Brizola

## Link do Vídeo

[Video](link)
