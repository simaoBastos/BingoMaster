# 🎱 BingoMaster

Um sorteador de bingo simples desenvolvido em **C# com Windows Forms**, com suporte a animação e efeitos sonoros.

---

## 📌 Funcionalidades

- 🎲 Sorteio de números de **1 a 75 sem repetição**
- 📜 Histórico dos números sorteados em tempo real
- 🎬 Animação opcional estilo "roleta"
- 🔊 Efeitos sonoros durante o sorteio
- 🔄 Reinício completo do jogo

---

## 🖥️ Interface

A aplicação contém:

- **Label principal** → exibe o número sorteado em destaque  
- **Lista (ListBox)** → histórico dos números sorteados  
- **CheckBox** → ativa/desativa a animação  
- **Botão "Sortear"** → realiza o sorteio  
- **Botão "Reiniciar"** → reinicia o jogo  

---

## ⚙️ Como funciona

- Os números de 1 a 75 são armazenados em uma lista (`globoDeNumeros`)
- A cada sorteio:
  - Um índice aleatório é escolhido
  - O número correspondente é exibido
  - Ele é removido da lista (não se repete)
- O histórico é atualizado automaticamente
- Quando os números acabam, o sistema encerra o jogo

---

## 🎬 Animação

Se ativada, a animação:

- Mostra números aleatórios rapidamente
- Vai desacelerando com o tempo
- Simula o efeito de um globo de bingo

---

## 🔊 Sons

O projeto utiliza dois arquivos de áudio:

- `tick.wav` → durante a animação  
- `ding.wav` → ao exibir o número final  

---

## 🚀 Como executar

1. Abra o projeto no **Visual Studio**
2. Certifique-se de que os arquivos estão no diretório do executável:
   - `tick.wav`
   - `ding.wav`
3. Execute o projeto (`F5`)

---

## 🧠 Estrutura básica

```csharp
// Inicializa os números
for (int i = 1; i <= 75; i++)
{
    globoDeNumeros.Add(i);
}

// Sorteio
int indice = random.Next(globoDeNumeros.Count);
int numero = globoDeNumeros[indice];

// Remove para não repetir
globoDeNumeros.RemoveAt(indice);
