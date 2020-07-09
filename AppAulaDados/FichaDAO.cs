using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;

namespace InventarioDados
{

    public class FichaDao
    {
        public Boolean salvarFicha(Ficha Ficha)
        {
            Boolean salvo = false;
            salvo = true;

            return salvo;
        }

        public Boolean alterarFicha(Ficha Ficha)
        {
            Boolean salvo = false;

            salvo = true;

            return salvo;
        }
        public List<Ficha> carregarFichas()
        {
            List<Ficha> listaDeFichas = new List<Ficha>();
            mockListaDeFichas(listaDeFichas);
            return listaDeFichas;
        }
        public void mockListaDeFichas(List<Ficha> listaDeFichas)
        {
            Ficha Ficha1 = new Ficha();
            Ficha1.Nome = "Hazel";
            Ficha1.Casta = "Hashmalim";
            Ficha1.Origem = "Celestial / Exilada";
            Ficha1.Signo = "Lua";
            Ficha1.Ciclo = "5º Ma'on";
            Ficha1.Jogador = "Yaaz";
            Ficha1.Sexo = "Feminino";
            Ficha1.DivCam = "Controle Gravitacional ; Luz e Trevas - Trevas ; Visão Espiritual ; Controlar o Tecido ; Controlar Almas ; Controle Molecular ; Implantar Ilusões ; Ler Emoções ; Fusão com as Trevas ; Abalo Espiritual ; Forma de Sombra	; Ressurreição ; Criar vida ; Solidificar a Escuridão ; Transporte Espiritual ; Cortina de Aço ; Ilusão Assassina" ;

            Ficha1.Caract = "Cárcere do Avatar ; Carisma ; Reflexos Rápidos ; Vida Mortal ; Asas Afiadas";
			
			Ficha1.Propried = "Synchress: Arma Celestial ; Flickblades: Arma Branca (8x) ; Beretta 92FS: Arma de Fogo ; Crânio ; Harley Davidson 1200 Custom: Motocicleta";
			
            listaDeFichas.Add(Ficha1);

			
			
            Ficha Ficha2 = new Ficha();
            Ficha2.Nome = "Kamui";
            Ficha2.Casta = "Elohim";
            Ficha2.Origem = "Celestial";
            Ficha2.Signo = "Terra";
            Ficha2.Ciclo = "4º Zebul";
            Ficha2.Jogador = "K";
            Ficha2.Sexo = "Masculino";
            Ficha2.DivCam = "Controle Gravitacional ; Ler Emoções ; Controlar o Tecido ; Transporte Espiritual" ;

            Ficha2.Caract = "Reflexos Rápidos ; Vida Mortal";
			
			Ficha2.Propried = " - ";
			
            listaDeFichas.Add(Ficha2);



        }
    }
}
