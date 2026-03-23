# 🧮 CalculadoraCS — Calculadora e IMC

Aplicação desktop em **C# Windows Forms** com calculadora completa de operações matemáticas e calculadora de IMC (Índice de Massa Corporal) com classificação automática.

---

## ✨ Funcionalidades

### Calculadora
- ✅ Operações básicas: adição, subtração, multiplicação e divisão
- ✅ Suporte a números decimais com vírgula
- ✅ Botão de limpar entrada (`C`) e limpar tudo (`CE`)
- ✅ Interface com tema escuro e botões coloridos por categoria

### Calculadora de IMC
- ✅ Cálculo do IMC a partir de peso e altura
- ✅ Classificação automática em 6 categorias (abaixo do peso até obesidade mórbida)
- ✅ Resultado exibido com duas casas decimais

---

## 🛠️ Tecnologias

| Tecnologia | Versão | Uso |
|---|---|---|
| C# | .NET 10 | Linguagem principal |
| Windows Forms | .NET 10 | Interface gráfica |

---

## 📁 Estrutura do projeto

```
CalculadoraCS/
└── 4.WindowsForms/
    └── Calculadora/
        ├── FrmCalculadora.cs    # Formulário da calculadora principal
        └── FrmIMC.cs            # Formulário da calculadora de IMC
```

---

## 🚀 Como executar

### Pré-requisitos

- [.NET SDK 10](https://dotnet.microsoft.com/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou superior

### Passos

1. **Clone o repositório**
```bash
git clone https://github.com/guilhermemorelidev/CalculadoraCS.git
cd CalculadoraCS
```

2. **Abra a solução no Visual Studio e pressione F5**

O projeto inicia pela calculadora principal (`FrmCalculadora`). Para abrir o formulário de IMC, clique no botão **IMC** dentro da calculadora.

---

## 📐 Classificação de IMC

| IMC | Classificação |
|---|---|
| ≤ 18,5 | Abaixo do peso |
| 18,5 – 24,9 | Peso ideal |
| 25,0 – 29,9 | Acima do peso |
| 30,0 – 34,9 | Obesidade grau 1 |
| 35,0 – 39,9 | Obesidade severa |
| ≥ 40,0 | Obesidade mórbida |

---

## 📄 Licença

MIT © [Guilherme Moreli](https://github.com/guilhermemorelidev)
