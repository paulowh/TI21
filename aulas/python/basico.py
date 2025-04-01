#basico de python

print('''\033[36m██████  ██    ██ ████████ ██   ██  ██████  ███    ██
██   ██  ██  ██     ██    ██   ██ ██    ██ ████   ██
██████    ████      ██    ███████ ██    ██ ██ ██  ██
██         ██       ██    ██   ██ ██    ██ ██  ██ ██
██         ██       ██    ██   ██  ██████  ██   ████\033[0;0m''')

# numero = input('Digite um numero: ')
nome = 'Paulo'
idade = 14
endereco = 'rua dos bobo'
numero = 0
telefone = '19 992632392'
# print('\nCaro Sr. ' + nome + ' com a idade ' + str(idade) + 
#     ' residente na ' + endereco + ', nº' + str(numero) + ' e telefone ' + telefone)

print('\nCaro Sr. {} com a idade {} residente na {}, nº{} e telefone {}'
      .format(nome, idade, endereco, numero, telefone))

if idade > 17:
    print('você é maior de 18 anos')
elif idade < 10:
    print('você é menor que 10 anos')
else:
    print('você NÃO é MAIOR de 18 anos e NÃO é MENOR que 10 anos')

vogal = ['a', 'e', 'i', 'o', 'u']

if 'i' in 'aeiou':
    print('é vogal')
else:
    print('NÃO é vogal')

for i in range(10,11):
    print(str(i) + '- palmeiras sem mundial')

for letra in 'santos na serie B':
    print(letra)

'''
01 - atividade
- solicitar um numero ao usuario
- se o numero for menor ou igual a 0 peça que o usuario digite novamente até receber um numero valido
- deve percorrer do 0 até o numero escolhido
- no laço se o numero for PAR deve ficar em AZUL e se for IMPAR deve ficar em VERMELHO 
'''