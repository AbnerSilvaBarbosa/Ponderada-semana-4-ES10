# Relatório de Avanço: Métricas em .NET
## Artigo: Métricas Personalizadas em .NET


### Introdução

Neste relatório, registrei nosso progresso na implementação de métricas personalizadas em aplicativos .NET, seguindo as orientações do artigo "Métricas Personalizadas em .NET".

### Utilização
- SDK Utilizado: .NET Core 6 e versões posteriores
- Pacote NuGet: System.Diagnostics.DiagnosticSource versão 8 ou superior
- Versões do .NET Suportadas: .NET Core 6 e .NET Framework 4.6.1 e posteriores

### Conceitos Aprendidos
- Criação de Métricas Personalizadas:
  - Utilizamos a classe Meter para criar um grupo nomeado de instrumentos.
  - Criamos instrumentos do tipo Counter para registrar contagens.
  - Aprendemos a utilizar a API CreateCounter para criar instrumentos do tipo Counter.

<br>

- Tipos de Instrumentos Disponíveis:
  - Exploramos diferentes tipos de instrumentos, incluindo Counter, UpDownCounter, ObservableCounter, Histogram, e ObservableGauge.
  - Compreendemos as diferenças entre eles e suas aplicações práticas.

<br>

- Práticas Recomendadas:
  - Aprendemos boas práticas, como a criação de medidores apenas uma vez para códigos não destinados à DI e seguir diretrizes de nomenclatura para instrumentos e marcas.
  - Entendemos a importância de sincronização em acessos concorrentes e o impacto no desempenho.


### Execução do Programa

Para inicializar a aplicação eu apenas executei o arquivo <code>ConsoleApp-metrics.csproj</code> com a extensão [Code runner](https://marketplace.visualstudio.com/items?itemName=formulahendry.code-runner)

**Alem de ter o dotnet na maquina na versão 8^**


Abaixo estão os prints da execução do programa exibindo as saídas do console/terminal:

![localhost](./Assets/terminal.png)
![localhost](./Assets/getOne.png)
![localhost](./Assets/getTwo.png)
![localhost](./Assets/metrics.png)

## Conclusão

Este relatório documenta o progresso na implementação de métricas personalizadas em aplicativos .NET, conforme descrito. aprendi a criar e registrar diferentes tipos de instrumentos, bem como "linkar" métricas para uma análise mais detalhada. Além disso, entendemos a importância das práticas recomendadas para garantir um código de fácil manutenção.# Ponderada-semana-4-ES10
