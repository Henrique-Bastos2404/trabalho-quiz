# Trabalho Prático Quiz

## Objetivo

Desenvolvimento de um aplicativo de consola com recurso às estruturas de dados ```struct``` e ```List```

## Desenvolvimento do Trabalho

- O trabalho é desenvolvido individualmente
- O trabalho consiste na criação de um jogo do tipo quiz, no qual o jogador deverá adivinhar a resposta correta a uma questão
- São apresentadas 3 respostas possíveis ao jogador, sendo que apenas uma está correta
- O jogo deve ter um sistema pontuação: inicialmente o jogador começa com 0 pontos
- Se o jogador acertar na resposta, ganha um ponto
- O jogo termina quando o jogador acertar todas as perguntas ou introduzir o comando **d**
- Devem ser utilizadas as estruturas ```struct``` e ```List``` para armazenar dados
- A classificação máxima a obter pelos alunos depende do esforço: quanto mais complexa e criativa for a aplicação, maior a probabilidade de obter uma classificação alta (desde que o aplicativo esteja corretamente desenvolvido e de acordo com os critérios de avaliação)
- Os alunos são encorajados a fazer, com base nestas especificações, aplicativos criativos e com mais funcionalidades, nomeadamente:
    - permitir que o jogo seja jogado por 2 ou mais jogadores
    - perguntas divididas em categorias
    - perguntas com pontuação diferente (por exemplo: questões mais difíceis valem mais pontos)
    - não haver repetição de perguntas
    - etc.

## Recursos

- O professor disponibiliza, na plataforma YouTube, um vídeo exemplificativo do funcionamento pretendido:
    - https://youtu.be/QJcJl_SiG9s

- O professor disponibiliza também, algum código na forma de um projeto C#: os alunos deverão completar e, se desejarem, melhorar o código

## Orientações técnicas

### Dados das questões

Os dados de cada questão são armazenados numa ```struct``` chamada ```Questao```.

Para cada questão são armazenados os seguintes dados:

- o texto da questão
- as 3 respostas possíveis
- qual a resposta correta: 1, 2 ou 3

Exemplo:

- **Texto**: "Félix de Avelar Brotero, patrono da nossa escola, era..."
- **Respostas possíveis**: "Botânico", "Médico", "Juíz"
- **Resposta correta**: 1 ("Botânico")

Para armazenar todas as questões deve ser criada uma ```List``` do tipo da ```struct Questao```

#### Dados do jogador

Os dados de cada jogador devem ser armazenados numa ```struct```.

Para cada jogador é necessário armazenar os seguintes dados:

- nome
- pontos

Se criar mais do que um jogador, deve ser criada uma ```List``` do tipo da ```struct``` para armazenar os dados dos jogadores.

#### Programação estruturada

Crie métodos para executar as seguintes operações:

- inicializar as questões: o método insere as questões e respetivas respostas na ```List``` de questões
- mostrar os dados do jogador: o método mostra na consola o nome e a pontuação do jogador
- mostrar o texto de uma questão e as respostas possíveis