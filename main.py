from openpyxl import Workbook, load_workbook

def config():
    try:
        wb = load_workbook(filename='campo.xlsx')
        config = wb['config']
    except: 
        wb = Workbook()
        config = wb.create_sheet('config')
        config.cell(column=1, row=1, value="linha")
        config.cell(column=2, row=1, value=5)
        config.cell(column=1, row=2, value="coluna")
        config.cell(column=2, row=2, value=5)

    linhas  = config.cell(column=2, row=1).value
    colunas =  config.cell(column=2, row=2).value

    wb.save('campo.xlsx')
    
    return linhas, colunas

def criarTabuleiro(quantLinha, quantColuna):
    for i in range(int(quantLinha)):
        for j in range(0, int(quantColuna)):
            print('{:5}'.format('[ ]') , end='')
        print()

quantLinha, quantColuna = config()
criarTabuleiro(quantLinha, quantColuna)

'''
Crie o menu de acesso do jogo com as seguintes opções "jogar, configurar, sair"
Hoje a gente vai criar o configurar, de as opções ao usuario para ele configurar o jogo dele
Nessas configurações coloque uma terceira config "dificuldade" o usuario vai poder escolher entre 1 - 3
'''


while True:
    opcao = input('1- Jogar \n2- Configurar \n3- Sair \nEscolha uma das oções: ')
    if opcao == '1':
        print('Jogar')
    elif opcao == '2':
        print('Configurar')
    elif opcao == '3':
        print('Sair')
        break
    else:
        print('\033[31mTu é besta?\033[0m')