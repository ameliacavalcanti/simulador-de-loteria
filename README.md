# 🎰 Loteria em C#

Um simulador de loteria feito em **C#**.  
O usuário escolhe **6 números entre 1 e 60**, o programa realiza um sorteio aleatório e informa quantos números foram acertados.

---

## 📌 Funcionalidades
- Escolha de 6 números entre 1 e 60 (com validação para não repetir e não sair do intervalo).
- Sorteio automático de 6 números aleatórios.
- Comparação entre a aposta e o sorteio.
- Exibição do resultado com mensagens personalizadas:
  - 6 acertos → Parabéns, você ganhou na loteria!
  - 4 ou 5 acertos → Muito bem! Você fez uma boa pontuação.
  - Menos de 4 acertos → Não foi dessa vez. Tente novamente.

---

## 🛠️ Tecnologias utilizadas
- **C#**
- **.NET SDK**
- Biblioteca `System.Linq` para interseções e validações.

---

## 🚀 Como executar
1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/loteria-csharp.git
   ```
2. Abra o projeto em uma IDE como **Visual Studio** ou **Visual Studio Code**.
3. Compile e execute o programa.
4. Digite 6 números válidos e veja o resultado do sorteio.

---

## 🎯 Exemplo de uso
```
===========LOTERIA==========
Escolha 6 numeros de 1 a 60
Numero1: 5
Numero2: 10
Numero3: 23
Numero4: 34
Numero5: 45
Numero6: 50

Sua aposta: 5, 10, 23, 34, 45, 50
Numeros sorteados: 3, 10, 23, 40, 45, 59

Você acertou 3 numero(s)!
Não foi dessa vez. Tente novamente.
```

---

## 📜 Licença
Este projeto é livre para estudo e uso pessoal.
