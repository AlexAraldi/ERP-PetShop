﻿
using PetShopConsoleApp1.Compartilhado;

namespace PetShopConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        TelaPrincipal telaPrincipal = new TelaPrincipal();

        while (true)
        {
            telaPrincipal.ApresentarMenuPrincipal();

            ITelaCrud telaSelecionada = telaPrincipal.ObterTela();

            if (telaSelecionada == null)
                break;

            char opcaoEscolhida = telaSelecionada.ApresentarMenu();

            switch (opcaoEscolhida)
            {
                case '1': telaSelecionada.CadastrarRegistro(); break;
                case '2': telaSelecionada.EditarRegistro(); break;
                case '3': telaSelecionada.ExcluirRegistro(); break;
                case '4': telaSelecionada.VisualizarRegistros(true); break;

                default: break;
            }
        }
    }
}