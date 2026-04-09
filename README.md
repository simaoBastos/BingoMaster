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

## 📦 Download

Para baixar o programa:

1. Vá até a aba **Releases** do repositório
2. Baixe o arquivo `.zip` mais recente
3. Extraia os arquivos em qualquer pasta

---

## ▶️ Como executar

1. Abra a pasta extraída
2. Execute o arquivo: BingoMaster.exe

> ⚠️ Certifique-se de que os arquivos abaixo estão na mesma pasta:
>
> - `tick.wav`
> - `ding.wav`

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

## 🛠️ Tecnologias

- C#
- .NET (Windows Forms)
- System.Media

---

## 💡 Melhorias futuras

- ✨ Animação com fade-in no número final  
- 🎨 Interface mais estilizada  
- 🔊 Narração dos números sorteados  
- 📤 Exportar histórico  
- 🌐 Versão web  

---

## 📄 Licença

Livre para uso, modificação e zoeira 👍
