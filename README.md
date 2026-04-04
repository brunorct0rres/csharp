# C# Study Center

Repositório de estudos de **C#** e **.NET**, baseado em curso prático. O conteúdo cresce conforme os exercícios e experimentos realizados ao longo do aprendizado.

---

## Estrutura do Repositório

```structure
csharp/
├── FirstProject/       # Primeiro projeto: Hello World
├── Course/             # Projeto do curso: fundamentos da linguagem
├── FirstExercise/      # Primeiro exercício: tipos de dados e formatação
└── SecondExercise/     # Segundo exercício: leitura de dados do usuário
```

---

## Projetos

### 🟢 FirstProject
>
> Primeiro contato com C# e .NET.

- Criação de um projeto console
- Exibição de mensagem com `Console.WriteLine`

---

### 📘 Course
>
> Projeto acompanhando as aulas do curso.

Conteúdos abordados:

- Tipos primitivos: `bool`, `char`, `sbyte`, `byte`, `int`, `long`, `float`, `double`, `decimal`, `string`, `object`
- Limites dos tipos numéricos (`int.MinValue`, `int.MaxValue`, etc.)
- Formatação de números com `ToString("F2", CultureInfo.InvariantCulture)`
- Três formas de compor strings:
  - Concatenação (`+`)
  - Placeholders (`{0}`, `{1}`)
  - Interpolação (`$"..."`)

---

### 📝 FirstExercise
>
> Exercício sobre variáveis, tipos e formatação de saída.

- Declaração e uso de variáveis de diferentes tipos
- Formatação de casas decimais com `F2`, `F3` e `F8`
- Uso de `CultureInfo.InvariantCulture` para separador decimal invariante
- Interpolação de strings

---

### 📝 SecondExercise
>
> Exercício sobre leitura e processamento de dados do usuário.

- Leitura de entradas com `Console.ReadLine()`
- Conversão de tipos: `int.Parse`, `double.Parse`
- Leitura de múltiplos valores em uma linha com `Split(' ')`
- Formatação de saída com `CultureInfo.InvariantCulture`

---

## Tópicos Cobertos até Agora

- [x] Fundamentos da linguagem C#
- [x] Tipos de dados primitivos
- [x] Formatação e cultura de números
- [x] Leitura de dados do usuário via console
- [x] Interpolação, concatenação e placeholders
- [ ] Orientação a objetos
- [ ] .NET Core (APIs, serviços)
- [ ] Entity Framework Core

---

## Recursos de Referência

- [Documentação oficial do C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)
- [Documentação do .NET](https://learn.microsoft.com/pt-br/dotnet/)
- [Documentação do Entity Framework Core](https://learn.microsoft.com/pt-br/ef/core/)
